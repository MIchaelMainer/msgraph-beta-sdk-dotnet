// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type SalesOrderSalesOrderLinesCollectionRequestBuilder.
    /// </summary>
    public partial class SalesOrderSalesOrderLinesCollectionRequestBuilder : BaseRequestBuilder, ISalesOrderSalesOrderLinesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SalesOrderSalesOrderLinesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SalesOrderSalesOrderLinesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISalesOrderSalesOrderLinesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISalesOrderSalesOrderLinesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SalesOrderSalesOrderLinesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISalesOrderLineRequestBuilder"/> for the specified SalesOrderSalesOrderLine.
        /// </summary>
        /// <param name="id">The ID for the SalesOrderSalesOrderLine.</param>
        /// <returns>The <see cref="ISalesOrderLineRequestBuilder"/>.</returns>
        public ISalesOrderLineRequestBuilder this[string id]
        {
            get
            {
                return new SalesOrderLineRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
