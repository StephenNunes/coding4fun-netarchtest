using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAwesomeApplication.PresentationLayer.Views;
using MyAwesomeApplication.PresentationLayer.ViewModels;
using MyAwesomeApplication.PresentationLayer.Models;
using MyAwesomeApplication.DataAccessLayer;
using NetArchTest.Rules;
using System.ComponentModel;

namespace MyAwesomeApplication.TestStep2
{
    [TestClass]
    public class ArchitectureTests
    {
        [TestMethod]
        public void TestViewClassesHasSuffixView()
        {
            // Arrange

            // Act
            bool result = Types.InAssembly(typeof(CakeView).Assembly)
                .That()
                .ResideInNamespace("MyAwesomeApplication.PresentationLayer.Views")
                .And()
                .AreClasses()
                .Should()
                .HaveNameEndingWith("View")
                .GetResult()
                .IsSuccessful;

            // Assert
            Assert.IsTrue(result);
        }

    }
}
