using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    public class MovieController : Controller
    {
        private readonly dbContext _dbcontext;

        public MovieController(dbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        public async Task< IActionResult> Index()
        {
            var allmovies = await _dbcontext.Movies.Include(c => c.cinema).ToListAsync();
            return View();
        }
    }
}
