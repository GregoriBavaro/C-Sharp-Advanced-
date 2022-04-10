using System;
using Exercise01.Models;

namespace Exercise01
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Dog dog1 = new Dog(1, "Cooper", "Brown");
            Dog dog2 = new Dog(2, "Max", "Brown");
            Dog dog3 = new Dog(3, "Oscar", "Golden");
            Dog dog4 = new Dog(4, "Ruby", "White");
            Dog dog5 = new Dog(5, "Walter", "White");

            Console.WriteLine("Checking if the class properties are all Valid");

            Console.WriteLine(Dog.Validate(dog1));
            Console.WriteLine(Dog.Validate(dog2));
            Console.WriteLine(Dog.Validate(dog3));
            Console.WriteLine(Dog.Validate(dog4));
            Console.WriteLine(Dog.Validate(dog5));

            DogShelter.Dogs.Add(dog1);
            DogShelter.Dogs.Add(dog2);
            DogShelter.Dogs.Add(dog3);
            DogShelter.Dogs.Add(dog4);
            DogShelter.Dogs.Add(dog5);

            DogShelter.PrintAll();

            dog1.Bark();
        }
    }
}