using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanConverter;

namespace RomanConverterUnitTest
{
    [TestClass]
    public class DecimalToRomanTest
    {
        [TestMethod]
        public void ShouldReturnI()
        {
            Assert.AreEqual("I", Roman.ConvertToRoman(1));
        }

        [TestMethod]
        public void ShouldReturnII()
        {
            Assert.AreEqual("II", Roman.ConvertToRoman(2));
        }

        [TestMethod]
        public void ShouldReturnIII()
        {
            Assert.AreEqual("III", Roman.ConvertToRoman(3));
        }


        [TestMethod]
        public void ShouldNotReturnIIII()
        {
            Assert.AreNotEqual("IIII", Roman.ConvertToRoman(4));
        }


        [TestMethod]
        public void ShouldReturnIV()
        {
            Assert.AreEqual("IV", Roman.ConvertToRoman(4));
        }

        [TestMethod]
        public void ShouldReturnV()
        {
            Assert.AreEqual("V", Roman.ConvertToRoman(5));
        }

        [TestMethod]
        public void ShouldNotReturnVIIII()
        {
            Assert.AreNotEqual("VIIII", Roman.ConvertToRoman(9));
        }

        [TestMethod]
        public void ShouldReturnIX()
        {
            Assert.AreEqual("IX", Roman.ConvertToRoman(9));
        }

        [TestMethod]
        public void ShouldReturnX()
        {
            Assert.AreEqual("X", Roman.ConvertToRoman(10));
        }

        [TestMethod]
        public void ShouldReturnXLIX()
        {
            Assert.AreEqual("XLIX", Roman.ConvertToRoman(49));
        }

        [TestMethod]
        public void ShouldReturnL()
        {
            Assert.AreEqual("L", Roman.ConvertToRoman(50));
        }

        [TestMethod]
        public void ShouldReturnLI()
        {
            Assert.AreEqual("LI", Roman.ConvertToRoman(51));
        }

        [TestMethod]
        public void ShouldReturnLIII()
        {
            Assert.AreEqual("LIII", Roman.ConvertToRoman(53));
        }

        [TestMethod]
        public void ShouldNotReturnLIIII()
        {
            Assert.AreNotEqual("LIIII", Roman.ConvertToRoman(54));
        }

        [TestMethod]
        public void ShouldReturnMXXIV()
        {
            Assert.AreEqual("MXXIV", Roman.ConvertToRoman(1024));
        }

        [TestMethod]
        public void ShouldNotReturnMXXIIII()
        {
            Assert.AreNotEqual("MXXIIII", Roman.ConvertToRoman(1024));
        }


        [TestMethod]
        public void ShouldReturnLIV()
        {
            Assert.AreEqual("LIV", Roman.ConvertToRoman(54));
        }


        [TestMethod]
        public void ShouldReturnC()
        {
            Assert.AreEqual("C", Roman.ConvertToRoman(100));
        }

        [TestMethod]
        public void ShouldReturnCC()
        {
            Assert.AreEqual("CC", Roman.ConvertToRoman(200));
        }

        [TestMethod]
        public void ShouldReturnCCC()
        {
            Assert.AreEqual("CCC", Roman.ConvertToRoman(300));
        }

        [TestMethod]
        public void ShouldReturnCD()
        {
            Assert.AreEqual("CD", Roman.ConvertToRoman(400));
        }

        [TestMethod]
        public void ShouldReturnD()
        {
            Assert.AreEqual("D", Roman.ConvertToRoman(500));
        }

        [TestMethod]
        public void ShouldReturnDC()
        {
            Assert.AreEqual("DC", Roman.ConvertToRoman(600));
        }

        [TestMethod]
        public void ShouldReturnDCC()
        {
            Assert.AreEqual("DCC", Roman.ConvertToRoman(700));
        }

        [TestMethod]
        public void ShouldReturnDCCC()
        {
            Assert.AreEqual("DCCC", Roman.ConvertToRoman(800));
        }

        [TestMethod]
        public void ShouldReturnCM()
        {
            Assert.AreEqual("CM", Roman.ConvertToRoman(900));
        }

        [TestMethod]
        public void ShouldReturnM()
        {
            Assert.AreEqual("M", Roman.ConvertToRoman(1000));
        }

        [TestMethod]
        public void Input0ShouldReturnEmptyString()
        {
            Assert.AreEqual("", Roman.ConvertToRoman(0));
        }

        [TestMethod]
        public void InputShouldReturnEmptyString()
        {
            Assert.AreEqual("", Roman.ConvertToRoman(-50));
        }
    }
}
