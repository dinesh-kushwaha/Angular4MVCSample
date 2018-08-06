using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using NG.mvc.Web.UI.Controllers;

namespace NG.mvc.Web.UI.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert//"Home Page
            Assert.AreEqual("Home page.", result.ViewBag.Title);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.About() as ViewResult;
            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Title);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Contact() as ViewResult;
            // Assert
            Assert.AreEqual("Your contact page.", result.ViewBag.Title);
        }
    }
}
