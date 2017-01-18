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
        [TestCase("12", 3)]
        [TestCase("X", 10)]
        [TestCase("3/", 10)]
        [TestCase("12|34", 10)]
        [TestCase("1/|3-", 16)]
        [TestCase("1/|3/", 23)]
        [TestCase("1/|X", 30)]
        [TestCase("X|12", 16)]
        [TestCase("X|1/", 30)]
        public void TestGameScore(string gameScore, int expectedScore)
        {
            var game = new BowlingGame(gameScore);
            var score = game.Score();
            Assert.That(score, Is.EqualTo(expectedScore));
        }
    }
}
