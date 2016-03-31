using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary2
{
    [TestFixture]
    public class ControllerTest
    {
        [TestCase(1, 2)]
        [TestCase(2, 4)]
        [TestCase(3, 6)]
        public void SwapTest(int expectedA, int a)
        {
            Controller con = new Controller();
            int val= con.TestMan(expectedA);

            Assert.AreEqual(a, val);
        }
    }
}
