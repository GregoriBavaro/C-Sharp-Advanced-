using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Methods
{
    public static class Calculations
    {
        public static string CalcSum(double number1, double number2)
        {
            double result = number1 + number2;

            string resultToString = result.ToString();

            return $"{number1} + {number2} = {resultToString}";
        }
    }
}