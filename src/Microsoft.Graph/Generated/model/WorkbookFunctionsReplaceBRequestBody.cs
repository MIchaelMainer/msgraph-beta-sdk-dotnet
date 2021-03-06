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
    /// The type WorkbookFunctionsReplaceBRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsReplaceBRequestBody
    {
    
        /// <summary>
        /// Gets or sets OldText.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oldText", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken OldText { get; set; }
    
        /// <summary>
        /// Gets or sets StartNum.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startNum", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken StartNum { get; set; }
    
        /// <summary>
        /// Gets or sets NumBytes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "numBytes", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken NumBytes { get; set; }
    
        /// <summary>
        /// Gets or sets NewText.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "newText", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken NewText { get; set; }
    
    }
}
