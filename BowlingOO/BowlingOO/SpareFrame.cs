using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOO
{
    public class SpareFrame : IFrame
    {
        public SpareFrame(string frameScore)
        {
            FirstRoll = RollValue(frameScore[0]);
        }

        public int FirstRoll { get; private set; }

        public int NextRoll { private get; set; }

        public int Score()
        {
            return 10 + NextRoll;
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
