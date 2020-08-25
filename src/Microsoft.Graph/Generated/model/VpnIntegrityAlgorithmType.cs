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
    /// The enum VpnIntegrityAlgorithmType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum VpnIntegrityAlgorithmType
    {
    
        /// <summary>
        /// Sha2_256
        /// </summary>
        Sha2_256 = 0,
	
        /// <summary>
        /// Sha1_96
        /// </summary>
        Sha1_96 = 1,
	
        /// <summary>
        /// Sha1_160
        /// </summary>
        Sha1_160 = 2,
	
        /// <summary>
        /// Sha2_384
        /// </summary>
        Sha2_384 = 3,
	
        /// <summary>
        /// Sha2_512
        /// </summary>
        Sha2_512 = 4,
	
        /// <summary>
        /// Md5
        /// </summary>
        Md5 = 5,
	
    }
}
