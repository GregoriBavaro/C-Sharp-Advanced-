using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        protected Pet(string name, int age)
        {
            Name = name;

            Age = age;
        }

        public abstract string PrintInfo();
    }
}