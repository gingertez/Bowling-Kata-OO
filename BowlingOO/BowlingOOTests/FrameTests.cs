using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingOO;
using NUnit.Framework;

namespace BowlingOOTests
{
    [TestFixture]
    public class FrameTests
    {
        [TestCase("12", 3)]
        [TestCase("81", 9)]
        public void TestFrameScoreWhenFrameIsOnlyNumbers(string frameScore, int expectedScore)
        {
            var frame = new NumericFrame(frameScore);
            Assert.That(frame.Score(), Is.EqualTo(expectedScore));
        }

        [TestCase("--", 0)]
        [TestCase("-2", 2)]
        [TestCase("3-", 3)]
        public void TestFrameScoreWhenThereAreGutterBalls(string frameScore, int expectedScore)
        {
            var frame = new NumericFrame(frameScore);
            Assert.That(frame.Score(), Is.EqualTo(expectedScore));
        }

        [Test]
        public void TestSpareFrameScore()
        {
            var frame = new SpareFrame("12", null);
            Assert.That(frame.Score(), Is.EqualTo(10));
        }

        [Test]
        public void TestSpareFrameScoreWithNextRoll()
        {
            var frame = new SpareFrame("12", "43");
            Assert.That(frame.Score(), Is.EqualTo(14));
        }

        [Test]
        public void TestSpareFrameFirstToll()
        {
            var frame = new SpareFrame("12", null);
            Assert.That(frame.FirstRoll, Is.EqualTo(1));
        }

        [Test]
        public void TestStrikeFrameScore()
        {
            var frame = new StrikeFrame(null, null);
            Assert.That(frame.Score(), Is.EqualTo(10));
        }

        [Test]
        public void TestStrikeFrameScoreWithOneAdditionalRoll()
        {
            var frame = new StrikeFrame("4-", null);
            Assert.That(frame.Score(), Is.EqualTo(14));
        }

        [Test]
        public void TestStrikeFrameScoreWithTwoAdditionalRoll()
        {
            var frame = new StrikeFrame("45", null);
            Assert.That(frame.Score(), Is.EqualTo(19));
        }

        [Test]
        public void TestBonusBallsFrameScoreWithNumericBalls()
        {
            var frame = new BonusBallsFrame("12");
            Assert.That(frame.Score(), Is.EqualTo(3));
        }

        [Test]
        public void TestBonusBallsFrameScoreWithStrike()
        {
            var frame = new BonusBallsFrame("X2");
            Assert.That(frame.Score(), Is.EqualTo(12));
        }

        [Test]
        public void TestBonusBallsFrameScoreWith2Strikes()
        {
            var frame = new BonusBallsFrame("XX");
            Assert.That(frame.Score(), Is.EqualTo(20));
        }

        [TestCase("12", 1)]
        [TestCase("X2", 10)]
        public void TestConusBallsFrameFirstRoll(string frameScore, int expectedRollValue)
        {
            var frame = new BonusBallsFrame(frameScore);
            Assert.That(frame.FirstRoll, Is.EqualTo(expectedRollValue));
        }
    }
}
