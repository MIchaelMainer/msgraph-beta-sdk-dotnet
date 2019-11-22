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
    /// The enum PolicySetStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PolicySetStatus
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Validating
        /// </summary>
        Validating = 1,
	
        /// <summary>
        /// Partial Success
        /// </summary>
        PartialSuccess = 2,
	
        /// <summary>
        /// Success
        /// </summary>
        Success = 3,
	
        /// <summary>
        /// Error
        /// </summary>
        Error = 4,
	
        /// <summary>
        /// Not Assigned
        /// </summary>
        NotAssigned = 5,
	
    }
}
