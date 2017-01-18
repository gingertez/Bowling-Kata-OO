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
    }
}
