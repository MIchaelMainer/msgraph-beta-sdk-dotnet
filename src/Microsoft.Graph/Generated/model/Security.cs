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
    /// The type Security.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Security : Entity
    {
    
		///<summary>
		/// The Security constructor
		///</summary>
        public Security()
        {
            this.ODataType = "microsoft.graph.security";
        }
	
        /// <summary>
        /// Gets or sets provider status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "providerStatus", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SecurityProviderStatus> ProviderStatus { get; set; }
    
        /// <summary>
        /// Gets or sets alerts.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alerts", Required = Newtonsoft.Json.Required.Default)]
        public ISecurityAlertsCollectionPage Alerts { get; set; }
    
        /// <summary>
        /// Gets or sets cloud app security profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cloudAppSecurityProfiles", Required = Newtonsoft.Json.Required.Default)]
        public ISecurityCloudAppSecurityProfilesCollectionPage CloudAppSecurityProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets domain security profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domainSecurityProfiles", Required = Newtonsoft.Json.Required.Default)]
        public ISecurityDomainSecurityProfilesCollectionPage DomainSecurityProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets file security profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileSecurityProfiles", Required = Newtonsoft.Json.Required.Default)]
        public ISecurityFileSecurityProfilesCollectionPage FileSecurityProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets host security profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hostSecurityProfiles", Required = Newtonsoft.Json.Required.Default)]
        public ISecurityHostSecurityProfilesCollectionPage HostSecurityProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets ip security profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipSecurityProfiles", Required = Newtonsoft.Json.Required.Default)]
        public ISecurityIpSecurityProfilesCollectionPage IpSecurityProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets provider tenant settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "providerTenantSettings", Required = Newtonsoft.Json.Required.Default)]
        public ISecurityProviderTenantSettingsCollectionPage ProviderTenantSettings { get; set; }
    
        /// <summary>
        /// Gets or sets secure score control profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "secureScoreControlProfiles", Required = Newtonsoft.Json.Required.Default)]
        public ISecuritySecureScoreControlProfilesCollectionPage SecureScoreControlProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets secure scores.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "secureScores", Required = Newtonsoft.Json.Required.Default)]
        public ISecuritySecureScoresCollectionPage SecureScores { get; set; }
    
        /// <summary>
        /// Gets or sets ti indicators.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tiIndicators", Required = Newtonsoft.Json.Required.Default)]
        public ISecurityTiIndicatorsCollectionPage TiIndicators { get; set; }
    
        /// <summary>
        /// Gets or sets user security profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userSecurityProfiles", Required = Newtonsoft.Json.Required.Default)]
        public ISecurityUserSecurityProfilesCollectionPage UserSecurityProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets security actions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityActions", Required = Newtonsoft.Json.Required.Default)]
        public ISecuritySecurityActionsCollectionPage SecurityActions { get; set; }
    
    }
}

