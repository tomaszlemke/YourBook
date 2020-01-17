using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YourBook.Models;

namespace Tests.Models
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void Min18YearsIfAMember_WithValidAge()
        {
            //Arrange
            var age = 2000 - 01 - 01;
            Min18YearsIfAMember test1 = new Min18YearsIfAMember();

            // Act
            bool result = test1.IsValid(age);

            //Assert
           // Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void 

    }
}
