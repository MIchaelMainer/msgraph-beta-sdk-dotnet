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
    /// The type AndroidForWorkCertificateProfileBaseRequestBuilder.
    /// </summary>
    public partial class AndroidForWorkCertificateProfileBaseRequestBuilder : DeviceConfigurationRequestBuilder, IAndroidForWorkCertificateProfileBaseRequestBuilder
    {

        /// <summary>
        /// Constructs a new AndroidForWorkCertificateProfileBaseRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AndroidForWorkCertificateProfileBaseRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAndroidForWorkCertificateProfileBaseRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAndroidForWorkCertificateProfileBaseRequest Request(IEnumerable<Option> options)
        {
            return new AndroidForWorkCertificateProfileBaseRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for RootCertificate.
        /// </summary>
        /// <returns>The <see cref="IAndroidForWorkTrustedRootCertificateWithReferenceRequestBuilder"/>.</returns>
        public IAndroidForWorkTrustedRootCertificateWithReferenceRequestBuilder RootCertificate
        {
            get
            {
                return new AndroidForWorkTrustedRootCertificateWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("rootCertificate"), this.Client);
            }
        }
    
    }
}
