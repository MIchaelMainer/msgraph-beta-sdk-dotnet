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
    /// The type CompanyDimensionValuesCollectionRequestBuilder.
    /// </summary>
    public partial class CompanyDimensionValuesCollectionRequestBuilder : BaseRequestBuilder, ICompanyDimensionValuesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CompanyDimensionValuesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CompanyDimensionValuesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICompanyDimensionValuesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICompanyDimensionValuesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CompanyDimensionValuesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDimensionValueRequestBuilder"/> for the specified CompanyDimensionValue.
        /// </summary>
        /// <param name="id">The ID for the CompanyDimensionValue.</param>
        /// <returns>The <see cref="IDimensionValueRequestBuilder"/>.</returns>
        public IDimensionValueRequestBuilder this[string id]
        {
            get
            {
                return new DimensionValueRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
