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
    /// The type Android Work Profile Eas Email Profile Base.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidWorkProfileEasEmailProfileBase : DeviceConfiguration
    {
    
		///<summary>
		/// The internal AndroidWorkProfileEasEmailProfileBase constructor
		///</summary>
        protected internal AndroidWorkProfileEasEmailProfileBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication method for Exchange ActiveSync.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethod", Required = Newtonsoft.Json.Required.Default)]
        public EasAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets duration of email to sync.
        /// Duration of time email should be synced to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "durationOfEmailToSync", Required = Newtonsoft.Json.Required.Default)]
        public EmailSyncDuration? DurationOfEmailToSync { get; set; }
    
        /// <summary>
        /// Gets or sets email address source.
        /// Email attribute that is picked from AAD and injected into this profile before installing on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailAddressSource", Required = Newtonsoft.Json.Required.Default)]
        public UserEmailSource? EmailAddressSource { get; set; }
    
        /// <summary>
        /// Gets or sets host name.
        /// Exchange location (URL) that the mail app connects to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hostName", Required = Newtonsoft.Json.Required.Default)]
        public string HostName { get; set; }
    
        /// <summary>
        /// Gets or sets require ssl.
        /// Indicates whether or not to use SSL.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireSsl", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireSsl { get; set; }
    
        /// <summary>
        /// Gets or sets username source.
        /// Username attribute that is picked from AAD and injected into this profile before installing on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usernameSource", Required = Newtonsoft.Json.Required.Default)]
        public AndroidUsernameSource? UsernameSource { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// Identity certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityCertificate", Required = Newtonsoft.Json.Required.Default)]
        public AndroidWorkProfileCertificateProfileBase IdentityCertificate { get; set; }
    
    }
}

