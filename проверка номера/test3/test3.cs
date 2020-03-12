using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test3
{
    [TestClass]
    public class test3
    {
        [TestMethod]
        public void rav()
        {
            //arange
            int x = 10;
            int y = 10;
            int expected = 10;

            //act

            lib3 c = new lib3();
            int actual = c.rav(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
