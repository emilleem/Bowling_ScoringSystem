namespace Bowling_ScoringSystem
{
    public class Frame
    {
        public int FirstThrow { get; set; }
        public int SecondThrow { get; set; }
        public int TotalScore
        {
            get { return this.FirstThrow + this.SecondThrow; }
        }

        public Frame()
        {
        }

        public Frame(int firstThrow, int secondThrow)
        {
            FirstThrow = firstThrow;
            SecondThrow = secondThrow;
        }
    }

    
}
