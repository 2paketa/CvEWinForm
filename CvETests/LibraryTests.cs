using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CvEWinform;
using System.IO;

namespace CvETests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void TestMaxNumberOfDocuments()
        {
            //Arrange
            var domains = Domains.getInstance();
            int expected = 7;
            //Act
            int actual = domains.MaxNumberOfDocs;
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
