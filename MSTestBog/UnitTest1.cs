using System;
using BogUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestBog
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBogForfatter()
        {
            Bog b1 = new Bog();
            b1.Forfatter = "Saad";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBogSideTal()
        {
            Bog b1 = new Bog();
            b1.Sidetal = 3;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBogISBN()
        {
            Bog b1 = new Bog();
            b1.Isbn13 = "12345678910225";
        }

    }
}
