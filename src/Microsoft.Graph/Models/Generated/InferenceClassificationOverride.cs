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
    /// The type Inference Classification Override.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class InferenceClassificationOverride : Entity
    {
    
		///<summary>
		/// The InferenceClassificationOverride constructor
		///</summary>
        public InferenceClassificationOverride()
        {
            this.ODataType = "microsoft.graph.inferenceClassificationOverride";
        }
	
        /// <summary>
        /// Gets or sets classify as.
        /// Specifies how incoming messages from a specific sender should always be classified as. The possible values are: focused, other.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classifyAs", Required = Newtonsoft.Json.Required.Default)]
        public InferenceClassificationType? ClassifyAs { get; set; }
    
        /// <summary>
        /// Gets or sets sender email address.
        /// The email address information of the sender for whom the override is created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "senderEmailAddress", Required = Newtonsoft.Json.Required.Default)]
        public EmailAddress SenderEmailAddress { get; set; }
    
    }
}

