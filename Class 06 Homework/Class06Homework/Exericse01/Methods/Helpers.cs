using System;
using System.Collections.Generic;
using System.Text;

namespace Exericse01.Methods
{
    public static class Helpers
    {
        public static Action<string, ConsoleColor> printColor = (x, y) =>
            {
                Console.ForegroundColor = y;
                Console.WriteLine(x);
                Console.ResetColor();
            };
    }
}