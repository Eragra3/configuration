﻿using System;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration.ConfigurationHelpers;
using Unity.Configuration;

namespace Microsoft.Practices.Unity.Configuration
{
    /// <summary>
    /// A collection of <see cref="ExtensionConfigurationElement"/>s.
    /// </summary>
    [ConfigurationCollection(typeof(ExtensionConfigurationElement))]
    public class ExtensionConfigurationElementCollection : DeserializableConfigurationElementCollectionBase<ExtensionConfigurationElement>
    {
        /// <summary>
        /// When overridden in a derived class, creates a new <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        protected override ConfigurationElement CreateNewElement()
        {
            throw new InvalidOperationException(Constants.CannotCreateExtensionConfigurationElement);
        }

        /// <summary>
        /// Gets the element key for a specified configuration element when overridden in a derived class.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Object"/> that acts as the key for the specified <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        /// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement"/> to return the key for. </param>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ExtensionConfigurationElement)element).Key;
        }
    }
}
