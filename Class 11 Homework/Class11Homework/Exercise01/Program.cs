using Exercise01.Methods;
using Exercise01.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Exercise01
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Dogs information");

            string dogName = UserInput.Name();
            int dogAge = UserInput.Age();
            string dogColor = UserInput.Color();

            Dog dog = new Dog(dogName, dogAge, dogColor);

            string path = CreatingDirectory.CreatingFolder();
            string jsonFile = CreatingDirectory.CreatingFile(path);

            string json = JsonConvert.SerializeObject(dog);

            FileHelper.AppendTextFile(jsonFile, json);

            using (StreamReader sr = new StreamReader(jsonFile))
            {
                string readContent = sr.ReadToEnd();
                Console.WriteLine(readContent);
            }
        }
    }
}