using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOO
{
    public class SpareFrame : IFrame
    {
        private int? _nextRoll = 0;
        public SpareFrame(string frameScore, string nextFrameScore)
        {
            FirstRoll = RollValue(frameScore[0]);
            _nextRoll = FrameFactory.GetFrame(nextFrameScore, new List<string>())?.FirstRoll;
        }

        public int FirstRoll { get; private set; }


        public int Score()
        {
            return 10 + (_nextRoll ?? 0);
        }

        private int RollValue(char roll)
        {
            if (roll == '-')
            {
                return 0;
            }

            return roll - 48;
        }

    }
}
