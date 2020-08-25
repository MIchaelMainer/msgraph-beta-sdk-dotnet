// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ApplePushNotificationCertificateRequestBuilder.
    /// </summary>
    public partial class ApplePushNotificationCertificateRequestBuilder : EntityRequestBuilder, IApplePushNotificationCertificateRequestBuilder
    {

        /// <summary>
        /// Constructs a new ApplePushNotificationCertificateRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ApplePushNotificationCertificateRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IApplePushNotificationCertificateRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IApplePushNotificationCertificateRequest Request(IEnumerable<Option> options)
        {
            return new ApplePushNotificationCertificateRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ApplePushNotificationCertificateGenerateApplePushNotificationCertificateSigningRequest.
        /// </summary>
        /// <returns>The <see cref="IApplePushNotificationCertificateGenerateApplePushNotificationCertificateSigningRequestRequestBuilder"/>.</returns>
        public IApplePushNotificationCertificateGenerateApplePushNotificationCertificateSigningRequestRequestBuilder GenerateApplePushNotificationCertificateSigningRequest()
        {
            return new ApplePushNotificationCertificateGenerateApplePushNotificationCertificateSigningRequestRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.generateApplePushNotificationCertificateSigningRequest"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ApplePushNotificationCertificateDownloadApplePushNotificationCertificateSigningRequest.
        /// </summary>
        /// <returns>The <see cref="IApplePushNotificationCertificateDownloadApplePushNotificationCertificateSigningRequestRequestBuilder"/>.</returns>
        public IApplePushNotificationCertificateDownloadApplePushNotificationCertificateSigningRequestRequestBuilder DownloadApplePushNotificationCertificateSigningRequest()
        {
            return new ApplePushNotificationCertificateDownloadApplePushNotificationCertificateSigningRequestRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.downloadApplePushNotificationCertificateSigningRequest"),
                this.Client);
        }
    
    }
}
