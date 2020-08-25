// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsWeekdayRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsWeekdayRequestBody
    {
    
        /// <summary>
        /// Gets or sets SerialNumber.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "serialNumber", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken SerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets ReturnType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "returnType", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken ReturnType { get; set; }
    
    }
}
