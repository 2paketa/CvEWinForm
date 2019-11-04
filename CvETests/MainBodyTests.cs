using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CvEWinform;
using System.IO;

namespace CvETests
{
    [TestClass]
    public class MainBodyTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var mainbody = new MainBody();
            string[] input = { "Legal", "Medical" };
            var domains = Domains.getInstance();
            int expect = 7;
            //Act
            mainbody.Get(input);
            int actual = domains.MaxNumberOfDocs;
            //Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
