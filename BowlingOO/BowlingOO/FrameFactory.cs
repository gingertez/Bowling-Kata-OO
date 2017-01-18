using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOO
{
    public static class FrameFactory
    {
        public static IFrame GetFrame(string frameScore)
        {
            if (frameScore == "X")
            {
                return new StrikeFrame();
            }

            if (frameScore[1] == '/')
            {
                return new SpareFrame(frameScore);
            }

            return new NumericFrame(frameScore);
        }
    }
}
