using System.Collections.Generic;

namespace Tamagotchi.Models
{
    public class Pet
    {
        public string Name { get; }
        public int FoodLevel { get; set; }
        public int Mood { get; set; }
        public int Fatigue { get; set; }
        public static List<Pet> PetsList = new List<Pet>{};
        public static int PetCount { get; set; }


        public Pet(string name)
        {
            Name = name;
            FoodLevel = 10;
            Mood = 10;
            Fatigue = 10;
            PetsList.Add(this);
        }

        public void Feed()
        {
            FoodLevel = 10;
            Mood -= 1;
            Fatigue -= 1;
        }

        public void Play()
        {
            Mood = 10;
            FoodLevel -= 1;
            Fatigue -= 1;
        }

        public void Sleep()
        {
            Fatigue = 10;
            Mood -= 1;
            FoodLevel -= 1;
        }

        public void Ignore()
        {
            Fatigue -= 1;
            Mood -= 1;
            FoodLevel -= 1;
        }
    }
}