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
    public class BowlingGameTests
    {
        [TestCase("", 0)]
        [TestCase("12", 3)]
        [TestCase("X", 10)]
        [TestCase("3/", 10)]
        public void TestGameScore(string gameScore, int expectedScore)
        {
            var game = new BowlingGame(gameScore);
            var score = game.Score();
            Assert.That(score, Is.EqualTo(expectedScore));
        }
    }
}
