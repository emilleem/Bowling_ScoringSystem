using System.Collections.Generic;

namespace Bowling_ScoringSystem
{
    public class Game
    {
        private Frame[] _Frames;
        public Game()
        {
            this._Frames = new Frame[10];
        }
        public bool IsOver
        {
            get
            {
                if (this._Frames[9].IsComplete())
                    return true;
                return false;
            }
        }


        public void Roll(int pinsKnockedDown)
        {
            if (this.IsOver)
                return;
        }

        public int CalculateScore()
        {
            return 350;
        }

        
        
        public void GetGameState()
        {

        }

        
    }

    
}
