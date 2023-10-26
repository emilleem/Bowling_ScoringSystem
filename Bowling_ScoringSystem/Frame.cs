using System.Collections.Generic;

namespace Bowling_ScoringSystem
{
    public class Frame
    {
        public int FirstRoll { get; set; }
        public int SecondRoll { get; set; }
        public int NthInGame { get; set; }
        public bool IsStrike
        {
            get
            {
                if (this.FirstRoll == 10)
                    return true;
                return false;
            }
        }

        public bool IsSpare
        {
            get
            {
                if (this.FirstRoll + this.SecondRoll == 10)
                    return true;
                return false;
            }
        }

        public bool IsScorePending()
        {
            if (this.IsSpare || this.IsStrike) 
                return true;
            return false;
        }

        public bool IsComplete()
        {
            if (this.NthInGame == 10 && (this.IsStrike || this.IsSpare))
                return true;
            else if (this.FirstRoll != 0 && this.SecondRoll != 0)
                return true;
            return true;
        }

        public int CalculateFrameScore()
        {
            return 0;
        }
    }

    
}
