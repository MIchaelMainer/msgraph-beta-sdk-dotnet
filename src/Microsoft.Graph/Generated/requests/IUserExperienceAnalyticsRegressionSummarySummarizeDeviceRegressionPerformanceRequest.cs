// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IUserExperienceAnalyticsRegressionSummarySummarizeDeviceRegressionPerformanceRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsRegressionSummarySummarizeDeviceRegressionPerformanceRequest : IBaseRequest
    {


        /// <summary>
        /// Issues the GET request.
        /// </summary>
        System.Threading.Tasks.Task<UserExperienceAnalyticsRegressionSummary> GetAsync();

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsRegressionSummary> GetAsync(
            CancellationToken cancellationToken);



        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="userexperienceanalyticsregressionsummary">The UserExperienceAnalyticsRegressionSummary object set with the properties to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsRegressionSummary> PatchAsync(UserExperienceAnalyticsRegressionSummary userexperienceanalyticsregressionsummary);

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="userexperienceanalyticsregressionsummary">The UserExperienceAnalyticsRegressionSummary object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsRegressionSummary> PatchAsync(UserExperienceAnalyticsRegressionSummary userexperienceanalyticsregressionsummary, 
            CancellationToken cancellationToken);


        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="userexperienceanalyticsregressionsummary">The UserExperienceAnalyticsRegressionSummary object to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsRegressionSummary> PutAsync(UserExperienceAnalyticsRegressionSummary userexperienceanalyticsregressionsummary);

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="userexperienceanalyticsregressionsummary">The UserExperienceAnalyticsRegressionSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsRegressionSummary> PutAsync(UserExperienceAnalyticsRegressionSummary userexperienceanalyticsregressionsummary, 
            CancellationToken cancellationToken);




        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsRegressionSummarySummarizeDeviceRegressionPerformanceRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsRegressionSummarySummarizeDeviceRegressionPerformanceRequest Select(string value);
    }
}
