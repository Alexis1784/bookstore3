using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
//using System.Web;
using System.Web.Mvc;
using BookStore3.Controllers;
namespace UnitTestProject3
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void About()
        { 
            // Arrange
            HomeController controller = new HomeController();

            // Act 
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message); 

        }
        [TestMethod]
        public void IndexViewModelNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index2() as ViewResult;
            
            // Assert
            Assert.IsNotNull(result.Model);
        }
    }
}
