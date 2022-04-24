using Exericse01.Enums;
using Exericse01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Exericse01.Methods;
using System.Dynamic;

namespace Exericse01
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Charlie", "Black", 3, Race.Collie), // 0
	            new Dog("Buddy", "Brown", 1, Race.Doberman),
                new Dog("Max", "Olive", 1, Race.Plott),
                new Dog("Archie", "Black", 2, Race.Mutt),
                new Dog("Oscar", "White", 1, Race.Mudi),
                new Dog("Toby", "Maroon", 3, Race.Bulldog), // 5
	            new Dog("Ollie", "Silver", 4, Race.Dalmatian),
                new Dog("Bailey", "White", 4, Race.Pointer),
                new Dog("Frankie", "Gray", 2, Race.Pug),
                new Dog("Jack", "Black", 5, Race.Dalmatian),
                new Dog("Chanel", "Black", 1, Race.Pug), // 10
	            new Dog("Henry", "White", 7, Race.Plott),
                new Dog("Bo", "Maroon", 1, Race.Boxer),
                new Dog("Scout", "Olive", 2, Race.Boxer),
                new Dog("Ellie", "Brown", 6, Race.Doberman),
                new Dog("Hank", "Silver", 2, Race.Collie), // 15
	            new Dog("Shadow", "Silver", 3, Race.Mudi),
                new Dog("Diesel", "Brown", 4, Race.Bulldog),
                new Dog("Abby", "Black", 1, Race.Dalmatian),
                new Dog("Trixie", "White", 8, Race.Pointer), // 19
            };

            List<Person> people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Rick", "Chapman", 35, Job.Dentist),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Developer),
                new Person("Richie", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Rocky", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter)
                { Dogs = new List<Dog>() {dogs[16], dogs[18] } },
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist)
                { Dogs = new List<Dog>(){dogs[6], dogs[0] } },
                new Person("Erin", "Rocha", 37, Job.Developer)
                { Dogs = new List<Dog>() {dogs[2], dogs[3], dogs[19] } },
                new Person("Freddy", "Gordon", 26, Job.Sculptor)
                { Dogs = new List<Dog>() {dogs[4], dogs[5], dogs[10], dogs[12], dogs[13] } },
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 28, Job.Dentist)
                { Dogs = new List<Dog>() {dogs[9], dogs[14], dogs[15] } }
            };

            // Find and print all persons first names starting with "R", order by Age - DESCENDING ORDER

            IEnumerable<Person> firstNamesStartigWithR2 =
                from person in people
                where person.FirstName.StartsWith("R")
                orderby person.Age descending
                select person;

            Helpers.printColor(@"1) All first names that start on the letter ""R"" order by Age: (DESCENDING ORDER)", ConsoleColor.Red);

            foreach (var person in firstNamesStartigWithR2)
            {
                Console.WriteLine($"Name: {person.FirstName} - Age: {person.Age}");
            }

            // Find and print all brown dogs names and ages older than 3 years, order by Age - ASCENDING ORDER

            IEnumerable<Dog> allBrownOlderThen3Dogs =
                from dog in dogs
                where dog.Color == "Brown"
                where dog.Age > 3
                orderby dog.Age
                select dog;

            Helpers.printColor("2) Brown dogs older then 3 years: (ASCENDING ORDER)", ConsoleColor.Red);

            foreach (var dog in allBrownOlderThen3Dogs)
            {
                Console.WriteLine($"Name: {dog.Name} - Age: {dog.Age} - Color: {dog.Color}");
            }

            // Find and print all persons with more then 2 dogs, ordered by name - DESCENDING ORDER

            IEnumerable<Person> allPErsonsWithMoreThen2Dogs =
                from person in people
                where person.Dogs.Count > 2
                orderby person.FirstName
                select person;

            Helpers.printColor("3) People with more then 2 dogs: (DESCENDING ORDER)", ConsoleColor.Red);

            foreach (var person in allPErsonsWithMoreThen2Dogs)
            {
                Console.WriteLine($"Name: {person.FirstName}");
            }

            // Find and print all Freddy's dogs names older than 1 year

            var allFreddysDogsOlderThanOne = people.Where(person => person.FirstName == "Freddy")
                .SelectMany(dog => dog.Dogs)
                .Where(dogs => dogs.Age > 1);

            Helpers.printColor("4) Freddy's dogs older than 1 year:", ConsoleColor.Red);

            foreach (var dog in allFreddysDogsOlderThanOne)
            {
                Console.WriteLine($"Name: {dog.Name} - Age: {dog.Age}");
            }

            // Find and print Nathen's first dog

            var nathensFirstDog = people.Where(x => x.FirstName == "Nathen")
                .Select(dog => dog.Dogs[0]);

            Helpers.printColor("5) Nathens first dog: ", ConsoleColor.Red);

            foreach (var dog in nathensFirstDog)
            {
                Console.WriteLine($"Name: {dog.Name} - Age: {dog.Age} - Color: {dog.Color} - Breed: {dog.Race}");
            }

            // Find and print all white dogs names from Cristofer, Freddy, Erin  and Amelia, ordered by Name - Ascending Order

            var allWhiteDogs = people.Where(person => person.FirstName == "Freddy" || person.FirstName == "Amelia" || person.FirstName == "Cristofer" || person.FirstName == "Erin")

                .SelectMany(dog => dog.Dogs)
                .Where(dog => dog.Color == "White")
                .OrderBy(dog => dog.Name);

            Helpers.printColor("6) All white dogs owned by Cristofer, Freddy, Amelia, and Erin: (ASCENDING ORDER)", ConsoleColor.Red);

            foreach (var dog in allWhiteDogs)
            {
                Console.WriteLine($"Name: {dog.Name} - Color: {dog.Color}");
            }
        }
    }
}