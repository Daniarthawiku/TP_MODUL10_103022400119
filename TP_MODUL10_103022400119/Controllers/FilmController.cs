using Microsoft.AspNetCore.Mvc;
using TP_MODUL10_103022400119.Models;

namespace TP_MODUL10_103022400119.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private static List<Film> ListFilm = new List<Film>
        {
            new Film { Id = 1, Judul = "Inception", Sutradara = "Christopher Nolan", Tahun = "2010", Genre = "Sci-Fi", Rating = "9.0" },
            new Film { Id = 2, Judul = "Interstellar", Sutradara = "Christopher Nolan", Tahun = "2014", Genre = "Sci-Fi", Rating = "8.7" },
            new Film { Id = 3, Judul = "Parasite", Sutradara = "Bong Joon-ho", Tahun = "2019", Genre = "Thriller", Rating = "8.6" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Film>> GetAll()
        {
            return Ok(ListFilm);
        }

        [HttpGet("{id}")]
        public ActionResult<Film> GetByIndex(int id)
        {
            return Ok(ListFilm[id]);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Film newFilm)
        {
            ListFilm.Add(newFilm);
            return Ok(new { message = "Film Ditambahkan" });
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            ListFilm.RemoveAt(id);
            return Ok(new { message = $"Film {id} Dihapus" });
        }
    }
}
