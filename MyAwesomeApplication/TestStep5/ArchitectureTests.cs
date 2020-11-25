using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAwesomeApplication.PresentationLayer.Views;
using MyAwesomeApplication.PresentationLayer.ViewModels;
using MyAwesomeApplication.PresentationLayer.Models;
using MyAwesomeApplication.DataAccessLayer;
using NetArchTest.Rules;
using System.ComponentModel;

namespace MyAwesomeApplication.TestStep5
{
    [TestClass]
    public class ArchitectureTests
    {
        [TestMethod]
        public void TestFactoryClassGotAtLeastOneCreateMethod()
        {
            // Arrange
            var areFactoryClassGotAtLeastOneCreateMethodRule = new AreFactoryClassGotAtLeastOneCreateMethodRule();

            // Act
            bool result = Types.InNamespace("MyAwesomeApplication.BusinessLayer")
                .That()
                .AreClasses()
                .Should()
                .MeetCustomRule(areFactoryClassGotAtLeastOneCreateMethodRule)
                .GetResult()
                .IsSuccessful;

            // Assert
            Assert.IsTrue(result);
        }
    }
}
