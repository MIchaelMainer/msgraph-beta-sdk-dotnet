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
    /// The type DeviceManagementSettingStringLengthConstraint.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementSettingStringLengthConstraint : DeviceManagementConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementSettingStringLengthConstraint"/> class.
        /// </summary>
        public DeviceManagementSettingStringLengthConstraint()
        {
            this.ODataType = "microsoft.graph.deviceManagementSettingStringLengthConstraint";
        }

        /// <summary>
        /// Gets or sets minimumLength.
        /// The minimum permitted string length
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets maximumLength.
        /// The maximum permitted string length
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaximumLength { get; set; }
    
    }
}
