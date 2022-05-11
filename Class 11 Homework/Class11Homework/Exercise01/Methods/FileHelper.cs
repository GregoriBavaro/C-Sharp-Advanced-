using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercise01.Methods
{
    public static class FileHelper
    {
        public static void AppendTextFile(string path, string json)
        {
            StreamWriter sw = new StreamWriter(path, true);
            if (json == "break")
            {
                throw new Exception("Error");
            }

            sw.WriteLine(json);
            sw.Dispose();
        }
    }
}