using System;
using System.Collections.Generic;
using Exercise02.Methods;

namespace Exercise02
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            string answer;

            do
            {
                DateTime userInput = UserInput.UserDateInput();
                List<DateTime> holidays = NonWorkingDays.Holidays();

                Result.PrintResult(holidays, userInput);

                Console.WriteLine("Check for another day? Yes/No");

                answer = Console.ReadLine();
            } while (string.Equals(answer, "Yes", StringComparison.CurrentCultureIgnoreCase));
        }
    }
}