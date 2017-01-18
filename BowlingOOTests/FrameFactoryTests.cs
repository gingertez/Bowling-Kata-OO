using System;
using System.Collections.Generic;
using BowlingOO;
using NUnit.Framework;

namespace BowlingOOTests
{
    [TestFixture]
    public class FrameFactoryTests
    {
        [TestCase("X", typeof(StrikeFrame))]
        [TestCase("1/", typeof(SpareFrame))]
        [TestCase("12", typeof(NumericFrame))]
        public void TestCorrectFrameTypeCreated(string frameScore, Type expectedType)
        {
            var createdFrame = FrameFactory.GetFrame(frameScore, new List<string>());

            Assert.That(createdFrame, Is.TypeOf(expectedType));
        }
    }
}
