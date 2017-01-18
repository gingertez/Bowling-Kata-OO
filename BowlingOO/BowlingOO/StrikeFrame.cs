using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOO
{
    public class StrikeFrame : IFrame
    {
        private List<int> _nextRolls = new List<int>();

        public StrikeFrame(string frame1Score, string frame2Score)
        {
            var frame1 = FrameFactory.GetFrame(frame1Score);
            _nextRolls.Add(frame1.Score());

            if (frame1 is StrikeFrame)
            {
                var frame2 = FrameFactory.GetFrame(frame2Score);
                    
                if (frame2 != null)
                {
                    _nextRolls.Add(frame2.FirstRoll);
                }
            }
        }

        public int FirstRoll => 10;

        public int Score()
        {
            return 10 + _nextRolls.Sum();
        }
    }
}
