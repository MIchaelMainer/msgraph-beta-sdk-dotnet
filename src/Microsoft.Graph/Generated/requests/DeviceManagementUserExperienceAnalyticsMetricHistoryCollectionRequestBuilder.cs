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
    /// The type DeviceManagementUserExperienceAnalyticsMetricHistoryCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementUserExperienceAnalyticsMetricHistoryCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementUserExperienceAnalyticsMetricHistoryCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementUserExperienceAnalyticsMetricHistoryCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementUserExperienceAnalyticsMetricHistoryCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsMetricHistoryCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsMetricHistoryCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementUserExperienceAnalyticsMetricHistoryCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserExperienceAnalyticsMetricHistoryRequestBuilder"/> for the specified DeviceManagementUserExperienceAnalyticsMetricHistory.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementUserExperienceAnalyticsMetricHistory.</param>
        /// <returns>The <see cref="IUserExperienceAnalyticsMetricHistoryRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsMetricHistoryRequestBuilder this[string id]
        {
            get
            {
                return new UserExperienceAnalyticsMetricHistoryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
