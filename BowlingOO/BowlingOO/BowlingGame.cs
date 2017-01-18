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
            var frameScores = gameScore.Split('|');
            foreach (var frameScore in frameScores)
            {
                _frames.Add(FrameFactory.GetFrame(frameScore));
            }
        }

        public int Score()
        {
            return _frames.Select(x => x.Score()).Sum();
        }
    }
}
