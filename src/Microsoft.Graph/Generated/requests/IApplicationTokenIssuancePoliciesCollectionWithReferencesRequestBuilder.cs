// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IApplicationTokenIssuancePoliciesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IApplicationTokenIssuancePoliciesCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IApplicationTokenIssuancePoliciesCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IApplicationTokenIssuancePoliciesCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ITokenIssuancePolicyWithReferenceRequestBuilder"/> for the specified TokenIssuancePolicy.
        /// </summary>
        /// <param name="id">The ID for the TokenIssuancePolicy.</param>
        /// <returns>The <see cref="ITokenIssuancePolicyWithReferenceRequestBuilder"/>.</returns>
        ITokenIssuancePolicyWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IApplicationTokenIssuancePoliciesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IApplicationTokenIssuancePoliciesCollectionReferencesRequestBuilder"/>.</returns>
        IApplicationTokenIssuancePoliciesCollectionReferencesRequestBuilder References { get; }

    }
}
