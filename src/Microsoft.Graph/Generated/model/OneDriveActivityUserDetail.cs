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
    /// The type One Drive Activity User Detail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OneDriveActivityUserDetail : Entity
    {
    
		///<summary>
		/// The OneDriveActivityUserDetail constructor
		///</summary>
        public OneDriveActivityUserDetail()
        {
            this.ODataType = "microsoft.graph.oneDriveActivityUserDetail";
        }
	
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDeleted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDeleted { get; set; }
    
        /// <summary>
        /// Gets or sets deleted date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deletedDate", Required = Newtonsoft.Json.Required.Default)]
        public Date DeletedDate { get; set; }
    
        /// <summary>
        /// Gets or sets last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date LastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets viewed or edited file count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "viewedOrEditedFileCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ViewedOrEditedFileCount { get; set; }
    
        /// <summary>
        /// Gets or sets synced file count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncedFileCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SyncedFileCount { get; set; }
    
        /// <summary>
        /// Gets or sets shared internally file count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharedInternallyFileCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SharedInternallyFileCount { get; set; }
    
        /// <summary>
        /// Gets or sets shared externally file count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharedExternallyFileCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SharedExternallyFileCount { get; set; }
    
        /// <summary>
        /// Gets or sets assigned products.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedProducts", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AssignedProducts { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
    }
}

