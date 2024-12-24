using eTicket.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTicket.Controllers
{
    public class CinemaController : Controller
    {
        private readonly dbContext _dbcontext;

        public CinemaController(dbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            var producer = _dbcontext.Cinemas.ToList();
            return View(producer);
        }
    }
}
