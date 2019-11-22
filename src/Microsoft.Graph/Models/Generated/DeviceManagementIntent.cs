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
    /// The type Device Management Intent.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementIntent : Entity
    {
    
		///<summary>
		/// The DeviceManagementIntent constructor
		///</summary>
        public DeviceManagementIntent()
        {
            this.ODataType = "microsoft.graph.deviceManagementIntent";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The user given display name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The user given description
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets is assigned.
        /// Signifies whether or not the intent is assigned to users
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isAssigned", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsAssigned { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// When the intent was last modified
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets template id.
        /// The ID of the template this intent was created from (if any)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "templateId", Required = Newtonsoft.Json.Required.Default)]
        public string TemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// Collection of all settings to be applied
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementIntentSettingsCollectionPage Settings { get; set; }
    
        /// <summary>
        /// Gets or sets categories.
        /// Collection of setting categories within the intent
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "categories", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementIntentCategoriesCollectionPage Categories { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// Collection of assignments
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementIntentAssignmentsCollectionPage Assignments { get; set; }
    
        /// <summary>
        /// Gets or sets device setting state summaries.
        /// Collection of settings and their states and counts of devices that belong to corresponding state for all settings within the intent
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceSettingStateSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementIntentDeviceSettingStateSummariesCollectionPage DeviceSettingStateSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets device states.
        /// Collection of states of all devices that the intent is applied to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceStates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementIntentDeviceStatesCollectionPage DeviceStates { get; set; }
    
        /// <summary>
        /// Gets or sets user states.
        /// Collection of states of all users that the intent is applied to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userStates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementIntentUserStatesCollectionPage UserStates { get; set; }
    
        /// <summary>
        /// Gets or sets device state summary.
        /// A summary of device states and counts of devices that belong to corresponding state for all devices that the intent is applied to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceStateSummary", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementIntentDeviceStateSummary DeviceStateSummary { get; set; }
    
        /// <summary>
        /// Gets or sets user state summary.
        /// A summary of user states and counts of users that belong to corresponding state for all users that the intent is applied to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userStateSummary", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementIntentUserStateSummary UserStateSummary { get; set; }
    
    }
}

