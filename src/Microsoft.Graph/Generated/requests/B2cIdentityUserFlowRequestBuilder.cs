// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type B2cIdentityUserFlowRequestBuilder.
    /// </summary>
    public partial class B2cIdentityUserFlowRequestBuilder : IdentityUserFlowRequestBuilder, IB2cIdentityUserFlowRequestBuilder
    {

        /// <summary>
        /// Constructs a new B2cIdentityUserFlowRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public B2cIdentityUserFlowRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IB2cIdentityUserFlowRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IB2cIdentityUserFlowRequest Request(IEnumerable<Option> options)
        {
            return new B2cIdentityUserFlowRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for IdentityProviders.
        /// </summary>
        /// <returns>The <see cref="IB2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder"/>.</returns>
        public IB2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder IdentityProviders
        {
            get
            {
                return new B2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("identityProviders"), this.Client);
            }
        }
    
    }
}
