using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOO
{
    public class NumericFrame : IFrame
    {
        private List<int> _rolls = new List<int>();
        public NumericFrame(string frameRolls)
        {
            foreach (var roll in frameRolls)
            {
                _rolls.Add(RollValue(roll));
            }
        }

        public int Score()
        {
            return _rolls.Sum();
        }

        private int RollValue(char roll)
        {
            if (roll == '-')
            {
                return 0;
            }

            return roll - 48;
        }
    }
}
