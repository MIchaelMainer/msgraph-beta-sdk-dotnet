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
    /// The type Mobile App Intent And State.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppIntentAndState : Entity
    {
    
		///<summary>
		/// The MobileAppIntentAndState constructor
		///</summary>
        public MobileAppIntentAndState()
        {
            this.ODataType = "microsoft.graph.mobileAppIntentAndState";
        }
	
        /// <summary>
        /// Gets or sets managed device identifier.
        /// Device identifier created or collected by Intune.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// Identifier for the user that tried to enroll the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets mobile app list.
        /// The list of payload intents and states for the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileAppList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MobileAppIntentAndStateDetail> MobileAppList { get; set; }
    
    }
}

