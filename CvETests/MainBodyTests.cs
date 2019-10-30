using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CvEWinform;

namespace CvETests
{
    [TestClass]
    public class MainBodyTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var library = Library.getInstance();
            var mainbody = new MainBody();
            //Act
            mainbody.getDocsOfDomain("Legal");

            //Assert

        }
    }
}
