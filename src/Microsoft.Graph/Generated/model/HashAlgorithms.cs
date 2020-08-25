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
    /// The enum HashAlgorithms.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum HashAlgorithms
    {
    
        /// <summary>
        /// Sha1
        /// </summary>
        Sha1 = 1,
	
        /// <summary>
        /// Sha2
        /// </summary>
        Sha2 = 2,
	
    }
}
