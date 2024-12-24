using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    public class ProducerController : Controller
    {
        private readonly dbContext _dbcontext;

        public ProducerController(dbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        public async Task<IActionResult> Index()
        {
            var  producer = await _dbcontext.Producers.ToListAsync();
            return View();
        }
    }
}
