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
    /// The type AgreementAcceptancesCollectionRequestBuilder.
    /// </summary>
    public partial class AgreementAcceptancesCollectionRequestBuilder : BaseRequestBuilder, IAgreementAcceptancesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AgreementAcceptancesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AgreementAcceptancesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAgreementAcceptancesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAgreementAcceptancesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AgreementAcceptancesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAgreementAcceptanceRequestBuilder"/> for the specified AgreementAgreementAcceptance.
        /// </summary>
        /// <param name="id">The ID for the AgreementAgreementAcceptance.</param>
        /// <returns>The <see cref="IAgreementAcceptanceRequestBuilder"/>.</returns>
        public IAgreementAcceptanceRequestBuilder this[string id]
        {
            get
            {
                return new AgreementAcceptanceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
