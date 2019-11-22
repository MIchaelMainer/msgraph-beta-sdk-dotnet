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
    /// The type Skype For Business Peer To Peer Activity Counts.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SkypeForBusinessPeerToPeerActivityCounts : Entity
    {
    
		///<summary>
		/// The SkypeForBusinessPeerToPeerActivityCounts constructor
		///</summary>
        public SkypeForBusinessPeerToPeerActivityCounts()
        {
            this.ODataType = "microsoft.graph.skypeForBusinessPeerToPeerActivityCounts";
        }
	
        /// <summary>
        /// Gets or sets im.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "im", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Im { get; set; }
    
        /// <summary>
        /// Gets or sets audio.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "audio", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Audio { get; set; }
    
        /// <summary>
        /// Gets or sets video.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "video", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Video { get; set; }
    
        /// <summary>
        /// Gets or sets app sharing.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appSharing", Required = Newtonsoft.Json.Required.Default)]
        public Int64? AppSharing { get; set; }
    
        /// <summary>
        /// Gets or sets file transfer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileTransfer", Required = Newtonsoft.Json.Required.Default)]
        public Int64? FileTransfer { get; set; }
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets report date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportDate { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
    }
}

