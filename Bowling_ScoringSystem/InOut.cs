using System;

namespace Bowling_ScoringSystem
{
    public class InOut
    {
        public static Game PrepForGame(int bowlerCount)
        {
            Game newGame = new Game();

            for (int i = 0; i < bowlerCount; i++)
            {
                string name = Console.ReadLine();

                var bowler = new Bowler(name);
                newGame.Add(bowler);
            }

            return newGame;
        }
    }

    
}
