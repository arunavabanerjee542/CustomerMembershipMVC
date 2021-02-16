using EntityFrameworkMVC.Controllers;
using EntityFrameworkMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestCustomerMembershipApp
{
   public class HomeControllerTest
    {
        [Fact]
        public void Index_WhenCalled_GetsCustomerDetailsFromDb()
        {
            //Arrange 
            var mock = new Mock<ICustomerRepository>();
            mock.Setup(m => m.GetAllCustomerDetails()).Returns(new List<MemberShip>()
            {
                new MemberShip(){MemberShipId=1,DurationInMonths=10,MembershipType="Fake"}
            });
            var home = new HomeController(mock.Object);

            //Act
            var model =(home.Index() as ViewResult).ViewData.Model as List<MemberShip>;

            //Assert
            Assert.Equal(10, model[0].DurationInMonths);

        }

        [Fact]
        public void Details_GetDetailsById_ReturnsCustomer()
        {
            //Arrange
            var mock = new Mock<ICustomerRepository>();
            mock.Setup(m => m.GetCustomerById(1)).Returns(
                new Customer() { CustomerId=1,Name="Arunava"}
                );
            var home = new HomeController(mock.Object);

            //Act
            var model = (home.Details(1) as ViewResult).ViewData.Model as Customer;

            //Assert
            Assert.Equal("Arunava", model.Name);

        }

    }
}
