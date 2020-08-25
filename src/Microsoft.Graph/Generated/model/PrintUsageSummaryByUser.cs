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
    /// The type Print Usage Summary By User.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrintUsageSummaryByUser : Entity
    {
    
		///<summary>
		/// The PrintUsageSummaryByUser constructor
		///</summary>
        public PrintUsageSummaryByUser()
        {
            this.ODataType = "microsoft.graph.PrintUsageSummaryByUser";
        }
	
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets usage date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usageDate", Required = Newtonsoft.Json.Required.Default)]
        public Date UsageDate { get; set; }
    
        /// <summary>
        /// Gets or sets completed black and white job count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completedBlackAndWhiteJobCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? CompletedBlackAndWhiteJobCount { get; set; }
    
        /// <summary>
        /// Gets or sets completed color job count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completedColorJobCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? CompletedColorJobCount { get; set; }
    
        /// <summary>
        /// Gets or sets incomplete job count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "incompleteJobCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? IncompleteJobCount { get; set; }
    
    }
}

