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
    /// The type MobileAppSupportedDeviceType.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MobileAppSupportedDeviceType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileAppSupportedDeviceType"/> class.
        /// </summary>
        public MobileAppSupportedDeviceType()
        {
            this.ODataType = "microsoft.graph.mobileAppSupportedDeviceType";
        }

        /// <summary>
        /// Gets or sets type.
        /// Device type
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public DeviceType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets minimumOperatingSystemVersion.
        /// Minimum OS version
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumOperatingSystemVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumOperatingSystemVersion { get; set; }
    
        /// <summary>
        /// Gets or sets maximumOperatingSystemVersion.
        /// Maximum OS version
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumOperatingSystemVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MaximumOperatingSystemVersion { get; set; }
    
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
