using LibraryAPI.models.entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace NatureAPi.Controllers
{
    [Route("api/photos")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly NatureDBContext _context;

        public PhotoController(NatureDBContext context)
        {
            _context = context;
        }

        // GET: api/photos  -> todas las fotos (solo entidades Photo)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Photo>>> GetAllPhotos()
        {
            var photos = await _context.Photo
                .AsNoTracking()
                .ToListAsync();

            return Ok(photos);
        }
    }
}
