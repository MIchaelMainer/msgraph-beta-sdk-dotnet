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
    /// The type DepOnboardingSettingEnrollmentProfilesCollectionRequestBuilder.
    /// </summary>
    public partial class DepOnboardingSettingEnrollmentProfilesCollectionRequestBuilder : BaseRequestBuilder, IDepOnboardingSettingEnrollmentProfilesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DepOnboardingSettingEnrollmentProfilesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DepOnboardingSettingEnrollmentProfilesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDepOnboardingSettingEnrollmentProfilesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDepOnboardingSettingEnrollmentProfilesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DepOnboardingSettingEnrollmentProfilesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEnrollmentProfileRequestBuilder"/> for the specified DepOnboardingSettingEnrollmentProfile.
        /// </summary>
        /// <param name="id">The ID for the DepOnboardingSettingEnrollmentProfile.</param>
        /// <returns>The <see cref="IEnrollmentProfileRequestBuilder"/>.</returns>
        public IEnrollmentProfileRequestBuilder this[string id]
        {
            get
            {
                return new EnrollmentProfileRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
