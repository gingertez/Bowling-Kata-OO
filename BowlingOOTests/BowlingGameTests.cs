﻿using System;
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
        [TestCase("X|X|1-", 33)]
        [TestCase("X|X|X|1-", 63)]
        [TestCase("1-|1-|1-|1-|1-|1-|1-|1-|1-|1-||", 10)]
        [TestCase("5/|5/|5/|5/|5/|5/|5/|5/|5/|5/||5", 150)]
        [TestCase("X|7/|9-|X|-8|8/|-6|X|X|X||81", 167)]
        [TestCase("X|X|X|X|X|X|X|X|X|X||XX", 300)]
        [TestCase("X|7/|9-|X|-8|8/|-6|X|X|X||8/", 168)]
        public void TestGameScore(string gameScore, int expectedScore)
        {
            var game = new BowlingGame(gameScore);
            var score = game.Score();
            Assert.That(score, Is.EqualTo(expectedScore));
        }
    }
}
