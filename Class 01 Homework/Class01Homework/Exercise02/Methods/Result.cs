using System;
using System.Collections.Generic;

namespace Exercise02.Methods
{
    public static class Result
    {
        public static void PrintResult(List<DateTime> holidays, DateTime userInput)

        {
            bool isHoliday = false;

            foreach (var holiday in holidays)
            {
                if (userInput == holiday)
                {
                    isHoliday = true;
                }
            }

            if (isHoliday || userInput.DayOfWeek == DayOfWeek.Saturday || userInput.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"{userInput.Day}/{userInput.Month}/{userInput.Year} is a non working day!");

                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"{userInput.Day}/{userInput.Month}/{userInput.Year} is {userInput.DayOfWeek} and is a  working day.");

                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}