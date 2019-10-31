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
    /// The type ReportRootUserCredentialUsageDetailsCollectionRequestBuilder.
    /// </summary>
    public partial class ReportRootUserCredentialUsageDetailsCollectionRequestBuilder : BaseRequestBuilder, IReportRootUserCredentialUsageDetailsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ReportRootUserCredentialUsageDetailsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ReportRootUserCredentialUsageDetailsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IReportRootUserCredentialUsageDetailsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IReportRootUserCredentialUsageDetailsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ReportRootUserCredentialUsageDetailsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserCredentialUsageDetailsRequestBuilder"/> for the specified ReportRootUserCredentialUsageDetails.
        /// </summary>
        /// <param name="id">The ID for the ReportRootUserCredentialUsageDetails.</param>
        /// <returns>The <see cref="IUserCredentialUsageDetailsRequestBuilder"/>.</returns>
        public IUserCredentialUsageDetailsRequestBuilder this[string id]
        {
            get
            {
                return new UserCredentialUsageDetailsRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}