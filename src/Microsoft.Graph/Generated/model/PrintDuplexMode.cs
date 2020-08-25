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
    /// The enum PrintDuplexMode.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PrintDuplexMode
    {
    
        /// <summary>
        /// Flip On Long Edge
        /// </summary>
        FlipOnLongEdge = 0,
	
        /// <summary>
        /// Flip On Short Edge
        /// </summary>
        FlipOnShortEdge = 1,
	
        /// <summary>
        /// One Sided
        /// </summary>
        OneSided = 2,
	
    }
}
