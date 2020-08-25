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
    /// The type Privileged Role Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrivilegedRoleSummary : Entity
    {
    
		///<summary>
		/// The PrivilegedRoleSummary constructor
		///</summary>
        public PrivilegedRoleSummary()
        {
            this.ODataType = "microsoft.graph.privilegedRoleSummary";
        }
	
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public RoleSummaryStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets users count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usersCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UsersCount { get; set; }
    
        /// <summary>
        /// Gets or sets managed count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ManagedCount { get; set; }
    
        /// <summary>
        /// Gets or sets elevated count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "elevatedCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ElevatedCount { get; set; }
    
        /// <summary>
        /// Gets or sets mfa enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mfaEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? MfaEnabled { get; set; }
    
    }
}

