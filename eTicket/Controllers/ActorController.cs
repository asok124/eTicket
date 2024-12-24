using eTicket.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTicket.Controllers
{
    public class ActorController : Controller
    {
        private readonly dbContext _dbcontext;

        public ActorController(dbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            var data = _dbcontext.Actors.ToList();
            return View(data);
        }
    }
}
