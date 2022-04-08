using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise03.Methods
{
    internal static class Application
    {
        public static void GameApp()
        {
            int userPoints = 0;
            int systemPoints = 0;
            int ties = 0;

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            string play = string.Empty;

            while (play != "exit")
            {
                Console.WriteLine("Enter (play - To start playing)  (stats - To see your score)  (exit - To exit the game) ");

                play = Console.ReadLine().ToLower();

                switch (play)
                {
                    case "exit":
                        break;

                    case "play":

                        Console.WriteLine("Please enter a number from the choices below!");

                        Console.WriteLine("Chose 1 for Rock");
                        Console.WriteLine("Chose 2 for Paper");
                        Console.WriteLine("Chose 3 for Scissors");

                        string playerChoice = Console.ReadLine();

                        Random random = new Random();
                        int systemChoice = random.Next(1, 3);

                        switch (systemChoice)
                        {
                            case 1:
                                if (playerChoice == "1")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;

                                    Console.WriteLine("You chose Rock");
                                    Console.WriteLine("The system chose Rock");
                                    Console.WriteLine("It is a tie.");
                                    ties++;

                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (playerChoice == "2")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine("You chose Paper");
                                    Console.WriteLine("The system chose Rock");
                                    Console.WriteLine("You win");
                                    userPoints++;

                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (playerChoice == "3")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;

                                    Console.WriteLine("You chose Scissors");
                                    Console.WriteLine("The system chose Rock");
                                    Console.WriteLine("The system wins");
                                    systemPoints++;

                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                                break;

                            case 2:

                                if (playerChoice == "1")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;

                                    Console.WriteLine("You chose Rock");
                                    Console.WriteLine("The system chose Paper");
                                    Console.WriteLine("The system wins.");
                                    systemPoints++;

                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (playerChoice == "2")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;

                                    Console.WriteLine("You chose Paper");
                                    Console.WriteLine("The system chose Paper");
                                    Console.WriteLine("It is a tie");
                                    ties++;

                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (playerChoice == "3")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine("You chose Scissors");
                                    Console.WriteLine("The system chose Paper");
                                    Console.WriteLine("You win");
                                    userPoints++;

                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                                break;

                            case 3:
                                if (playerChoice == "1")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine("You chose Rock");
                                    Console.WriteLine("The system chose Scissors");
                                    Console.WriteLine("You win");
                                    userPoints++;

                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (playerChoice == "2")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;

                                    Console.WriteLine("You chose Paper");
                                    Console.WriteLine("The system chose Scissors");
                                    Console.WriteLine("The system wins");
                                    systemPoints++;

                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (playerChoice == "3")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;

                                    Console.WriteLine("You chose Scissors");
                                    Console.WriteLine("The system chose Scissors");
                                    Console.WriteLine("It is a tie");
                                    ties++;

                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                break;
                        }

                        break;

                    case "stats":
                        Console.WriteLine($"You have {userPoints} points - Computer has {systemPoints} points, and {ties} game are ties");
                        PrintResult.Result(userPoints, systemPoints, ties);
                        break;
                }
            }
        }
    }
}