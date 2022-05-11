using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models
{
    public class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
    }
}