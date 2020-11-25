using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAwesomeApplication.PresentationLayer.Views;
using MyAwesomeApplication.PresentationLayer.ViewModels;
using MyAwesomeApplication.PresentationLayer.Models;
using MyAwesomeApplication.DataAccessLayer;
using NetArchTest.Rules;

namespace MyAwesomeApplication.TestStep1
{
    [TestClass]
    public class ArchitectureTests
    {
        [TestMethod]
        public void TestViewModelsDoesNotHaveDependencyOnDataAccessLayer()
        {
            // Arrange

            // Act
            bool result = Types.InAssembly(typeof(CakeViewModel).Assembly)
                .That()
                .ResideInNamespace("MyAwesomeApplication.PresentationLayer.ViewModels")
                .ShouldNot()
                .HaveDependencyOn("MyAwesomeApplication.DataAccessLayer")
                .GetResult()
                .IsSuccessful;

            // Assert
            Assert.IsTrue(result);
        }
    }
}
