// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Term.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Term : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The Term constructor
		///</summary>
        public Term()
        {
            this.ODataType = "microsoft.graph.termStore.term";
        }
	
        /// <summary>
        /// Gets or sets labels.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "labels", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<LocalizedLabel> Labels { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets descriptions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "descriptions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<LocalizedDescription> Descriptions { get; set; }
    
        /// <summary>
        /// Gets or sets properties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "properties", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Microsoft.Graph.KeyValue> Properties { get; set; }
    
        /// <summary>
        /// Gets or sets children.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "children", Required = Newtonsoft.Json.Required.Default)]
        public ITermChildrenCollectionPage Children { get; set; }
    
        /// <summary>
        /// Gets or sets relations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "relations", Required = Newtonsoft.Json.Required.Default)]
        public ITermRelationsCollectionPage Relations { get; set; }
    
        /// <summary>
        /// Gets or sets set.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "set", Required = Newtonsoft.Json.Required.Default)]
        public Set Set { get; set; }
    
    }
}

