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
    /// The type Team.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Team : Entity
    {
    
		///<summary>
		/// The Team constructor
		///</summary>
        public Team()
        {
            this.ODataType = "microsoft.graph.team";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The name of the team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// An optional description for the team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets internal id.
        /// A unique ID for the team that has been used in a few places such as the audit log/Office 365 Management Activity API.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "internalId", Required = Newtonsoft.Json.Required.Default)]
        public string InternalId { get; set; }
    
        /// <summary>
        /// Gets or sets classification.
        /// An optional label. Typically describes the data or business sensitivity of the team. Must match one of a pre-configured set in the tenant's directory.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classification", Required = Newtonsoft.Json.Required.Default)]
        public string Classification { get; set; }
    
        /// <summary>
        /// Gets or sets specialization.
        /// Optional. Indicates whether the team is intended for a particular use case.  Each team specialization has access to unique behaviors and experiences targeted to its use case.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "specialization", Required = Newtonsoft.Json.Required.Default)]
        public TeamSpecialization? Specialization { get; set; }
    
        /// <summary>
        /// Gets or sets visibility.
        /// The visibility of a the group and team. Defaults to Public.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "visibility", Required = Newtonsoft.Json.Required.Default)]
        public TeamVisibilityType? Visibility { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// A hyperlink that will go to the team in the Microsoft Teams client. This is the URL that you get when you right-click a team in the Microsoft Teams client and select Get link to team. This URL should be treated as an opaque blob, and not parsed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets member settings.
        /// Settings to configure whether members can perform certain actions, for example, create channels and add bots, in the team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "memberSettings", Required = Newtonsoft.Json.Required.Default)]
        public TeamMemberSettings MemberSettings { get; set; }
    
        /// <summary>
        /// Gets or sets guest settings.
        /// Settings to configure whether guests can create, update, or delete channels in the team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "guestSettings", Required = Newtonsoft.Json.Required.Default)]
        public TeamGuestSettings GuestSettings { get; set; }
    
        /// <summary>
        /// Gets or sets messaging settings.
        /// Settings to configure messaging and mentions in the team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messagingSettings", Required = Newtonsoft.Json.Required.Default)]
        public TeamMessagingSettings MessagingSettings { get; set; }
    
        /// <summary>
        /// Gets or sets fun settings.
        /// Settings to configure use of Giphy, memes, and stickers in the team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "funSettings", Required = Newtonsoft.Json.Required.Default)]
        public TeamFunSettings FunSettings { get; set; }
    
        /// <summary>
        /// Gets or sets discovery settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discoverySettings", Required = Newtonsoft.Json.Required.Default)]
        public TeamDiscoverySettings DiscoverySettings { get; set; }
    
        /// <summary>
        /// Gets or sets is archived.
        /// Whether this team is in read-only mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isArchived", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsArchived { get; set; }
    
        /// <summary>
        /// Gets or sets is membership limited to owners.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isMembershipLimitedToOwners", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsMembershipLimitedToOwners { get; set; }
    
        /// <summary>
        /// Gets or sets schedule.
        /// The schedule of shifts for this team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schedule", Required = Newtonsoft.Json.Required.Default)]
        public Schedule Schedule { get; set; }
    
        /// <summary>
        /// Gets or sets group.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "group", Required = Newtonsoft.Json.Required.Default)]
        public Group Group { get; set; }
    
        /// <summary>
        /// Gets or sets template.
        /// The template this team was created from. See available templates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "template", Required = Newtonsoft.Json.Required.Default)]
        public TeamsTemplate Template { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "photo", Required = Newtonsoft.Json.Required.Default)]
        public ProfilePhoto Photo { get; set; }
    
        /// <summary>
        /// Gets or sets owners.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "owners", Required = Newtonsoft.Json.Required.Default)]
        public ITeamOwnersCollectionWithReferencesPage Owners { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// Members and owners of the team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "members", Required = Newtonsoft.Json.Required.Default)]
        public ITeamMembersCollectionPage Members { get; set; }
    
        /// <summary>
        /// Gets or sets channels.
        /// The collection of channels &amp; messages associated with the team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "channels", Required = Newtonsoft.Json.Required.Default)]
        public ITeamChannelsCollectionPage Channels { get; set; }
    
        /// <summary>
        /// Gets or sets primary channel.
        /// The general channel for the team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "primaryChannel", Required = Newtonsoft.Json.Required.Default)]
        public Channel PrimaryChannel { get; set; }
    
        /// <summary>
        /// Gets or sets installed apps.
        /// The apps installed in this team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installedApps", Required = Newtonsoft.Json.Required.Default)]
        public ITeamInstalledAppsCollectionPage InstalledApps { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// The async operations that ran or are running on this team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operations", Required = Newtonsoft.Json.Required.Default)]
        public ITeamOperationsCollectionPage Operations { get; set; }
    
    }
}

