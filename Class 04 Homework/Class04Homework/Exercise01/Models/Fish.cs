using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }

        public int Size { get; set; }

        public Fish(string name, int age, string breed, string color, int size) : base(name, age)
        {
            Breed = breed;
            Color = color;
            Size = size;
        }

        public override string PrintInfo()
        {
            return $"{Name} of {Breed} is {Size} meter long, and his color is {Color}";
        }
    }
}