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
            _frames.Add(FrameFactory.GetFrame(gameScore));
        }

        public int Score()
        {
            return _frames.Select(x => x.Score()).Sum();
        }
    }
}
