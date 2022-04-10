using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models
{
    public static class DogShelter
    {
        public static List<Dog> Dogs = new List<Dog>();

        public static void PrintAll()
        {
            Console.WriteLine("Showing all of the dogs in the Shelter: ");

            for (int i = 0; i < Dogs.Count; i++)
            {
                Console.WriteLine($" ID:{Dogs[i].Id}) Name: {Dogs[i].Name} - Color: {Dogs[i].Color} ");
            }
        }
    }
}