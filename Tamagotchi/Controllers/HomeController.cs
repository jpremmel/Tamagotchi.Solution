using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            Pet.ClearList();
            Pet.PetCount++;
            return View();
        }

        [HttpPost("/")]
        public ActionResult Create()
        {
            return RedirectToAction("Index");
        }

    }
}