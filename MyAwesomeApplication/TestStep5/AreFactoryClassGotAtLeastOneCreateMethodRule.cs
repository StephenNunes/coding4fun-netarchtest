using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using NetArchTest.Rules;
using NetArchTest.Rules.Extensions;
using Mono.Cecil;
using System.Linq;

namespace MyAwesomeApplication.TestStep5
{
    public class AreFactoryClassGotAtLeastOneCreateMethodRule : ICustomRule
    {
        public bool MeetsRule(TypeDefinition type)
        {
            return AreFactoryClassGotAtLeastOneCreateMethod(type);
        }

        protected virtual bool AreFactoryClassGotAtLeastOneCreateMethod(TypeDefinition type)
        {
            var methodsDefinition = type.Methods;
            var filteredMethod = methodsDefinition.Where(
                 m => m.Name.StartsWith("Create")
            );

            return filteredMethod.Count() > 0;
        }
    }
}