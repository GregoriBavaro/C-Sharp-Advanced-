using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }

        public int LivesLeft { get; set; }

        public Cat(string name, int age, int livesLeft, bool lazy, string breed) : base(name, age)
        {
            LivesLeft = livesLeft;
            Lazy = lazy;
            Breed = breed;
        }

        public override string PrintInfo()
        {
            if (Lazy)
            {
                return $"{Name} is a lazy cat with {LivesLeft} lives left. {Name} is looking for a new home";
            }
            else
            {
                return $"{Name} is not a lazy cat with {LivesLeft} lives left. {Name} is looking for a new home";
            }
        }
    }
}