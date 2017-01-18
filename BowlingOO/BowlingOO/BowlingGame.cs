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

            AddNextRollToSpares();
        }

        public int Score()
        {
            return _frames.Select(x => x.Score()).Sum();
        }

        private void AddNextRollToSpares()
        {
            var idx = 0;
            foreach (var frame in _frames)
            {
                if (frame is SpareFrame && idx != _frames.Count -1)
                {
                    (frame as SpareFrame).NextRoll = (_frames[idx + 1] as NumericFrame).FirstRoll;
                }
                idx++;
            }
        }
    }
}
