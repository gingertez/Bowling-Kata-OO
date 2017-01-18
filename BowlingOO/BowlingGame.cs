using System.Collections.Generic;
using System.Linq;

namespace BowlingOO
{
    public class BowlingGame
    {
        List<IFrame> _frames = new List<IFrame>();
        public BowlingGame(string gameScore)
        {
            var frameScores = gameScore.Replace("||", "|").Split('|');
            var idx = 0;
            foreach (var frameScore in frameScores)
            {
                idx++;
                _frames.Add(FrameFactory.GetFrame(frameScore, frameScores.Skip(idx).ToList()));
            }
        }

        public int Score()
        {
            var score = _frames.Select(x => x.Score()).Sum();
            if (_frames.Count == 11)
            {
                score -= _frames[10].Score();
            }
            return score;
        }
    }
}
