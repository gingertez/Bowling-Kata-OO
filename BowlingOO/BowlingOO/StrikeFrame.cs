﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOO
{
    public class StrikeFrame : IFrame
    {
        private List<int> _nextRolls = new List<int>();

        public void AddNextRoll(int nextRoll)
        {
            
        }

        public int Score()
        {
            return 10;
        }
    }
}
