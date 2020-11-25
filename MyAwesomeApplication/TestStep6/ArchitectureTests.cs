using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAwesomeApplication.PresentationLayer.Views;
using MyAwesomeApplication.PresentationLayer.ViewModels;
using MyAwesomeApplication.PresentationLayer.Models;
using MyAwesomeApplication.DataAccessLayer;
using NetArchTest.Rules;
using NetArchTest.Rules.Policies;
using System.ComponentModel;

namespace MyAwesomeApplication.TestStep6
{
    [TestClass]
    public class ArchitectureTests
    {
        [TestMethod]
        public void TestPolicyPresentationLayer()
        {
            // Arrange
            var policy = Policy.Define("Presentation Policy", "Policy for Presentation layer")
                .For(Types.InAssembly(typeof(CakeView).Assembly))
                .Add(t =>
                    t.That()
                    .ResideInNamespace("MyAwesomeApplication.PresentationLayer.Views")
                    .And()
                    .AreClasses()
                    .Should()
                    .HaveNameEndingWith("View"),
                    "Control classes in Views namespace", "Classes in Views namespace ends with View suffix")
                .Add(t =>
                    t.That()
                    .ResideInNamespace("MyAwesomeApplication.PresentationLayer.ViewModels")
                    .Should()
                    .ImplementInterface(typeof(INotifyPropertyChanged)),
                    "Control classes in ViewModels namespace", "Classes in ViewModels namespace has to implements INotifyPropertyChanged"
                );

            // Act
            PolicyResults results = policy.Evaluate();

            // Assert
            Assert.IsFalse(results.HasViolations);
        }
    }
}
