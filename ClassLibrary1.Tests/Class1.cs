using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BAL;

namespace ClassLibrary1.Tests
{
    public class Class1
    {

    }

    [TestFixture]
    public class Add2Numbers
    {
        [Test]
        public void CanAdd2Numbers()
        {
            BalClass sut = new BalClass();
            int res = sut.AddTwoNumbers(6, 7);
            Assert.That(res, Is.EqualTo(13));
        }
    }
}
