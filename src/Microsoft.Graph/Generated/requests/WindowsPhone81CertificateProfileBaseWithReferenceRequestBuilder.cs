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
    /// The type WindowsPhone81CertificateProfileBaseWithReferenceRequestBuilder.
    /// </summary>
    public partial class WindowsPhone81CertificateProfileBaseWithReferenceRequestBuilder : BaseRequestBuilder, IWindowsPhone81CertificateProfileBaseWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsPhone81CertificateProfileBaseWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsPhone81CertificateProfileBaseWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsPhone81CertificateProfileBaseWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsPhone81CertificateProfileBaseWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new WindowsPhone81CertificateProfileBaseWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the windowsPhone81CertificateProfileBase.
        /// </summary>
        /// <returns>The <see cref="IWindowsPhone81CertificateProfileBaseReferenceRequestBuilder"/>.</returns>
        public IWindowsPhone81CertificateProfileBaseReferenceRequestBuilder Reference
        {
            get
            {
                return new WindowsPhone81CertificateProfileBaseReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
