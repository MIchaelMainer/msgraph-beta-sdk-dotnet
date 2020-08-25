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
    /// The enum LongRunningOperationStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum LongRunningOperationStatus
    {
    
        /// <summary>
        /// Notstarted
        /// </summary>
        Notstarted = 0,
	
        /// <summary>
        /// Running
        /// </summary>
        Running = 1,
	
        /// <summary>
        /// Succeeded
        /// </summary>
        Succeeded = 2,
	
        /// <summary>
        /// Failed
        /// </summary>
        Failed = 3,
	
    }
}
