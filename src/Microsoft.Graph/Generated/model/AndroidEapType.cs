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
    /// The enum AndroidEapType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidEapType
    {
    
        /// <summary>
        /// Eap Tls
        /// </summary>
        EapTls = 13,
	
        /// <summary>
        /// Eap Ttls
        /// </summary>
        EapTtls = 21,
	
        /// <summary>
        /// Peap
        /// </summary>
        Peap = 25,
	
    }
}
