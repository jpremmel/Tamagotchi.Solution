using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;
using System;

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

        [HttpPost("/tamagotchis/feed/{i}")]
        public ActionResult ShowFeed(string n)
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>> n = " + n);
            // int i = int.Parse(n);
            Console.WriteLine(">>>>>>>>>>>>>>>>> i = " + i);
            for (int j = 0; j < Pet.PetsList.Count; j++)
            {
                if (j == i)
                {
                    Pet.PetsList[j].Feed();
                }
                else
                {
                    Pet.PetsList[j].Ignore();
                }
            }
            return View(Pet.PetsList);
        }

        [HttpPost("/tamagotchis/sleep/{i}")]
        public ActionResult ShowSleep(int i)
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>> i = " + i);
            for (int j = 0; j < Pet.PetsList.Count; j++)
            { 
                if (j == i)
                {
                    Pet.PetsList[j].Sleep();
                }
                else
                {
                    Pet.PetsList[j].Ignore();
                }
            }
            return View(Pet.PetsList);
        }

        [HttpPost("/tamagotchis/play/{i}")]
        public ActionResult ShowPlay(int i)
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>> i = " + i);
            for (int j = 0; j < Pet.PetsList.Count; j++)
            {
                if (j == i)
                {
                    Pet.PetsList[j].Play();
                }
                else
                {
                    Pet.PetsList[j].Ignore();
                }
            }
            return View(Pet.PetsList);
        }

        
    }
}