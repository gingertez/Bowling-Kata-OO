using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOO
{
    public class Frame
    {
        private List<string> _rolls = new List<string>();
        public Frame(string frameRolls)
        {
            foreach (var roll in frameRolls)
            {
                _rolls.Add(roll.ToString());
            }
        }

        public int Score()
        {
            var score = 0;
            foreach (var roll in _rolls)
            {
                score += int.Parse(roll);
            }
            return score;
        }
    }
}
