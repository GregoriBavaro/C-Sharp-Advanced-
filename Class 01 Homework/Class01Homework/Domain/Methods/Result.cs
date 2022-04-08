using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise01.Methods
{
    public static class Result
    {
        public static void PrintResult(List<string> names, string text)
        {
            ConsoleModifiers.ConsoleColorDarkYellow();

            Console.WriteLine("You have entered the following names: ");

            ConsoleModifiers.ConsoleColorWhite();

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {names[i]}");
            }

            ConsoleModifiers.ConsoleColorDarkYellow();

            Console.WriteLine("You have entered the following sentence:");

            ConsoleModifiers.ConsoleColorWhite();

            Console.WriteLine(text);

            string[] textToArray = text.Split(" ");

            foreach (string name in names)
            {
                int index = 0;
                foreach (string word in textToArray)
                {
                    if (string.Equals(word, name, StringComparison.CurrentCultureIgnoreCase))
                    {
                        index++;
                    }
                }
                ConsoleModifiers.ConsoleColorDarkYellow();

                if (index == 1)
                {
                    Console.WriteLine($"The name {name} was found {index} time in the sentence");
                }
                else
                {
                    Console.WriteLine($"The name {name} was found {index} times in the sentence");
                }

                ConsoleModifiers.ConsoleColorWhite();
            }
        }
    }
}