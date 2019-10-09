using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
    public class TamagotchisController : Controller
    {
        [HttpPost("/tamagotchi")]
        public ActionResult Index(string name1, string name2, string name3)
        {
            Pet pet1 = new Pet(name1);
            Pet pet2 = new Pet(name2);
            Pet pet3 = new Pet(name3);
            return View(Pet.PetsList);
        }
    }
}