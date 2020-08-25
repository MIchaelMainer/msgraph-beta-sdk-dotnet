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
    /// The type Device Management Collection Setting Definition.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementCollectionSettingDefinition : DeviceManagementSettingDefinition
    {
    
		///<summary>
		/// The DeviceManagementCollectionSettingDefinition constructor
		///</summary>
        public DeviceManagementCollectionSettingDefinition()
        {
            this.ODataType = "microsoft.graph.deviceManagementCollectionSettingDefinition";
        }
	
        /// <summary>
        /// Gets or sets element definition id.
        /// The Setting Definition ID that describes what each element of the collection looks like
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "elementDefinitionId", Required = Newtonsoft.Json.Required.Default)]
        public string ElementDefinitionId { get; set; }
    
    }
}

