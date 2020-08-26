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
    /// The type ManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedDeviceDetectedAppsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedDeviceDetectedAppsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ManagedDeviceDetectedAppsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDetectedAppWithReferenceRequestBuilder"/> for the specified ManagedDeviceDetectedApp.
        /// </summary>
        /// <param name="id">The ID for the ManagedDeviceDetectedApp.</param>
        /// <returns>The <see cref="IDetectedAppWithReferenceRequestBuilder"/>.</returns>
        public IDetectedAppWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new DetectedAppWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IManagedDeviceDetectedAppsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDetectedAppsCollectionReferencesRequestBuilder"/>.</returns>
        public IManagedDeviceDetectedAppsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ManagedDeviceDetectedAppsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}