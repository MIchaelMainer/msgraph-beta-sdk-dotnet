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
    /// The type WindowsInformationProtectionDeviceRegistrationWithReferenceRequestBuilder.
    /// </summary>
    public partial class WindowsInformationProtectionDeviceRegistrationWithReferenceRequestBuilder : BaseRequestBuilder, IWindowsInformationProtectionDeviceRegistrationWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsInformationProtectionDeviceRegistrationWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsInformationProtectionDeviceRegistrationWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsInformationProtectionDeviceRegistrationWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsInformationProtectionDeviceRegistrationWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new WindowsInformationProtectionDeviceRegistrationWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the windowsInformationProtectionDeviceRegistration.
        /// </summary>
        /// <returns>The <see cref="IWindowsInformationProtectionDeviceRegistrationReferenceRequestBuilder"/>.</returns>
        public IWindowsInformationProtectionDeviceRegistrationReferenceRequestBuilder Reference
        {
            get
            {
                return new WindowsInformationProtectionDeviceRegistrationReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
