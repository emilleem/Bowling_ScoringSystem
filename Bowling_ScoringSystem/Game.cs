using System.Collections.Generic;

namespace Bowling_ScoringSystem
{
    public class Game
    {
        private List<Bowler> _bowlers = new List<Bowler>();

        public Game()
        {
        }

        public Game(List<Bowler> bowlers)
        {
            this._bowlers.AddRange(bowlers);
        }

        public void Add(Bowler bowler) 
        { 
            this._bowlers.Add(bowler);
        }
    }

    
}
