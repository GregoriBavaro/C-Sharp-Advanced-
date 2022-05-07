using System;
using System.IO;
using Exercise01.Methods;

namespace Exercise01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string absolutePath = currentDirectory;

            var exerciseFolder = absolutePath + @"\Exercise\";

            if (!Directory.Exists(exerciseFolder))
            {
                Console.WriteLine($"Folder {exerciseFolder} does not exist. Creating folder...");

                Directory.CreateDirectory(exerciseFolder);

                Console.WriteLine($"Folder {exerciseFolder} was created");
            }

            string textFile = exerciseFolder + "calculations.txt";

            if (!File.Exists(textFile))
            {
                Console.WriteLine($"File {textFile} does not exist. Creating file...");

                File.Create(textFile).Close();

                Console.WriteLine($"File {textFile} was created");
            }

            double input_1;
            double input_2;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter two numbers to find the sum");

                Console.Write("Please enter your first number: ");

                while (!double.TryParse(Console.ReadLine(), out input_1))
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.Write("Please enter your first number: ");
                }

                Console.Write("Please enter your second number: ");

                while (!double.TryParse(Console.ReadLine(), out input_2))
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.Write("Please enter your second number: ");
                }

                string result = Calculations.CalcSum(input_1, input_2);

                DateTime localDate = DateTime.Now;

                string dateToString = localDate.ToString();

                FileHelper.AppendTextInFile(textFile, result, dateToString);
            }

            Console.WriteLine("Reading from text file: ");

            using (StreamReader sr = new StreamReader(textFile))
            {
                string readContent = sr.ReadToEnd();
                Console.WriteLine(readContent);
            }
        }
    }
}