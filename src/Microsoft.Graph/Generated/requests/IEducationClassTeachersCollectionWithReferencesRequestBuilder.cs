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
    /// The interface IEducationClassTeachersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IEducationClassTeachersCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IEducationClassTeachersCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IEducationClassTeachersCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IEducationUserWithReferenceRequestBuilder"/> for the specified EducationUser.
        /// </summary>
        /// <param name="id">The ID for the EducationUser.</param>
        /// <returns>The <see cref="IEducationUserWithReferenceRequestBuilder"/>.</returns>
        IEducationUserWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IEducationClassTeachersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IEducationClassTeachersCollectionReferencesRequestBuilder"/>.</returns>
        IEducationClassTeachersCollectionReferencesRequestBuilder References { get; }

    }
}