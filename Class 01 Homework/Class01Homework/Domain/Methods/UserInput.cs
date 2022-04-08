using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise01.Methods
{
    public static class UserInput
    {
        public static List<string> UserInputNames()
        {
            List<string> names = new List<string>();

            ConsoleModifiers.ConsoleColorDarkYellow();

            Console.WriteLine(@"Please enter a couple of Names, after enter ""x"" or ""X"" when you are done.");

            ConsoleModifiers.ConsoleColorWhite();

            for (int i = 0; i <= names.Count + 1; i++)
            {
                names.Add(Console.ReadLine());

                if (names[i] == "x" || names[i] == "X")
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.BufferWidth));
                    Console.SetCursorPosition(0, Console.CursorTop);

                    names.RemoveAt(names.Count - 1);

                    break;
                }
            }
            return names;
        }

        public static string UserInputText()
        {
            ConsoleModifiers.ConsoleColorDarkYellow();

            Console.WriteLine("Please enter a sentence.");

            ConsoleModifiers.ConsoleColorWhite();

            string sentence = Console.ReadLine();
            return sentence;
        }
    }
}