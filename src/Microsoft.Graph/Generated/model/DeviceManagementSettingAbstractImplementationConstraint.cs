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
    /// The type DeviceManagementSettingAbstractImplementationConstraint.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementSettingAbstractImplementationConstraint : DeviceManagementConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementSettingAbstractImplementationConstraint"/> class.
        /// </summary>
        public DeviceManagementSettingAbstractImplementationConstraint()
        {
            this.ODataType = "microsoft.graph.deviceManagementSettingAbstractImplementationConstraint";
        }

        /// <summary>
        /// Gets or sets allowedAbstractImplementationDefinitionIds.
        /// List of value which means not configured for the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedAbstractImplementationDefinitionIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AllowedAbstractImplementationDefinitionIds { get; set; }
    
    }
}
