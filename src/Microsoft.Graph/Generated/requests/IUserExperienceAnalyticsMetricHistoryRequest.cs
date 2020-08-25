// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IUserExperienceAnalyticsMetricHistoryRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsMetricHistoryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsMetricHistory using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsMetricHistoryToCreate">The UserExperienceAnalyticsMetricHistory to create.</param>
        /// <returns>The created UserExperienceAnalyticsMetricHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsMetricHistory> CreateAsync(UserExperienceAnalyticsMetricHistory userExperienceAnalyticsMetricHistoryToCreate);        /// <summary>
        /// Creates the specified UserExperienceAnalyticsMetricHistory using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsMetricHistoryToCreate">The UserExperienceAnalyticsMetricHistory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsMetricHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsMetricHistory> CreateAsync(UserExperienceAnalyticsMetricHistory userExperienceAnalyticsMetricHistoryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsMetricHistory.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsMetricHistory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsMetricHistory.
        /// </summary>
        /// <returns>The UserExperienceAnalyticsMetricHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsMetricHistory> GetAsync();

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsMetricHistory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsMetricHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsMetricHistory> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsMetricHistory using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsMetricHistoryToUpdate">The UserExperienceAnalyticsMetricHistory to update.</param>
        /// <returns>The updated UserExperienceAnalyticsMetricHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsMetricHistory> UpdateAsync(UserExperienceAnalyticsMetricHistory userExperienceAnalyticsMetricHistoryToUpdate);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsMetricHistory using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsMetricHistoryToUpdate">The UserExperienceAnalyticsMetricHistory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsMetricHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsMetricHistory> UpdateAsync(UserExperienceAnalyticsMetricHistory userExperienceAnalyticsMetricHistoryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsMetricHistoryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsMetricHistoryRequest Expand(Expression<Func<UserExperienceAnalyticsMetricHistory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsMetricHistoryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsMetricHistoryRequest Select(Expression<Func<UserExperienceAnalyticsMetricHistory, object>> selectExpression);

    }
}
