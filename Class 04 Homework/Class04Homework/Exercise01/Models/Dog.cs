using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }

        public string FavoriteFood { get; set; }

        public Dog(string name, int age, string breed, bool goodBoi, string favoriteFood) : base(name, age)
        {
            Breed = breed;
            GoodBoi = goodBoi;
            FavoriteFood = favoriteFood;
        }

        public override string PrintInfo()
        {
            if (GoodBoi)
            {
                return $"{Name} is a good boy, its favorite food is {FavoriteFood} and is looking for a new home";
            }
            else
            {
                return $"{Name} is a bad boy, its favorite food is {FavoriteFood} and is looking for a new home";
            }
        }
    }
}