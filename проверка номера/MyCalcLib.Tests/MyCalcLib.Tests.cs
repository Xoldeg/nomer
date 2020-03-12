using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] 
        public void Sum_10and20_30returned()
        {
            //arange
            int x = 10;
            int y = 20;
            int expected = 30;

            //act
            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void car_number()
        {
            //arrange
            string car = "B123CC01";
            bool expected = true;

            //act
            prov c = new prov();
            bool actual = c.car_number(car);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

}
