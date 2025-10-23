using LibraryAPI.models.DTOS;
using LibraryAPI.models.entities;
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

        // GET: api/places/all  -> TODOS los places (ENTIDADES + Trails/Photos/Reviews/Amenities)
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Place>>> GetAllPlacesEntities()
        {
            var places = await _context.Place
                .AsNoTracking()
                .Include(p => p.Trails)
                .Include(p => p.Photos)
                .Include(p => p.Reviews)
                .Include(p => p.PlaceAmenities)
                    .ThenInclude(pa => pa.Amenity)
                .ToListAsync();

            return Ok(places);
        }

        // GET: api/places/{id} -> Place por ID (ENTIDAD completa con includes)
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Place>> GetPlaceByIdEntity(int id)
        {
            var place = await _context.Place
                .AsNoTracking()
                .Include(p => p.Trails)
                .Include(p => p.Photos)
                .Include(p => p.Reviews)
                .Include(p => p.PlaceAmenities)
                    .ThenInclude(pa => pa.Amenity)
                .FirstOrDefaultAsync(i => i.Id == id);

            if (place is null) return NotFound();
            return Ok(place);
        }

        // GET: api/places  -> Filtros opcionales sobre ENTIDADES completas
        //    ?category=...&difficulty=...
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Place>>> GetPlacesEntities(
            [FromQuery] string? category,
            [FromQuery] string? difficulty)
        {
            var query = _context.Place
                .AsNoTracking()
                .Include(p => p.Trails)
                .Include(p => p.Photos)
                .Include(p => p.Reviews)
                .Include(p => p.PlaceAmenities)
                    .ThenInclude(pa => pa.Amenity)
                .AsQueryable();

            if (!string.IsNullOrEmpty(category))
                query = query.Where(p => p.Category == category);

            if (!string.IsNullOrEmpty(difficulty))
                query = query.Where(p => p.Trails.Any(t => t.Difficulty == difficulty));

            var places = await query.ToListAsync();
            return Ok(places);
        }

        // POST: api/places
        [HttpPost]
        public async Task<ActionResult> CreatePlace([FromBody] PlacePostDTO place)
        {
            var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var newPlace = new Place
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

                return Ok(new { newPlace.Id });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return Problem(ex.Message);
            }
        }
    }
}
