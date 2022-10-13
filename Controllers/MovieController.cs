using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieGalleryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Title = "John Wick",
                    DateReleased = Convert.ToDateTime("10/09/2014"),
                    Genre = "Action",
                    Ratings = 4.6,
                }
            };
            return Ok(movies);
        }
        
    }
}
