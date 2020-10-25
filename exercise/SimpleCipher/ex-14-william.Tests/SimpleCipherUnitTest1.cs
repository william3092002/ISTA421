using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ex_14_william.Tests
{
    [TestClass]
    public class SimpleCipherUnitTest1
    {
        Cipher cipher = new Cipher();
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            
            string result;

            // Act
            result = cipher.SimpleCipher('C', "We attack at dawn");

            // Assert
            Assert.AreEqual("ZHDWWDFNDWGDZQ", result);

        }
        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string result;

            // Act
            result = cipher.LessSimpleCipher("CAT", "We attack at dawn");

            // Assert
            Assert.AreEqual("ZFUWUUFLUWEUZO", result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            string result;

            // Act
            result = cipher.StillLessSimpleCipher("CAT", "We attack at dawn");

            // Assert
            Assert.AreEqual("ZFUQYBWEBWOBQR", result);
        }

    }

}
