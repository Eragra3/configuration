﻿

using Microsoft.Practices.Tests;
using Microsoft.Practices.Unity.TestSupport;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Microsoft.Practices.Containers
{
    [TestClass]
    public class OldContainersSyntax : MicrosoftPracticesFixture
    {
        [ClassInitialize]
        public static void SetupTests(TestContext context)
        {
            SetupTests(context, "OldContainersSyntax.config");
        }

        [TestMethod]
        public void Then_SectionContainsExpectedNumberOfContainers()
        {
            Assert.AreEqual(2, Section.Containers.Count);
        }

        public void Then_ContainersArePresentInFileOrder()
        {
            CollectionAssertExtensions.AreEqual(new[] { String.Empty, "two" },
                Section.Containers.Select(c => c.Name).ToList());
        }
    }
}
