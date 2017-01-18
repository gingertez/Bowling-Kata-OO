﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOO
{
    public class SpareFrame : IFrame
    {
        public int NextRoll { private get; set; }
        public int Score()
        {
            return 10 + NextRoll;
        }
    }
}
