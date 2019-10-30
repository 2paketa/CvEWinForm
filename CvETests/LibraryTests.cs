using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CvEWinform;

namespace CvETests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void TestMaxNumberOfDocuments()
        {
            //Arrange
            var library = Library.getInstance();
            int expected = 7;
            //Act
            int actual = library.MaxNumberOfDocs;
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
