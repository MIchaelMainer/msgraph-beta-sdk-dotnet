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
    /// The type DeviceExchangeAccessStateSummary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceExchangeAccessStateSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceExchangeAccessStateSummary"/> class.
        /// </summary>
        public DeviceExchangeAccessStateSummary()
        {
            this.ODataType = "microsoft.graph.deviceExchangeAccessStateSummary";
        }

        /// <summary>
        /// Gets or sets allowedDeviceCount.
        /// Total count of devices with Exchange Access State: Allowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? AllowedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets blockedDeviceCount.
        /// Total count of devices with Exchange Access State: Blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "blockedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? BlockedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets quarantinedDeviceCount.
        /// Total count of devices with Exchange Access State: Quarantined.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quarantinedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? QuarantinedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets unknownDeviceCount.
        /// Total count of devices with Exchange Access State: Unknown.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unknownDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UnknownDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets unavailableDeviceCount.
        /// Total count of devices for which no Exchange Access State could be found.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unavailableDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UnavailableDeviceCount { get; set; }
    
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
