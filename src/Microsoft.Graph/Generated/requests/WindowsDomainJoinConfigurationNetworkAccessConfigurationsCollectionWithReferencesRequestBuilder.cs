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
    /// The type WindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class WindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IWindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new WindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceConfigurationWithReferenceRequestBuilder"/> for the specified WindowsDomainJoinConfigurationDeviceConfiguration.
        /// </summary>
        /// <param name="id">The ID for the WindowsDomainJoinConfigurationDeviceConfiguration.</param>
        /// <returns>The <see cref="IDeviceConfigurationWithReferenceRequestBuilder"/>.</returns>
        public IDeviceConfigurationWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new DeviceConfigurationWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IWindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IWindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionReferencesRequestBuilder"/>.</returns>
        public IWindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new WindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
