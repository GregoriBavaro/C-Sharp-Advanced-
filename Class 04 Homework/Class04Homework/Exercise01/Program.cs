using System;
using Exercise01.Models;
using System.Linq;
using System.Collections.Generic;

namespace Exercise01
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Cat cat1 = new Cat("Chris", 15, 5, false, "Persian Long Hair");
            Cat cat2 = new Cat("Garfield", 7, 2, true, "British Short Hair");
            Cat cat3 = new Cat("Luna", 2, 1, false, "Maine Coon");
            Cat cat4 = new Cat("Bella", 7, 9, true, "Rag doll");
            Cat cat5 = new Cat("Loki", 6, 10, false, "Siamese cat");
            Cat cat6 = new Cat("Leo", 3, 4, true, "Scottish Fold");

            Dog dog1 = new Dog("Ex", 7, "German Shepherd", true, "Cake");
            Dog dog2 = new Dog("Butch", 10, "Bulldog", false, "Pork");
            Dog dog3 = new Dog("Max", 7, "Labrador", true, "Bone");
            Dog dog4 = new Dog("Ollie", 10, "Chihuahua", false, "Chicken");
            Dog dog5 = new Dog("Oscar", 7, "Boxer", true, "Turkey");
            Dog dog6 = new Dog("Ozzy", 10, "Husky", false, "Lean beef");

            Fish fish1 = new Fish("Nemo", 1, "Platies", "Yellow", 1);
            Fish fish2 = new Fish("Sharky", 7, "Shark", "White", 5);

            PetStore<Cat> catStore = new PetStore<Cat>();
            catStore.Add(cat1);
            catStore.Add(cat2);
            catStore.Add(cat3);
            catStore.Add(cat4);
            catStore.Add(cat5);
            catStore.Add(cat6);

            PetStore<Dog> dogStore = new PetStore<Dog>();
            dogStore.Add(dog1);
            dogStore.Add(dog2);
            dogStore.Add(dog3);
            dogStore.Add(dog4);
            dogStore.Add(dog5);
            dogStore.Add(dog6);

            PetStore<Fish> fishStore = new PetStore<Fish>();
            fishStore.Add(fish1);
            fishStore.Add(fish2);

            Console.WriteLine("Cats for adoption:");

            catStore.PrintPets();

            Console.WriteLine("Dogs for adoption:");

            dogStore.PrintPets();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Buying a dog:");
            Console.ForegroundColor = ConsoleColor.White;

            dogStore.BuyPet("Ex");
            dogStore.BuyPet("Dull");
            dogStore.BuyPet("Oscar");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Buying a cat:");
            Console.ForegroundColor = ConsoleColor.White;

            catStore.BuyPet("Luna");

            Console.WriteLine("Cats left for adoption:");
            catStore.PrintPets();
            Console.WriteLine("Dogs left for adoption:");
            dogStore.PrintPets();
        }
    }
}