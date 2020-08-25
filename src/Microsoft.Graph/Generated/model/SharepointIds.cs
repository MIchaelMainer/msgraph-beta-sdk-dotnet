// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type SharepointIds.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SharepointIds
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharepointIds"/> class.
        /// </summary>
        public SharepointIds()
        {
            this.ODataType = "microsoft.graph.sharepointIds";
        }

        /// <summary>
        /// Gets or sets listId.
        /// The unique identifier (guid) for the item's list in SharePoint.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "listId", Required = Newtonsoft.Json.Required.Default)]
        public string ListId { get; set; }
    
        /// <summary>
        /// Gets or sets listItemId.
        /// An integer identifier for the item within the containing list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "listItemId", Required = Newtonsoft.Json.Required.Default)]
        public string ListItemId { get; set; }
    
        /// <summary>
        /// Gets or sets listItemUniqueId.
        /// The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "listItemUniqueId", Required = Newtonsoft.Json.Required.Default)]
        public string ListItemUniqueId { get; set; }
    
        /// <summary>
        /// Gets or sets siteId.
        /// The unique identifier (guid) for the item's site collection (SPSite).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "siteId", Required = Newtonsoft.Json.Required.Default)]
        public string SiteId { get; set; }
    
        /// <summary>
        /// Gets or sets siteUrl.
        /// The SharePoint URL for the site that contains the item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "siteUrl", Required = Newtonsoft.Json.Required.Default)]
        public string SiteUrl { get; set; }
    
        /// <summary>
        /// Gets or sets tenantId.
        /// The unique identifier (guid) for the tenancy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tenantId", Required = Newtonsoft.Json.Required.Default)]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets webId.
        /// The unique identifier (guid) for the item's site (SPWeb).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webId", Required = Newtonsoft.Json.Required.Default)]
        public string WebId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
