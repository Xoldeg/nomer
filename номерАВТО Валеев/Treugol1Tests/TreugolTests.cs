using Microsoft.VisualStudio.TestTools.UnitTesting;
using Treugol1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugol1.Tests
{
    [TestClass()]
    public class TreugolTests
    {

        [TestMethod]
        public void phoneA444AA22()
        {
            string number = "A444AA22";
            bool expected = true;

            Treugol c = new Treugol();
            bool actual = c.number(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void phoneA444A22()
        {
            string number = "А444А22";
            bool expected = true;

            Treugol c = new Treugol();
            bool actual = c.number(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void phonea444aa22()
        {
            string number = "a444aa22";
            bool expected = true;

            Treugol c = new Treugol();
            bool actual = c.number(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void phone2aaa2222()
        {
            string number = "2aaa2222";
            bool expected = true;

            Treugol c = new Treugol();
            bool actual = c.number(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void phoneA222AA00()
        {
            string number = "А222АА00";
            bool expected = true;

            Treugol c = new Treugol();
            bool actual = c.number(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void phoneA222AA76()
        {
            string number = "A222AA76";
            bool expected = true;

            Treugol c = new Treugol();
            bool actual = c.number(number);

            Assert.AreEqual(expected, actual);
        }
    }
}