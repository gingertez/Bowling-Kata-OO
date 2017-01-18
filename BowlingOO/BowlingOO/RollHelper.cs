using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOO
{
    public static class RollHelper
    {
        public const int ASCII_OFFSET = 48;
        public static int GetRollValue(this char roll)
        {
            if (roll == '-')
            {
                return 0;
            }

            if (roll == 'X')
            {
                return 10;
            }

            return roll - ASCII_OFFSET;
        }
    }
}
