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
    /// The type Device Log Collection Response.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceLogCollectionResponse : Entity
    {
    
		///<summary>
		/// The DeviceLogCollectionResponse constructor
		///</summary>
        public DeviceLogCollectionResponse()
        {
            this.ODataType = "microsoft.graph.deviceLogCollectionResponse";
        }
	
        /// <summary>
        /// Gets or sets status.
        /// The status of the log collection request
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets managed device id.
        /// The device Id
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets error code.
        /// The error code, if any. Valid values -9.22337203685478E+18 to 9.22337203685478E+18
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCode", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets requested date time utc.
        /// The DateTime of the request
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestedDateTimeUTC", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? RequestedDateTimeUTC { get; set; }
    
        /// <summary>
        /// Gets or sets received date time utc.
        /// The DateTime the request was received
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "receivedDateTimeUTC", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ReceivedDateTimeUTC { get; set; }
    
        /// <summary>
        /// Gets or sets initiated by user principal name.
        /// The UPN for who initiated the request
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initiatedByUserPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string InitiatedByUserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time utc.
        /// The DateTime of the expiration of the logs
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTimeUTC", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTimeUTC { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// The size of the logs. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "size", Required = Newtonsoft.Json.Required.Default)]
        public double? Size { get; set; }
    
    }
}
