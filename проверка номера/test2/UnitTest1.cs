using System;
using liib2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
            public void Raz_30and20_10returned()
            {
                //arange
                int x = 30;
                int y = 20;
                int expected = 10;

            //act

            lib2 c = new lib2();
                int actual = c.Raz(x, y);

                //assert
                Assert.AreEqual(expected, actual);
            }
    }
}
