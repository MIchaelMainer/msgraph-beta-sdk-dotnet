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
    /// The type ProfileWebAccountsCollectionRequestBuilder.
    /// </summary>
    public partial class ProfileWebAccountsCollectionRequestBuilder : BaseRequestBuilder, IProfileWebAccountsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ProfileWebAccountsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ProfileWebAccountsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IProfileWebAccountsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IProfileWebAccountsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ProfileWebAccountsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWebAccountRequestBuilder"/> for the specified ProfileWebAccount.
        /// </summary>
        /// <param name="id">The ID for the ProfileWebAccount.</param>
        /// <returns>The <see cref="IWebAccountRequestBuilder"/>.</returns>
        public IWebAccountRequestBuilder this[string id]
        {
            get
            {
                return new WebAccountRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
