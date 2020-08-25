// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementDerivedCredentialSettingsWithReferenceRequestBuilder.
    /// </summary>
    public partial class DeviceManagementDerivedCredentialSettingsWithReferenceRequestBuilder : BaseRequestBuilder, IDeviceManagementDerivedCredentialSettingsWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceManagementDerivedCredentialSettingsWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementDerivedCredentialSettingsWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementDerivedCredentialSettingsWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementDerivedCredentialSettingsWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementDerivedCredentialSettingsWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the deviceManagementDerivedCredentialSettings.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementDerivedCredentialSettingsReferenceRequestBuilder"/>.</returns>
        public IDeviceManagementDerivedCredentialSettingsReferenceRequestBuilder Reference
        {
            get
            {
                return new DeviceManagementDerivedCredentialSettingsReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
