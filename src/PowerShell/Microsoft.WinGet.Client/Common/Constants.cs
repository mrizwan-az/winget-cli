﻿// -----------------------------------------------------------------------------
// <copyright file="Constants.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. Licensed under the MIT License.
// </copyright>
// -----------------------------------------------------------------------------

namespace Microsoft.WinGet.Client.Common
{
    using Microsoft.Management.Deployment;

    /// <summary>
    /// This class contains all of the configurable constants for this project.
    /// </summary>
    internal static class Constants
    {
        /// <summary>
        /// If a command allows the specification of the maximum number of results to return, this is the lower bound for that value.
        /// </summary>
        public const uint CountLowerBound = 1;

        /// <summary>
        /// If a command allows the specification of the maximum number of results to return, this is the upper bound for that value.
        /// </summary>
        public const uint CountUpperBound = 1000;

        /// <summary>
        /// This parameter set indicates that a package was provided via a parameter or the pipeline and it can be acted on directly.
        /// </summary>
        public const string GivenSet = "GivenSet";

        /// <summary>
        /// This parameter set indicates that a package was not provided via a parameter or the pipeline and it
        /// needs to be found by searching a package source.
        /// </summary>
        public const string FoundSet = "FoundSet";

        /// <summary>
        /// Nouns used for different cmdlets. Changing this will alter the names of the related commands.
        /// </summary>
        public static class WinGetNouns
        {
            /// <summary>
            /// The noun analogue of the <see cref="CatalogPackage" /> class.
            /// </summary>
            public const string Package = "WinGetPackage";

            /// <summary>
            /// The noun analogue of the <see cref="PackageCatalogReference" /> class.
            /// </summary>
            public const string Source = "WinGetSource";

            /// <summary>
            /// The noun for any user settings cmdlet.
            /// </summary>
            public const string UserSettings = "WinGetUserSettings";
        }
    }
}
