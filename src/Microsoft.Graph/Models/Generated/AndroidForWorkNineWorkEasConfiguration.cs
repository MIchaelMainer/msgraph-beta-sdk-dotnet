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
    /// The type Android For Work Nine Work Eas Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidForWorkNineWorkEasConfiguration : AndroidForWorkEasEmailProfileBase
    {
    
		///<summary>
		/// The AndroidForWorkNineWorkEasConfiguration constructor
		///</summary>
        public AndroidForWorkNineWorkEasConfiguration()
        {
            this.ODataType = "microsoft.graph.androidForWorkNineWorkEasConfiguration";
        }
	
        /// <summary>
        /// Gets or sets sync calendar.
        /// Toggles syncing the calendar. If set to false the calendar is turned off on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncCalendar", Required = Newtonsoft.Json.Required.Default)]
        public bool? SyncCalendar { get; set; }
    
        /// <summary>
        /// Gets or sets sync contacts.
        /// Toggles syncing contacts. If set to false contacts are turned off on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncContacts", Required = Newtonsoft.Json.Required.Default)]
        public bool? SyncContacts { get; set; }
    
        /// <summary>
        /// Gets or sets sync tasks.
        /// Toggles syncing tasks. If set to false tasks are turned off on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncTasks", Required = Newtonsoft.Json.Required.Default)]
        public bool? SyncTasks { get; set; }
    
    }
}

