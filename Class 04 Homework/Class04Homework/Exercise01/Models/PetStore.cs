using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise01.Models
{
    public class PetStore<T> where T : Pet
    {
        public List<T> ListOfPets = new List<T>();

        public PetStore()
        {
            ListOfPets = new List<T>();
        }

        public void PrintPets()
        {
            for (int i = 0; i < ListOfPets.Count; i++)
            {
                if (ListOfPets.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Pets for Adoption in the Store");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{i + 1}) {ListOfPets[i].PrintInfo()}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public void BuyPet(string name)
        {
            try
            {
                var pet = ListOfPets.Single(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));
                ListOfPets.Remove(pet);
                Console.WriteLine($"{name} is ready for adoption");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Pet with the name {name} does not exist");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Add(T pet)
        {
            ListOfPets.Add(pet);
        }
    }
}