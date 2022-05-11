using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise01.Methods
{
    public static class UserInput
    {
        public static string Name()
        {
            Console.Write("Please enter a name: ");

            string nameInput = Console.ReadLine();

            while (nameInput.Length <= 1)
            {
                Console.WriteLine("Invalid input, name must be more then 1 character");
                Console.Write("Please enter a name: ");
            }

            return nameInput;
        }

        public static int Age()
        {
            int ageInput;

            Console.Write("Please enter age: ");

            while (!Int32.TryParse(Console.ReadLine(), out ageInput))
            {
                Console.WriteLine("Invalid input, please enter a number");
                Console.Write("Please enter age: ");
            }

            return ageInput;
        }

        public static string Color()
        {
            Console.Write("Please enter color: ");

            string colorInput = Console.ReadLine();

            while (colorInput.Length == 0)
            {
                Console.WriteLine("Invalid input, please try again");
                Console.Write("Please enter color: ");
            }

            return colorInput;
        }
    }
}