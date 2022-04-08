using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise03.Methods
{
    public static class PrintResult
    {
        public static void Result(int playerWins, int systemWins, int ties)
        {
            int gamesPlayed = playerWins + systemWins + ties;

            double winningPercentage = ((playerWins + (0.5 * ties)) / gamesPlayed) * 100;

            Console.WriteLine($"Your Winning Percentage is {winningPercentage}%");
        }
    }
}