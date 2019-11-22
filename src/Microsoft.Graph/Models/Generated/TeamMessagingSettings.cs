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
    /// The type TeamMessagingSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class TeamMessagingSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMessagingSettings"/> class.
        /// </summary>
        public TeamMessagingSettings()
        {
            this.ODataType = "microsoft.graph.teamMessagingSettings";
        }

        /// <summary>
        /// Gets or sets allowUserEditMessages.
        /// If set to true, users can edit their messages.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowUserEditMessages", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowUserEditMessages { get; set; }
    
        /// <summary>
        /// Gets or sets allowUserDeleteMessages.
        /// If set to true, users can delete their messages.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowUserDeleteMessages", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowUserDeleteMessages { get; set; }
    
        /// <summary>
        /// Gets or sets allowOwnerDeleteMessages.
        /// If set to true, owners can delete any message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowOwnerDeleteMessages", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowOwnerDeleteMessages { get; set; }
    
        /// <summary>
        /// Gets or sets allowTeamMentions.
        /// If set to true, @team mentions are allowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowTeamMentions", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowTeamMentions { get; set; }
    
        /// <summary>
        /// Gets or sets allowChannelMentions.
        /// If set to true, @channel mentions are allowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowChannelMentions", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowChannelMentions { get; set; }
    
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
