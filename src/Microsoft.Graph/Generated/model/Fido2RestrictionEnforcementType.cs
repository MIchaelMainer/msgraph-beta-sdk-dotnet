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
    /// The enum Fido2RestrictionEnforcementType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum Fido2RestrictionEnforcementType
    {
    
        /// <summary>
        /// Allow
        /// </summary>
        Allow = 0,
	
        /// <summary>
        /// Block
        /// </summary>
        Block = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}
