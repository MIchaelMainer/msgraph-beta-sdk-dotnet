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
    /// The type DataLossPreventionPolicyEvaluateRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DataLossPreventionPolicyEvaluateRequestBody
    {
    
        /// <summary>
        /// Gets or sets Target.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target", Required = Newtonsoft.Json.Required.Default)]
        public string Target { get; set; }
    
        /// <summary>
        /// Gets or sets EvaluationInput.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "evaluationInput", Required = Newtonsoft.Json.Required.Default)]
        public DlpEvaluationInput EvaluationInput { get; set; }
    
        /// <summary>
        /// Gets or sets NotificationInfo.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationInfo", Required = Newtonsoft.Json.Required.Default)]
        public DlpNotification NotificationInfo { get; set; }
    
    }
}
