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
    /// The interface IGroupPolicyCategoryChildrenCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IGroupPolicyCategoryChildrenCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGroupPolicyCategoryChildrenCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGroupPolicyCategoryChildrenCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IGroupPolicyCategoryWithReferenceRequestBuilder"/> for the specified GroupPolicyCategory.
        /// </summary>
        /// <param name="id">The ID for the GroupPolicyCategory.</param>
        /// <returns>The <see cref="IGroupPolicyCategoryWithReferenceRequestBuilder"/>.</returns>
        IGroupPolicyCategoryWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IGroupPolicyCategoryChildrenCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyCategoryChildrenCollectionReferencesRequestBuilder"/>.</returns>
        IGroupPolicyCategoryChildrenCollectionReferencesRequestBuilder References { get; }

    }
}
