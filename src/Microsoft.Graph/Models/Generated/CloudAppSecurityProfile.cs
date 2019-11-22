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
    /// The type Cloud App Security Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CloudAppSecurityProfile : Entity
    {
    
		///<summary>
		/// The CloudAppSecurityProfile constructor
		///</summary>
        public CloudAppSecurityProfile()
        {
            this.ODataType = "microsoft.graph.cloudAppSecurityProfile";
        }
	
        /// <summary>
        /// Gets or sets azure subscription id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureSubscriptionId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureSubscriptionId { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureTenantId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deployment package url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentPackageUrl", Required = Newtonsoft.Json.Required.Default)]
        public string DeploymentPackageUrl { get; set; }
    
        /// <summary>
        /// Gets or sets destination service name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationServiceName", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationServiceName { get; set; }
    
        /// <summary>
        /// Gets or sets is signed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isSigned", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsSigned { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets manifest.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "manifest", Required = Newtonsoft.Json.Required.Default)]
        public string Manifest { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets permissions required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "permissionsRequired", Required = Newtonsoft.Json.Required.Default)]
        public ApplicationPermissionsRequired? PermissionsRequired { get; set; }
    
        /// <summary>
        /// Gets or sets platform.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "platform", Required = Newtonsoft.Json.Required.Default)]
        public string Platform { get; set; }
    
        /// <summary>
        /// Gets or sets policy name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyName", Required = Newtonsoft.Json.Required.Default)]
        public string PolicyName { get; set; }
    
        /// <summary>
        /// Gets or sets publisher.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publisher", Required = Newtonsoft.Json.Required.Default)]
        public string Publisher { get; set; }
    
        /// <summary>
        /// Gets or sets risk score.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskScore", Required = Newtonsoft.Json.Required.Default)]
        public string RiskScore { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tags", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets vendor information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendorInformation", Required = Newtonsoft.Json.Required.Default)]
        public SecurityVendorInformation VendorInformation { get; set; }
    
    }
}

