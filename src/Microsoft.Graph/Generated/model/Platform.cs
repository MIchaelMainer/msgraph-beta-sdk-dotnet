// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum Platform.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum Platform
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Ios
        /// </summary>
        Ios = 1,
	
        /// <summary>
        /// Android
        /// </summary>
        Android = 2,
	
        /// <summary>
        /// Windows
        /// </summary>
        Windows = 3,
	
        /// <summary>
        /// Windows Mobile
        /// </summary>
        WindowsMobile = 4,
	
        /// <summary>
        /// Mac OS
        /// </summary>
        MacOS = 5,
	
    }
}
