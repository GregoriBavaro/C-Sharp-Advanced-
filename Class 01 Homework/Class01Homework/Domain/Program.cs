using System;
using System.Collections.Generic;
using Exercise01.Methods;

namespace Domain
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            List<string> names = UserInput.UserInputNames();
            string text = UserInput.UserInputText();

            Result.PrintResult(names, text);
        }
    }
}