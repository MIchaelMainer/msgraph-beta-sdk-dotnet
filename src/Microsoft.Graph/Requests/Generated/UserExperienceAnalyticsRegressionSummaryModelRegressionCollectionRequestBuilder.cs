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
    /// The type UserExperienceAnalyticsRegressionSummaryModelRegressionCollectionRequestBuilder.
    /// </summary>
    public partial class UserExperienceAnalyticsRegressionSummaryModelRegressionCollectionRequestBuilder : BaseRequestBuilder, IUserExperienceAnalyticsRegressionSummaryModelRegressionCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserExperienceAnalyticsRegressionSummaryModelRegressionCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserExperienceAnalyticsRegressionSummaryModelRegressionCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserExperienceAnalyticsRegressionSummaryModelRegressionCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserExperienceAnalyticsRegressionSummaryModelRegressionCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserExperienceAnalyticsRegressionSummaryModelRegressionCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserExperienceAnalyticsMetricRequestBuilder"/> for the specified UserExperienceAnalyticsRegressionSummaryUserExperienceAnalyticsMetric.
        /// </summary>
        /// <param name="id">The ID for the UserExperienceAnalyticsRegressionSummaryUserExperienceAnalyticsMetric.</param>
        /// <returns>The <see cref="IUserExperienceAnalyticsMetricRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsMetricRequestBuilder this[string id]
        {
            get
            {
                return new UserExperienceAnalyticsMetricRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
