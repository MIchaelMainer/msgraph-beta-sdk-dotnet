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
    /// The enum RestrictionAction.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RestrictionAction
    {
    
        /// <summary>
        /// Warn
        /// </summary>
        Warn = 0,
	
        /// <summary>
        /// Audit
        /// </summary>
        Audit = 1,
	
        /// <summary>
        /// Block
        /// </summary>
        Block = 2,
	
    }
}
