using eCommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext _context;

        public ActorController(AppDbContext AppDbContext)
        {
            _context = AppDbContext;
        }

        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View(data);
        }
    }
}
