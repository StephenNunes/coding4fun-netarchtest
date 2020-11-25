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
        public void TestSometing()
        {
            // Arrange

            // Act
            bool result = Types.InNamespace()
                .That()
                // Predicates
                //.Should() or .ShouldNot()
                //Conditions
                .GetResult()
                .IsSuccessful;

            // Assert
            Assert.IsTrue(result);
        }
    }
}
