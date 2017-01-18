using System.Collections.Generic;

namespace BowlingOO
{
    public class SpareFrame : IFrame
    {
        private int? _nextRoll = 0;
        public SpareFrame(string frameScore, string nextFrameScore)
        {
            FirstRoll = frameScore[0].GetRollValue();
            _nextRoll = FrameFactory.GetFrame(nextFrameScore, new List<string>()).FirstRoll;
        }

        public int FirstRoll { get; private set; }
        
        public int Score()
        {
            return 10 + (_nextRoll ?? 0);
        }
    }
}
