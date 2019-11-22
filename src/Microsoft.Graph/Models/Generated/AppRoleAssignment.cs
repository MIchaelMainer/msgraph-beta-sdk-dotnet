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
    /// The type App Role Assignment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AppRoleAssignment : Entity
    {
    
		///<summary>
		/// The AppRoleAssignment constructor
		///</summary>
        public AppRoleAssignment()
        {
            this.ODataType = "microsoft.graph.appRoleAssignment";
        }
	
        /// <summary>
        /// Gets or sets app role id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appRoleId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? AppRoleId { get; set; }
    
        /// <summary>
        /// Gets or sets creation timestamp.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "creationTimestamp", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreationTimestamp { get; set; }
    
        /// <summary>
        /// Gets or sets principal display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "principalDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string PrincipalDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets principal id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "principalId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? PrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets principal type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "principalType", Required = Newtonsoft.Json.Required.Default)]
        public string PrincipalType { get; set; }
    
        /// <summary>
        /// Gets or sets resource display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? ResourceId { get; set; }
    
    }
}

