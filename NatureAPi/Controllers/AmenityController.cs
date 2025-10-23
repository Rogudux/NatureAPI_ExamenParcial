using LibraryAPI.models.entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace NatureAPi.Controllers
{
    [Route("api/amenities")]
    [ApiController]
    public class AmenityController : ControllerBase
    {
        private readonly NatureDBContext _context;

        public AmenityController(NatureDBContext context)
        {
            _context = context;
        }

        // GET: api/amenities
        // Opcional: ?placeId=10 para filtrar por lugar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Amenity>>> GetAllAmenities([FromQuery] int? placeId)
        {
            if (!placeId.HasValue)
                return Ok(await _context.Amenity.AsNoTracking().ToListAsync());

            var amenities = await _context.PlaceAmenity
                .Where(pa => pa.PlaceId == placeId.Value)
                .Select(pa => pa.Amenity)
                .AsNoTracking()
                .ToListAsync();

            return Ok(amenities);
        }

    }
}