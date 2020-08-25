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
    /// The type DeviceManagementDeviceManagementPartnersCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementDeviceManagementPartnersCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementDeviceManagementPartnersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementDeviceManagementPartnersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementDeviceManagementPartnersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceManagementPartnersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceManagementPartnersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementDeviceManagementPartnersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceManagementPartnerRequestBuilder"/> for the specified DeviceManagementDeviceManagementPartner.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDeviceManagementPartner.</param>
        /// <returns>The <see cref="IDeviceManagementPartnerRequestBuilder"/>.</returns>
        public IDeviceManagementPartnerRequestBuilder this[string id]
        {
            get
            {
                return new DeviceManagementPartnerRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
