using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAwesomeApplication.PresentationLayer.Views;
using MyAwesomeApplication.PresentationLayer.ViewModels;
using MyAwesomeApplication.PresentationLayer.Models;
using MyAwesomeApplication.DataAccessLayer;
using NetArchTest.Rules;
using System.ComponentModel;

namespace MyAwesomeApplication.TestStep4
{
    [TestClass]
    public class ArchitectureTests
    {
        [TestMethod]
        public void TestRepositoryClassesEndsWithRepository()
        {
            // Arrange

            // Act
            bool result = Types.InNamespace("MyAwesomeApplication.DataAccessLayer")
                .That()
                .AreClasses()
                .Should()
                .HaveNameEndingWith("Repository")
                .GetResult()
                .IsSuccessful;

            // Assert
            Assert.IsTrue(result);
        }
    }
}
