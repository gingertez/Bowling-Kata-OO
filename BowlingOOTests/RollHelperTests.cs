using BowlingOO;
using NUnit.Framework;
using System;

namespace BowlingOOTests
{
    [TestFixture]
    public class RollHelperTests
    {
        [TestCase('1', 1)]
        [TestCase('-', 0)]
        [TestCase('X', 10)]
        public void TestRollValue(char roll, int expectedValue)
        {
            Assert.That(roll.GetRollValue(), Is.EqualTo(expectedValue));
        }

        [Test]
        public void TestRollValueThrowsErrorOnInvalidCharacter()
        {
            Assert.Throws<InvalidOperationException>(() => 'A'.GetRollValue());
        }
    }
}
