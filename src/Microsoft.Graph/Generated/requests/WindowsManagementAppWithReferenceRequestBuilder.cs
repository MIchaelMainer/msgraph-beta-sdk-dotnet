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
    /// The type WindowsManagementAppWithReferenceRequestBuilder.
    /// </summary>
    public partial class WindowsManagementAppWithReferenceRequestBuilder : BaseRequestBuilder, IWindowsManagementAppWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsManagementAppWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsManagementAppWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsManagementAppWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsManagementAppWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new WindowsManagementAppWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the windowsManagementApp.
        /// </summary>
        /// <returns>The <see cref="IWindowsManagementAppReferenceRequestBuilder"/>.</returns>
        public IWindowsManagementAppReferenceRequestBuilder Reference
        {
            get
            {
                return new WindowsManagementAppReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
