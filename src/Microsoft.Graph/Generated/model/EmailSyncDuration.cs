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
    /// The enum EmailSyncDuration.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EmailSyncDuration
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// One Day
        /// </summary>
        OneDay = 1,
	
        /// <summary>
        /// Three Days
        /// </summary>
        ThreeDays = 2,
	
        /// <summary>
        /// One Week
        /// </summary>
        OneWeek = 3,
	
        /// <summary>
        /// Two Weeks
        /// </summary>
        TwoWeeks = 4,
	
        /// <summary>
        /// One Month
        /// </summary>
        OneMonth = 5,
	
        /// <summary>
        /// Unlimited
        /// </summary>
        Unlimited = 6,
	
    }
}
