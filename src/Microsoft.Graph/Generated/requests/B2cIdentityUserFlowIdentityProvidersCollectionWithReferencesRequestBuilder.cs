// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type B2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class B2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IB2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new B2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public B2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IB2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IB2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new B2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IIdentityProviderWithReferenceRequestBuilder"/> for the specified B2cIdentityUserFlowIdentityProvider.
        /// </summary>
        /// <param name="id">The ID for the B2cIdentityUserFlowIdentityProvider.</param>
        /// <returns>The <see cref="IIdentityProviderWithReferenceRequestBuilder"/>.</returns>
        public IIdentityProviderWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new IdentityProviderWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IB2cIdentityUserFlowIdentityProvidersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IB2cIdentityUserFlowIdentityProvidersCollectionReferencesRequestBuilder"/>.</returns>
        public IB2cIdentityUserFlowIdentityProvidersCollectionReferencesRequestBuilder References
        {
            get
            {
                return new B2cIdentityUserFlowIdentityProvidersCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
