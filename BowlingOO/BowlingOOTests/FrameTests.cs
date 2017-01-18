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
        [Test]
        public void TestFrameScoreWhenFrameIsOnlyNumbers()
        {
            var frame = new Frame("12");
            Assert.That(frame.Score(), Is.EqualTo(3));
        }
    }
}
