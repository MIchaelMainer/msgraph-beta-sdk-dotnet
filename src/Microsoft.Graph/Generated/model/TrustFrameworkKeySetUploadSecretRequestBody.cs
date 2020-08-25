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
    /// The type TrustFrameworkKeySetUploadSecretRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TrustFrameworkKeySetUploadSecretRequestBody
    {
    
        /// <summary>
        /// Gets or sets Use.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "use", Required = Newtonsoft.Json.Required.Default)]
        public string Use { get; set; }
    
        /// <summary>
        /// Gets or sets K.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "k", Required = Newtonsoft.Json.Required.Default)]
        public string K { get; set; }
    
        /// <summary>
        /// Gets or sets Nbf.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nbf", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Nbf { get; set; }
    
        /// <summary>
        /// Gets or sets Exp.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exp", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Exp { get; set; }
    
    }
}
