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
    /// The type UnaryManagementConditionExpression.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UnaryManagementConditionExpression : ManagementConditionExpressionModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnaryManagementConditionExpression"/> class.
        /// </summary>
        public UnaryManagementConditionExpression()
        {
            this.ODataType = "microsoft.graph.unaryManagementConditionExpression";
        }

        /// <summary>
        /// Gets or sets operator.
        /// The operator used in the evaluation of the unary operation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operator", Required = Newtonsoft.Json.Required.Default)]
        public UnaryManagementConditionExpressionOperatorType? Operator { get; set; }
    
        /// <summary>
        /// Gets or sets operand.
        /// The operand of the unary operation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operand", Required = Newtonsoft.Json.Required.Default)]
        public ManagementConditionExpressionModel Operand { get; set; }
    
    }
}
