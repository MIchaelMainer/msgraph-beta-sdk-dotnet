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
    /// The enum WindowsStartMenuAppListVisibilityType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum WindowsStartMenuAppListVisibilityType
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Collapse
        /// </summary>
        Collapse = 1,
	
        /// <summary>
        /// Remove
        /// </summary>
        Remove = 2,
	
        /// <summary>
        /// Disable Settings App
        /// </summary>
        DisableSettingsApp = 4,
	
    }
}
