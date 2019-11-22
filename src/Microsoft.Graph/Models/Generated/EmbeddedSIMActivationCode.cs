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
    /// The type EmbeddedSIMActivationCode.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class EmbeddedSIMActivationCode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedSIMActivationCode"/> class.
        /// </summary>
        public EmbeddedSIMActivationCode()
        {
            this.ODataType = "microsoft.graph.embeddedSIMActivationCode";
        }

        /// <summary>
        /// Gets or sets integratedCircuitCardIdentifier.
        /// The input must match the following regular expression: '^[0-9]{19}[0-9]?$'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "integratedCircuitCardIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string IntegratedCircuitCardIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets matchingIdentifier.
        /// The input must match the following regular expression: '^[a-zA-Z0-9\-]*$'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "matchingIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string MatchingIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets smdpPlusServerAddress.
        /// The input must match the following regular expression: '^([a-zA-Z0-9]+(-[a-zA-Z0-9]+)*\.)+[a-zA-Z]{2,}$'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smdpPlusServerAddress", Required = Newtonsoft.Json.Required.Default)]
        public string SmdpPlusServerAddress { get; set; }
    
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
