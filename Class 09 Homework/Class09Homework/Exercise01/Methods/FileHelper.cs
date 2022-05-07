using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercise01.Methods
{
    public static class FileHelper
    {
        public static void AppendTextInFile(string path, string result, string date)
        {
            StreamWriter sw = new StreamWriter(path, true);
            if (result == "break")
            {
                throw new Exception("Error");
            }

            sw.WriteLine($"Date of calculation: {date} - Calculation: {result}");
            sw.Dispose();
        }
    }
}