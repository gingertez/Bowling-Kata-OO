using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BowlingOO
{
    public class BowlingGame
    {
        List<IFrame> _frames = new List<IFrame>();
        public BowlingGame(string gameScore)
        {
            if (gameScore == "X")
            {
                _frames.Add(new StrikeFrame());
            }
            else if (gameScore[1] == '/')
            {
                _frames.Add(new SpareFrame());
            }
            else
            {
                _frames.Add(new NumericFrame(gameScore));
            }
        }

        public int Score()
        {
            return _frames.Select(x => x.Score()).Sum();
        }
    }
}
