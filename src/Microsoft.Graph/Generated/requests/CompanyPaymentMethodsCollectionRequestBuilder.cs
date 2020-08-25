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
    /// The type CompanyPaymentMethodsCollectionRequestBuilder.
    /// </summary>
    public partial class CompanyPaymentMethodsCollectionRequestBuilder : BaseRequestBuilder, ICompanyPaymentMethodsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CompanyPaymentMethodsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CompanyPaymentMethodsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICompanyPaymentMethodsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICompanyPaymentMethodsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CompanyPaymentMethodsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPaymentMethodRequestBuilder"/> for the specified CompanyPaymentMethod.
        /// </summary>
        /// <param name="id">The ID for the CompanyPaymentMethod.</param>
        /// <returns>The <see cref="IPaymentMethodRequestBuilder"/>.</returns>
        public IPaymentMethodRequestBuilder this[string id]
        {
            get
            {
                return new PaymentMethodRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
