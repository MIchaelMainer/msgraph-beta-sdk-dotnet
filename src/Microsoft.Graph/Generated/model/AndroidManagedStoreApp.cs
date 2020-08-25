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
    /// The type Android Managed Store App.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidManagedStoreApp : MobileApp
    {
    
		///<summary>
		/// The AndroidManagedStoreApp constructor
		///</summary>
        public AndroidManagedStoreApp()
        {
            this.ODataType = "microsoft.graph.androidManagedStoreApp";
        }
	
        /// <summary>
        /// Gets or sets package id.
        /// The package identifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "packageId", Required = Newtonsoft.Json.Required.Default)]
        public string PackageId { get; set; }
    
        /// <summary>
        /// Gets or sets app identifier.
        /// The Identity Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string AppIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets used license count.
        /// The number of VPP licenses in use.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usedLicenseCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UsedLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets total license count.
        /// The total number of VPP licenses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalLicenseCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets app store url.
        /// The Play for Work Store app URL.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appStoreUrl", Required = Newtonsoft.Json.Required.Default)]
        public string AppStoreUrl { get; set; }
    
        /// <summary>
        /// Gets or sets is private.
        /// Indicates whether the app is only available to a given enterprise's users.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isPrivate", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsPrivate { get; set; }
    
        /// <summary>
        /// Gets or sets is system app.
        /// Indicates whether the app is a preinstalled system app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isSystemApp", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsSystemApp { get; set; }
    
        /// <summary>
        /// Gets or sets app tracks.
        /// The tracks that are visible to this enterprise.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appTracks", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AndroidManagedStoreAppTrack> AppTracks { get; set; }
    
        /// <summary>
        /// Gets or sets supports oem config.
        /// Whether this app supports OEMConfig policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportsOemConfig", Required = Newtonsoft.Json.Required.Default)]
        public bool? SupportsOemConfig { get; set; }
    
    }
}

