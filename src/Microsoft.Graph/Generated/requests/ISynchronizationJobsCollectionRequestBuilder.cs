// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ISynchronizationJobsCollectionRequestBuilder.
    /// </summary>
    public partial interface ISynchronizationJobsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ISynchronizationJobsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ISynchronizationJobsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ISynchronizationJobRequestBuilder"/> for the specified SynchronizationJob.
        /// </summary>
        /// <param name="id">The ID for the SynchronizationJob.</param>
        /// <returns>The <see cref="ISynchronizationJobRequestBuilder"/>.</returns>
        ISynchronizationJobRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for SynchronizationJobValidateCredentials.
        /// </summary>
        /// <returns>The <see cref="ISynchronizationJobValidateCredentialsRequestBuilder"/>.</returns>
        ISynchronizationJobValidateCredentialsRequestBuilder ValidateCredentials(
            string applicationIdentifier = null,
            string templateId = null,
            bool? useSavedCredentials = null,
            IEnumerable<SynchronizationSecretKeyStringValuePair> credentials = null);
    }
}
