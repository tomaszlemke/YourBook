﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YourBook.Controllers;


namespace YourBook.Tests
{
    [TestClass]
    public class CustomersControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


     


    }
}
