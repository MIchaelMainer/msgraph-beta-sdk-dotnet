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
    /// The type AndroidPermissionAction.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AndroidPermissionAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidPermissionAction"/> class.
        /// </summary>
        public AndroidPermissionAction()
        {
            this.ODataType = "microsoft.graph.androidPermissionAction";
        }

        /// <summary>
        /// Gets or sets permission.
        /// Android permission string, defined in the official Android documentation.  Example 'android.permission.READ_CONTACTS'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "permission", Required = Newtonsoft.Json.Required.Default)]
        public string Permission { get; set; }
    
        /// <summary>
        /// Gets or sets action.
        /// Type of Android permission action.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action", Required = Newtonsoft.Json.Required.Default)]
        public AndroidPermissionActionType? Action { get; set; }
    
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
