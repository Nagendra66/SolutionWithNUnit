using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using NUnit.Framework;

namespace UnitTestProject2
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            int actual, expected = 30;
            BAL.BalClass obj = new BAL.BalClass();
            actual = obj.AddTwoNumbers(12, 18);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMethod2()
        {
            int actual, expected = 30;
            BAL.BalClass obj = new BAL.BalClass();
            actual = obj.AddTwoNumbers(13, 18);
            NUnit.Framework.Assert.AreEqual(expected, actual);
        }
    }
}
