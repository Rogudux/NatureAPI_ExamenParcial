using LibraryAPI.models.DTOS;
using LibraryAPI.models.entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace NatureAPi.Controllers
{
    [Route("api/places")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly NatureDBContext _context;

        public PlaceController(NatureDBContext context)
        {
            _context = context;

        }
        
        //Por ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Place>> GetPlacesById(int id)
        {
            var placeId = await _context.Place
                .FirstOrDefaultAsync(i => i.Id == id);
            return Ok(placeId);
        }
        
        
        //Crear place
        [HttpPost]
        public async Task<ActionResult> CreatePlace(
            [FromBody] PlacePostDTO place)
        {
            
            var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var newPlace = new Place()
                {
                    Name = place.Name,
                    Description = place.Description,
                    Category = place.Category,
                    Latitude = place.Latitude,
                    Longitude = place.Longitude,
                    ElevationMeters = place.ElevationMeters,
                    Accessible = place.Accessible,
                    EntryFee = place.EntryFee,
                    OpeningHours = place.OpeningHours,
                    CreatedAt = DateTime.Now
                };

                _context.Place.Add(newPlace);
                await _context.SaveChangesAsync();
                
                await transaction.CommitAsync();
                
                return Ok();

            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return Problem(ex.Message);

            }
            
        }
        
        //Por categoria y dificultad
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlaceDTO>>> GetPlaces([FromQuery] string? category, [FromQuery] string? difficulty)
        {
            var query = _context.Place
                .Include(p => p.Trails)
                .Include(p => p.Photos)
                .Include(p => p.Reviews)
                .AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(p => p.Category == category);
            }

            if (!string.IsNullOrEmpty(difficulty))
            {
                query = query.Where(p => p.Trails.Any(t => t.Difficulty == difficulty));
            }

            // Proyección a DTOs usando .Select() con todas las propiedades correctas
            var placesDto = await query
                .Select(p => new PlaceDTO
                {
                    Name = p.Name,
                    Description = p.Description,
                    Category = p.Category,
                    Latitude = p.Latitude,
                    Longitude = p.Longitude,
                    OpeningHours = p.OpeningHours,
                    Trails = p.Trails.Select(t => new TrailDTO
                    {
                        Name = t.Name,
                        DistanceKm = t.DistanceKm,
                        EstimatedTimeMinutes = t.EstimatedTimeMinutes, 
                        Difficulty = t.Difficulty,
                        Path = t.Path, // Propiedad actualizada
                        IsLoop = t.IsLoop // Propiedad actualizada
                    }).ToList(),
                    Photos = p.Photos.Select(ph => new PhotoDTO
                    {
                        URL = ph.URL // Propiedad corregida a mayúsculas
                    }).ToList(),
                    Reviews = p.Reviews.Select(r => new ReviewDTO
                    {
                        Author = r.Author, // Propiedad actualizada
                        Rating = r.Rating,
                        Comment = r.Comment,
                        CreatedAt = r.CreatedAt // Propiedad actualizada
                    }).ToList()
                })
                .ToListAsync();

            return Ok(placesDto);
        }
        
        
    }
}
