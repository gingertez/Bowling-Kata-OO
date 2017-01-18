using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOO
{
    public class BonusBallsFrame : IFrame
    {
        private List<int> _rolls = new List<int>();
        public BonusBallsFrame(string frameRolls)
        {
            foreach (var roll in frameRolls)
            {
                _rolls.Add(RollValue(roll));
            }
        }

        public int FirstRoll => _rolls[0];

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

            if (roll == 'X')
            {
                return 10;
            }

            return roll - 48;
        }
    }
}
