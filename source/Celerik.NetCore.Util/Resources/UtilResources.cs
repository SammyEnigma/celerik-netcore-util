﻿using System.Globalization;
using Microsoft.Extensions.Localization;

namespace Celerik.NetCore.Util
{
    /// <summary>
    /// Provides localized strings for this layer. By default,
    /// a JsonStringLocalizerFactory is used.
    /// </summary>
    public static class UtilResources
    {
        /// <summary>
        /// Reference to the current IStringLocalizer instance.
        /// </summary>
        private static IStringLocalizer _localizer;

        /// <summary>
        /// Performs static initialization for this class.
        /// </summary>
        static UtilResources()
            => Initialize(new JsonStringLocalizerFactory());

        /// <summary>
        /// Performs static initialization for this class.
        /// </summary>
        /// <param name="factory">Factory to create IStringLocalizer objects.
        /// </param>
        public static void Initialize(IStringLocalizerFactory factory)
        {
            _localizer = null;
            Factory = factory;
        }

        /// <summary>
        /// Gets a reference to the factory to create IStringLocalizer objects.
        /// </summary>
        public static IStringLocalizerFactory Factory { get; private set; }

        /// <summary>
        /// Gets a reference to the current IStringLocalizer instance, in
        /// case the instance is null, a new one is created.
        /// </summary>
        private static IStringLocalizer Localizer
        {
            get
            {
                if (_localizer == null && Factory != null)
                    _localizer = Factory.Create(typeof(UtilResources));

                return _localizer;
            }
        }

        /// <summary>
        /// Gets the string resource with the given name.
        /// </summary>
        /// <param name="name">The name of the string resource.</param>
        /// <returns>The string resource.</returns>
        public static string Get(string name)
            => Localizer?[name].Value ?? name;

        /// <summary>
        /// Gets the string resource with the given name and formatted with
        /// the supplied arguments, using the current culture.
        /// </summary>
        /// <param name="name">The name of the string resource.</param>
        /// <param name="arguments">The values to format the string with.</param>
        /// <returns>The formatted string resource.</returns>
        public static string Get(string name, params object[] arguments)
            => Localizer?[name, arguments].Value
                ?? string.Format(CultureInfo.CurrentCulture, name, arguments);
    }
}
