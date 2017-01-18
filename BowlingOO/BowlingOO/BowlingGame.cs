using System;
using System.Collections.Generic;
using System.IO;
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
            var idx = 0;
            foreach (var frameScore in frameScores)
            {
                idx++;
                _frames.Add(FrameFactory.GetFrame(frameScore, frameScores.Skip(idx).ToList()));
            }
        }

        public int Score()
        {
            return _frames.Select(x => x.Score()).Sum();
        }
    }
}
