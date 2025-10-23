using LibraryAPI.models.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace NatureAPi.Controllers
{
    [Route("api/trails")]
    [ApiController]
    public class TrailController : ControllerBase
    {
        private readonly NatureDBContext _context;

        public TrailController(NatureDBContext context)
        {
            _context = context;
        }

        // GET: api/trails?difficulty=Easy
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrailDTO>>> GetTrails([FromQuery] string? difficulty)
        {
            var query = _context.Trail // <-- ajusta si tu DbSet se llama distinto
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(difficulty))
            {
                query = query.Where(t => t.Difficulty == difficulty);
            }

            var trailsDto = await query
                .Select(t => new TrailDTO
                {
                    Name = t.Name,
                    DistanceKm = t.DistanceKm,
                    EstimatedTimeMinutes = t.EstimatedTimeMinutes,
                    Difficulty = t.Difficulty,
                    Path = t.Path,
                    IsLoop = t.IsLoop
                })
                .ToListAsync();

            return Ok(trailsDto);
        }
    }
}