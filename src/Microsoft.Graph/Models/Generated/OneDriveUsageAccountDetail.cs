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
    /// The type One Drive Usage Account Detail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OneDriveUsageAccountDetail : Entity
    {
    
		///<summary>
		/// The OneDriveUsageAccountDetail constructor
		///</summary>
        public OneDriveUsageAccountDetail()
        {
            this.ODataType = "microsoft.graph.oneDriveUsageAccountDetail";
        }
	
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets site url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "siteUrl", Required = Newtonsoft.Json.Required.Default)]
        public string SiteUrl { get; set; }
    
        /// <summary>
        /// Gets or sets owner display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownerDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string OwnerDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets owner principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownerPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string OwnerPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDeleted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDeleted { get; set; }
    
        /// <summary>
        /// Gets or sets last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date LastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets file count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? FileCount { get; set; }
    
        /// <summary>
        /// Gets or sets active file count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeFileCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ActiveFileCount { get; set; }
    
        /// <summary>
        /// Gets or sets storage used in bytes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageUsedInBytes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? StorageUsedInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets storage allocated in bytes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageAllocatedInBytes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? StorageAllocatedInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
    }
}

