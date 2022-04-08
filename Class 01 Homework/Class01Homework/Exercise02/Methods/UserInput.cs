using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02.Methods
{
    public static class UserInput
    {
        public static DateTime UserDateInput()
        {
            int day;
            int month;
            int year;

            Console.Write("Please enter the day: ");
            while (!int.TryParse(Console.ReadLine(), out day))
            {
                Console.WriteLine("Invalid input, please try again");
                Console.Write("Please enter the day: ");
            }

            Console.Write("Please enter the month: ");
            while (!int.TryParse(Console.ReadLine(), out month))
            {
                Console.WriteLine("Invalid input, please try again");
                Console.Write("Please enter the month: ");
            }

            Console.Write("Please enter the year: ");
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Invalid input, please try again");
                Console.Write("Please enter the year: ");
            }

            return new DateTime(year, month, day);
        }
    }
}