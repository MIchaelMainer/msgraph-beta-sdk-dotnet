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
    /// The type Group Policy Presentation Long Decimal Text Box.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupPolicyPresentationLongDecimalTextBox : GroupPolicyPresentation
    {
    
		///<summary>
		/// The GroupPolicyPresentationLongDecimalTextBox constructor
		///</summary>
        public GroupPolicyPresentationLongDecimalTextBox()
        {
            this.ODataType = "microsoft.graph.groupPolicyPresentationLongDecimalTextBox";
        }
	
        /// <summary>
        /// Gets or sets default value.
        /// An unsigned integer that specifies the initial value for the decimal text box. The default value is 1.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultValue", Required = Newtonsoft.Json.Required.Default)]
        public Int64? DefaultValue { get; set; }
    
        /// <summary>
        /// Gets or sets spin.
        /// If true, create a spin control; otherwise, create a text box for numeric entry. The default value is true.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "spin", Required = Newtonsoft.Json.Required.Default)]
        public bool? Spin { get; set; }
    
        /// <summary>
        /// Gets or sets spin step.
        /// An unsigned integer that specifies the increment of change for the spin control. The default value is 1.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "spinStep", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SpinStep { get; set; }
    
        /// <summary>
        /// Gets or sets required.
        /// Requirement to enter a value in the parameter box. The default value is false.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "required", Required = Newtonsoft.Json.Required.Default)]
        public bool? Required { get; set; }
    
        /// <summary>
        /// Gets or sets min value.
        /// An unsigned long that specifies the minimum allowed value. The default value is 0.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minValue", Required = Newtonsoft.Json.Required.Default)]
        public Int64? MinValue { get; set; }
    
        /// <summary>
        /// Gets or sets max value.
        /// An unsigned long that specifies the maximum allowed value. The default value is 9999.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxValue", Required = Newtonsoft.Json.Required.Default)]
        public Int64? MaxValue { get; set; }
    
    }
}

