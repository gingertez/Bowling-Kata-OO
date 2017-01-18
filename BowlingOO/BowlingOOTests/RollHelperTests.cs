using BowlingOO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingOOTests
{
    [TestFixture]
    public class RollHelperTests
    {
        [TestCase('1', 1)]
        [TestCase('-', 0)]
        public void TestRollValue(char roll, int expectedValue)
        {
            Assert.That(roll.GetRollValue(), Is.EqualTo(expectedValue));
        }
    }
}
