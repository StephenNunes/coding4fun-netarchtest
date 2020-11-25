using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAwesomeApplication.PresentationLayer.Views;
using MyAwesomeApplication.PresentationLayer.ViewModels;
using MyAwesomeApplication.PresentationLayer.Models;
using MyAwesomeApplication.DataAccessLayer;
using NetArchTest.Rules;
using System.ComponentModel;

namespace MyAwesomeApplication.TestStep3
{
    [TestClass]
    public class ArchitectureTests
    {
        [TestMethod]
        public void TestViewModelClassesImplementsINotifyPropertyChange()
        {
            // Arrange

            // Act
            bool result = Types.InAssembly(typeof(CakeViewModel).Assembly)
                .That()
                .ResideInNamespace("MyAwesomeApplication.PresentationLayer.ViewModels")
                .Should()
                .ImplementInterface(typeof(INotifyPropertyChanged))
                .GetResult()
                .IsSuccessful;

            // Assert
            Assert.IsTrue(result);
        }
    }
}
