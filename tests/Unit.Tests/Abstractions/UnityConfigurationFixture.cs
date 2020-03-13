﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity.Configuration.Tests;

namespace Unity.Configuration
{
    public abstract class UnityConfigurationFixture : ConfigFixtureBase
    {
        protected static UnityConfigurationSection Section { get; private set; }


        protected static void InitializeClass(TestContext context, string configuration = null)
        {
            InitializeClass(context, typeof(UnityConfigurationSection).Namespace, configuration);
            Section = (UnityConfigurationSection)Configuration.GetSection(SectionName);
        }

        protected UnityConfigurationSection GetSection(string name) => (UnityConfigurationSection)Configuration.GetSection(name);

        protected override void LoadContainer()
        {
            base.CreateContainer();
            Section.Configure(Container);
        }

        protected override void LoadContainer(string name)
        {
            base.CreateContainer();
            Section.Configure(Container, name);
        }

        protected override void LoadContainer(string section, string name)
        {
            base.CreateContainer();
            ((UnityConfigurationSection)Configuration.GetSection(section)).Configure(Container, name);
        }
    }
}
