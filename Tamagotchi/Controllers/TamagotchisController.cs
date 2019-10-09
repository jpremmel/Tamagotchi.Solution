using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;
using System;

namespace Tamagotchi.Controllers
{
    public class TamagotchisController : Controller
    {
        [HttpPost("/tamagotchis")]
        public ActionResult Index(List<string> names)
        {
            foreach(string name in names)
            {
                Pet pet = new Pet(name);
            }
            return View(Pet.PetsList);
        }

        [HttpPost("/tamagotchis/feed/{i}")]
        public ActionResult ShowFeed(int i)
        {
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