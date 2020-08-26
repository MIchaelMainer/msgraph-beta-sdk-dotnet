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
    /// The enum OfficeUpdateChannel.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum OfficeUpdateChannel
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Current
        /// </summary>
        Current = 1,
	
        /// <summary>
        /// Deferred
        /// </summary>
        Deferred = 2,
	
        /// <summary>
        /// First Release Current
        /// </summary>
        FirstReleaseCurrent = 3,
	
        /// <summary>
        /// First Release Deferred
        /// </summary>
        FirstReleaseDeferred = 4,
	
        /// <summary>
        /// Monthly Enterprise
        /// </summary>
        MonthlyEnterprise = 5,
	
    }
}