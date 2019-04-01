using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WorkingWithVisualStudio.Controllers;
using WorkingWithVisualStudio.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkingWithVisualStudio.Test
{
    [TestClass]
    class ProductTest
    {
        [TestMethod]
        public void CanChangeProductName()
        {
            // Arrange
            var p = new Product { Name = "Test", Price = 100M };
            // Act
            p.Name = "New Name";
            //Assert
            Assert.AreEqual("New Name", p.Name);
        }

        [TestMethod]
        public void CanChangeProductPrice()
        {
            // Arrange
            var p = new Product { Name = "Test", Price = 100M };
            // Act
            p.Price = 200M;
            //Assert
            Assert.AreEqual(100M, p.Price);
        }
    }
}