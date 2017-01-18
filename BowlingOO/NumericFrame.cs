using System.Collections.Generic;
using System.Linq;

namespace BowlingOO
{
    public class NumericFrame : IFrame
    {
        private List<int> _rolls = new List<int>();
        public NumericFrame(string frameRolls)
        {
            foreach (var roll in frameRolls)
            {
                _rolls.Add(roll.GetRollValue());
            }
        }

        public int FirstRoll => _rolls[0];

        public int Score()
        {
            return _rolls.Sum();
        }
    }
}
