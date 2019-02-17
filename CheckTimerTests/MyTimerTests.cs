using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CheckTimerLib;

namespace CheckTimerTests
{
    [TestFixture]
    public class MyTimerTests
    {
        [TestCase(30000)] // 30 seconds
        [TestCase(1500000)] // 25 minutes
        public void TimerCouldBeSetUp(int milliseconds)
        {
            MyTimer timer = new MyTimer(milliseconds);
            Assert.That(timer.Lifetime, Is.EqualTo(milliseconds));
        }
    }
}
