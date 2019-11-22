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
    /// The type Subscription.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Subscription : Entity
    {
    
		///<summary>
		/// The Subscription constructor
		///</summary>
        public Subscription()
        {
            this.ODataType = "microsoft.graph.subscription";
        }
	
        /// <summary>
        /// Gets or sets resource.
        /// Required. Specifies the resource that will be monitored for changes. Do not include the base URL (https://graph.microsoft.com/v1.0/).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resource", Required = Newtonsoft.Json.Required.Default)]
        public string Resource { get; set; }
    
        /// <summary>
        /// Gets or sets change type.
        /// Required. Indicates the type of change in the subscribed resource that will raise a notification. The supported values are: created, updated, deleted. Multiple values can be combined using a comma-separated list.Note: Drive root item notifications support only the updated changeType. User and group notifications support updated and deleted changeType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "changeType", Required = Newtonsoft.Json.Required.Default)]
        public string ChangeType { get; set; }
    
        /// <summary>
        /// Gets or sets client state.
        /// Optional. Specifies the value of the clientState property sent by the service in each notification. The maximum length is 128 characters. The client can check that the notification came from the service by comparing the value of the clientState property sent with the subscription with the value of the clientState property received with each notification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientState", Required = Newtonsoft.Json.Required.Default)]
        public string ClientState { get; set; }
    
        /// <summary>
        /// Gets or sets notification url.
        /// Required. The URL of the endpoint that will receive the notifications. This URL must make use of the HTTPS protocol.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string NotificationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// Required. Specifies the date and time when the webhook subscription expires. The time is in UTC, and can be an amount of time from subscription creation that varies for the resource subscribed to.  See the table below for maximum supported subscription length of time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets application id.
        /// Identifier of the application used to create the subscription. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationId", Required = Newtonsoft.Json.Required.Default)]
        public string ApplicationId { get; set; }
    
        /// <summary>
        /// Gets or sets creator id.
        /// Identifier of the user or service principal that created the subscription. If the app used delegated permissions to create the subscription, this field contains the id of the signed-in user the app called on behalf of. If the app used application permissions, this field contains the id of the service principal corresponding to the app. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "creatorId", Required = Newtonsoft.Json.Required.Default)]
        public string CreatorId { get; set; }
    
        /// <summary>
        /// Gets or sets include properties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "includeProperties", Required = Newtonsoft.Json.Required.Default)]
        public bool? IncludeProperties { get; set; }
    
        /// <summary>
        /// Gets or sets include resource data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "includeResourceData", Required = Newtonsoft.Json.Required.Default)]
        public bool? IncludeResourceData { get; set; }
    
        /// <summary>
        /// Gets or sets lifecycle notification url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lifecycleNotificationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string LifecycleNotificationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets encryption certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptionCertificate", Required = Newtonsoft.Json.Required.Default)]
        public string EncryptionCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets encryption certificate id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptionCertificateId", Required = Newtonsoft.Json.Required.Default)]
        public string EncryptionCertificateId { get; set; }
    
    }
}

