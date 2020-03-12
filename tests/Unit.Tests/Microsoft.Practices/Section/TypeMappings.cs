﻿using Microsoft.Practices.Unity.TestSupport;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Unity.Configuration;

namespace Microsoft.Practices
{
    [TestClass]
    public class TypeMappings : MicrosoftPracticesFixture
    {
        private static ContainerElement ContainerElement;


        [ClassInitialize]
        public static void SetupTests(TestContext context)
        {
            InitializeClass(context, "BasicTypeMapping.config");
            ContainerElement = Section.Containers.Default;
        }

        [TestMethod]
        public void RegistrationsArePresentInContainer()
        {
            Assert.AreEqual(2, ContainerElement.Registrations.Count);
        }

        [TestMethod]
        public void TypesAreAsGivenInFile()
        {
            AssertRegistrationsAreSame(r => r.TypeName, "ILogger", "ILogger");
        }

        [TestMethod]
        public void MappedNamesAreAsGivenInFile()
        {
            AssertRegistrationsAreSame(r => r.Name, String.Empty, "special");
        }

        [TestMethod]
        public void MappedToTypesAreAsGivenInFile()
        {
            AssertRegistrationsAreSame(r => r.MapToName, "MockLogger", "SpecialLogger");
        }

        private void AssertRegistrationsAreSame(Func<RegisterElement, string> selector, params string[] expectedStrings)
        {
            CollectionAssertExtensions.AreEqual(expectedStrings, ContainerElement.Registrations.Select(selector).ToList());
        }
    }
}
