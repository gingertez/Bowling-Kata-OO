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
            foreach (var frameScore in frameScores)
            {
                _frames.Add(FrameFactory.GetFrame(frameScore));
            }

            AddNextRollToSpares();
            AddNextTwoRollsToStrikes();
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
                    var nextFrame = _frames[idx + 1];
                    (frame as SpareFrame).NextRoll = nextFrame.FirstRoll;
                }
                idx++;
            }
        }

        private void AddNextTwoRollsToStrikes()
        {
            var idx = 0;
            foreach (var frame in _frames)
            {
                if (frame is StrikeFrame && idx != _frames.Count - 1)
                {
                    var nextFrame = _frames[idx + 1];
                    (frame as StrikeFrame).AddNextRoll(nextFrame.Score());
                    if (nextFrame is StrikeFrame && idx != _frames.Count - 2)
                    {
                        var nextFrame2 = _frames[idx + 2];
                        (frame as StrikeFrame).AddNextRoll(nextFrame2.FirstRoll);
                    }
                }
                idx++;
            }
        }
    }
}
