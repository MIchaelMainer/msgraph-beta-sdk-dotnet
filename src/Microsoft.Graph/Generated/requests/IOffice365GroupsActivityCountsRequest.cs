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
    /// The interface IOffice365GroupsActivityCountsRequest.
    /// </summary>
    public partial interface IOffice365GroupsActivityCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Office365GroupsActivityCounts using POST.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToCreate">The Office365GroupsActivityCounts to create.</param>
        /// <returns>The created Office365GroupsActivityCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityCounts> CreateAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToCreate);        /// <summary>
        /// Creates the specified Office365GroupsActivityCounts using POST.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToCreate">The Office365GroupsActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Office365GroupsActivityCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityCounts> CreateAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Office365GroupsActivityCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Office365GroupsActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Office365GroupsActivityCounts.
        /// </summary>
        /// <returns>The Office365GroupsActivityCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityCounts> GetAsync();

        /// <summary>
        /// Gets the specified Office365GroupsActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Office365GroupsActivityCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Office365GroupsActivityCounts using PATCH.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToUpdate">The Office365GroupsActivityCounts to update.</param>
        /// <returns>The updated Office365GroupsActivityCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityCounts> UpdateAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToUpdate);

        /// <summary>
        /// Updates the specified Office365GroupsActivityCounts using PATCH.
        /// </summary>
        /// <param name="office365GroupsActivityCountsToUpdate">The Office365GroupsActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Office365GroupsActivityCounts.</returns>
        System.Threading.Tasks.Task<Office365GroupsActivityCounts> UpdateAsync(Office365GroupsActivityCounts office365GroupsActivityCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365GroupsActivityCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365GroupsActivityCountsRequest Expand(Expression<Func<Office365GroupsActivityCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365GroupsActivityCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365GroupsActivityCountsRequest Select(Expression<Func<Office365GroupsActivityCounts, object>> selectExpression);

    }
}
