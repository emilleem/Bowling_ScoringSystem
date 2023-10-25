using System;

namespace Bowling_ScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people are playing? ");
            int bowlerCount = int.Parse(Console.ReadLine());    
            Game currentGame = InOut.PrepForGame(bowlerCount);
        }
    }

    
}
