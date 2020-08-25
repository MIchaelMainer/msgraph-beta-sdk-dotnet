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
    /// The type DeviceManagementSettingEnrollmentTypeConstraint.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementSettingEnrollmentTypeConstraint : DeviceManagementConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementSettingEnrollmentTypeConstraint"/> class.
        /// </summary>
        public DeviceManagementSettingEnrollmentTypeConstraint()
        {
            this.ODataType = "microsoft.graph.deviceManagementSettingEnrollmentTypeConstraint";
        }

        /// <summary>
        /// Gets or sets enrollmentTypes.
        /// List of enrollment types
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> EnrollmentTypes { get; set; }
    
    }
}
