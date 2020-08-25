// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SynchronizationSchemaParseExpressionRequestBuilder.
    /// </summary>
    public partial class SynchronizationSchemaParseExpressionRequestBuilder : BaseActionMethodRequestBuilder<ISynchronizationSchemaParseExpressionRequest>, ISynchronizationSchemaParseExpressionRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="SynchronizationSchemaParseExpressionRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="expression">A expression parameter for the OData method call.</param>
        /// <param name="testInputObject">A testInputObject parameter for the OData method call.</param>
        /// <param name="targetAttributeDefinition">A targetAttributeDefinition parameter for the OData method call.</param>
        public SynchronizationSchemaParseExpressionRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string expression,
            ExpressionInputObject testInputObject,
            AttributeDefinition targetAttributeDefinition)
            : base(requestUrl, client)
        {
            this.SetParameter("expression", expression, true);
            this.SetParameter("testInputObject", testInputObject, true);
            this.SetParameter("targetAttributeDefinition", targetAttributeDefinition, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ISynchronizationSchemaParseExpressionRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new SynchronizationSchemaParseExpressionRequest(functionUrl, this.Client, options);

            if (this.HasParameter("expression"))
            {
                request.RequestBody.Expression = this.GetParameter<string>("expression");
            }

            if (this.HasParameter("testInputObject"))
            {
                request.RequestBody.TestInputObject = this.GetParameter<ExpressionInputObject>("testInputObject");
            }

            if (this.HasParameter("targetAttributeDefinition"))
            {
                request.RequestBody.TargetAttributeDefinition = this.GetParameter<AttributeDefinition>("targetAttributeDefinition");
            }

            return request;
        }
    }
}
