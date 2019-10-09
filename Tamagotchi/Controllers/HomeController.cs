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
            if (Pet.PetCount == 0)
            {
                Pet.PetCount++;
            }
            return View();
        }

        [HttpPost("/")]
        public ActionResult Create()
        {
            Pet.PetCount++;
            return RedirectToAction("Index");
        }

    }
}