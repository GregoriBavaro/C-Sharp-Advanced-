using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercise01.Methods
{
    public static class CreatingDirectory
    {
        public static string CreatingFolder()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string absolutePath = currentDirectory;

            var jsonFilesFolder = absolutePath + @"\JsonFiles\";

            if (!Directory.Exists(jsonFilesFolder))
            {
                Directory.CreateDirectory(jsonFilesFolder);
            }

            return jsonFilesFolder;
        }

        public static string CreatingFile(string path)
        {
            string jsonFile = path + "json.json";

            if (!File.Exists(jsonFile))
            {
                File.Create(jsonFile).Close();
            }

            return jsonFile;
        }
    }
}