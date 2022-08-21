using eCommerce.Data.Services;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Models;

namespace eCommerce.Controllers
{
	public class ActorController : Controller
    {
        private readonly IActorService _service;

        public ActorController(IActorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")] ActorModel actor)
		{
            if (ModelState.IsValid)
			{
                return View(actor);
			}
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
		}

        //Get: Actors/Details/1
        public async Task<ActionResult> Details(int id)
		{
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
		}
    }
}
