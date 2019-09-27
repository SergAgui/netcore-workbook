using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CP1;
using CP1.Controllers;
using CP1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CP1Tests
{
    [TestClass]
    public class CPContollerTests
    {
        //Home Controller should return the Index View
        [TestMethod]
        public void HomeContollerReturnsIndex()
        {
            //Arrange
            var homeController = new HomeController();

            //Act
            var result = homeController.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void CustomerControllerAddsCustomer()
        {
            //Arrange
            var mockRepository = new Mock<IApptRepository>();
            var mockCustomer = new Mock<Customer>();
            var model = new Customer()
            {
                Id = 1,
                FirstName = "Sergio",
                LastName = "Aguilar"
            };

            mockRepository.Setup(x => x.AddCust(It.Is<Customer>(c => c.Id == model.Id
                                                                && c.FirstName == model.FirstName
                                                                && c.LastName == model.LastName)));

            /*public IActionResult Add(Customer customer)
            {
                if (ModelState.IsValid)
                {
                    repository.AddCust(customer);
                    return RedirectToAction(nameof(Index));
                }
                return View(customer);
            }*/


        //Act

        //Assert

        }
    }
}
