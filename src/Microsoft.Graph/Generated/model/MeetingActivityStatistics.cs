// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Meeting Activity Statistics.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MeetingActivityStatistics : ActivityStatistics
    {
    
		///<summary>
		/// The MeetingActivityStatistics constructor
		///</summary>
        public MeetingActivityStatistics()
        {
            this.ODataType = "microsoft.graph.meetingActivityStatistics";
        }
	
        /// <summary>
        /// Gets or sets after hours.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "afterHours", Required = Newtonsoft.Json.Required.Default)]
        public Duration AfterHours { get; set; }
    
        /// <summary>
        /// Gets or sets organized.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organized", Required = Newtonsoft.Json.Required.Default)]
        public Duration Organized { get; set; }
    
        /// <summary>
        /// Gets or sets recurring.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recurring", Required = Newtonsoft.Json.Required.Default)]
        public Duration Recurring { get; set; }
    
        /// <summary>
        /// Gets or sets long.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "long", Required = Newtonsoft.Json.Required.Default)]
        public Duration Long { get; set; }
    
        /// <summary>
        /// Gets or sets conflicting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conflicting", Required = Newtonsoft.Json.Required.Default)]
        public Duration Conflicting { get; set; }
    
        /// <summary>
        /// Gets or sets multitasking.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multitasking", Required = Newtonsoft.Json.Required.Default)]
        public Duration Multitasking { get; set; }
    
    }
}

