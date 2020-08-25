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
    /// The type AuthenticationEmailMethodsCollectionRequestBuilder.
    /// </summary>
    public partial class AuthenticationEmailMethodsCollectionRequestBuilder : BaseRequestBuilder, IAuthenticationEmailMethodsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AuthenticationEmailMethodsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AuthenticationEmailMethodsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAuthenticationEmailMethodsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAuthenticationEmailMethodsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AuthenticationEmailMethodsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEmailAuthenticationMethodRequestBuilder"/> for the specified AuthenticationEmailAuthenticationMethod.
        /// </summary>
        /// <param name="id">The ID for the AuthenticationEmailAuthenticationMethod.</param>
        /// <returns>The <see cref="IEmailAuthenticationMethodRequestBuilder"/>.</returns>
        public IEmailAuthenticationMethodRequestBuilder this[string id]
        {
            get
            {
                return new EmailAuthenticationMethodRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
