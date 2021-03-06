﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
//using System.Web;
using System.Web.Mvc;
using BookStore3.Controllers;
using BookStore3.Models;
using Moq;
using System.Data.Entity;
namespace UnitTestProject3
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void InitRep()
        {
            //Arrange
            BookRepository initRep = new BookRepository();
            //Assert
            Assert.IsNotNull(initRep.db);
        }
        [TestMethod]
        public void InitBC()
        {
            //Arrange
            //new BookDbInitializer();
            BookContext initBC = new BookContext();
            //Assert
            Assert.IsNotNull(initBC);
        }
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
        //[TestMethod]
        //public void Index2()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    controller.Index2();

        //    // Assert
        //    //Assert.IsNull(result);
        //}
         
        //[TestMethod]
        //public void IndexViewModelNotNull()
        //{
        //    // Arrange
        //    var mock = new Mock<IRepository>();
        //    mock.Setup(a => a.GetBookList()).Returns(new List<Book>());
        //    HomeController controller = new HomeController(mock.Object);

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;
            
        //    // Assert
        //    Assert.IsNotNull(result.Model);
        //}
        //public void IndexViewModelNotNull3()
        //{
        //    // Arrange
        //    var mock = new Mock<BookContext>();
        //    mock.Setup(a => a.Books).Returns(new DbSet<Book>());
        //    HomeController controller = new HomeController(mock.Object);

        //    // Act
        //    ViewResult result = controller.Index2() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result.Model);
        //}
        //[TestMethod]
        //public void IndexViewBagMessage()
        //{
        //    // Arrange
        //    var mock = new Mock<IRepository>();
        //    mock.Setup(a => a.GetBookList()).Returns(new List<Book>() { new Book() });
        //    HomeController controller = new HomeController(mock.Object);
        //    string expected = "В базе данных 1 объект";

        //    // Act
        //    ViewResult result = controller.Index() as ViewResult;
        //    string actual = result.ViewBag.Message as string;

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
