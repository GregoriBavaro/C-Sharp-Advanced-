using System;
using System.Collections.Generic;

using System.Linq;

namespace Exercise01.Methods
{
    public static class ConsoleModifiers
    {
        public static ConsoleColor ConsoleColorDarkYellow()
        {
            ConsoleColor darkYellow = Console.ForegroundColor
            = ConsoleColor.DarkYellow;

            return darkYellow;
        }

        public static ConsoleColor ConsoleColorWhite()
        {
            ConsoleColor white = Console.ForegroundColor = ConsoleColor.White;

            return white;
        }
    }
}