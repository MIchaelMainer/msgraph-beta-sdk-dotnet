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
    /// The type Device Management Abstract Complex Setting Instance.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementAbstractComplexSettingInstance : DeviceManagementSettingInstance
    {
    
		///<summary>
		/// The DeviceManagementAbstractComplexSettingInstance constructor
		///</summary>
        public DeviceManagementAbstractComplexSettingInstance()
        {
            this.ODataType = "microsoft.graph.deviceManagementAbstractComplexSettingInstance";
        }
	
        /// <summary>
        /// Gets or sets implementation id.
        /// The definition ID for the chosen implementation of this complex setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "implementationId", Required = Newtonsoft.Json.Required.Default)]
        public string ImplementationId { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// The values that make up the complex setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementAbstractComplexSettingInstanceValueCollectionPage Value { get; set; }
    
    }
}

