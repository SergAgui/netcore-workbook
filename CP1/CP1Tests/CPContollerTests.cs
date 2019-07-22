using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP1;
using CP1.Controllers;
using CP1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CP1Tests
{
    [TestClass]
    public class CPContollerTests
    {
        [TestMethod]
        public void HomeContollerIndexTest()
        {
            //Arrange
            var homeController = new HomeController();

            //Act
            var result = homeController.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
