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
    /// The type CertificateConnectorSetting.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class CertificateConnectorSetting
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateConnectorSetting"/> class.
        /// </summary>
        public CertificateConnectorSetting()
        {
            this.ODataType = "microsoft.graph.certificateConnectorSetting";
        }

        /// <summary>
        /// Gets or sets status.
        /// Certificate connector status
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Status { get; set; }
    
        /// <summary>
        /// Gets or sets certExpiryTime.
        /// Certificate expire time
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certExpiryTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CertExpiryTime { get; set; }
    
        /// <summary>
        /// Gets or sets enrollmentError.
        /// Certificate connector enrollment error
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentError", Required = Newtonsoft.Json.Required.Default)]
        public string EnrollmentError { get; set; }
    
        /// <summary>
        /// Gets or sets lastConnectorConnectionTime.
        /// Last time certificate connector connected
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastConnectorConnectionTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastConnectorConnectionTime { get; set; }
    
        /// <summary>
        /// Gets or sets connectorVersion.
        /// Version of certificate connector
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectorVersion", Required = Newtonsoft.Json.Required.Default)]
        public string ConnectorVersion { get; set; }
    
        /// <summary>
        /// Gets or sets lastUploadVersion.
        /// Version of last uploaded certificate connector
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUploadVersion", Required = Newtonsoft.Json.Required.Default)]
        public Int64? LastUploadVersion { get; set; }
    
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
