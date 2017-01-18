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
            var frame = new SpareFrame();
            Assert.That(frame.Score(), Is.EqualTo(10));
        }

        [Test]
        public void TestSpareFrameScoreWithNextRoll()
        {
            var frame = new SpareFrame();
            frame.NextRoll = 4;
            Assert.That(frame.Score(), Is.EqualTo(14));
        }
    }
}
