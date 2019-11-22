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
    /// The interface IConditionalAccessRootRequest.
    /// </summary>
    public partial interface IConditionalAccessRootRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ConditionalAccessRoot using POST.
        /// </summary>
        /// <param name="conditionalAccessRootToCreate">The ConditionalAccessRoot to create.</param>
        /// <returns>The created ConditionalAccessRoot.</returns>
        System.Threading.Tasks.Task<ConditionalAccessRoot> CreateAsync(ConditionalAccessRoot conditionalAccessRootToCreate);        /// <summary>
        /// Creates the specified ConditionalAccessRoot using POST.
        /// </summary>
        /// <param name="conditionalAccessRootToCreate">The ConditionalAccessRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConditionalAccessRoot.</returns>
        System.Threading.Tasks.Task<ConditionalAccessRoot> CreateAsync(ConditionalAccessRoot conditionalAccessRootToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ConditionalAccessRoot.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ConditionalAccessRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ConditionalAccessRoot.
        /// </summary>
        /// <returns>The ConditionalAccessRoot.</returns>
        System.Threading.Tasks.Task<ConditionalAccessRoot> GetAsync();

        /// <summary>
        /// Gets the specified ConditionalAccessRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConditionalAccessRoot.</returns>
        System.Threading.Tasks.Task<ConditionalAccessRoot> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ConditionalAccessRoot using PATCH.
        /// </summary>
        /// <param name="conditionalAccessRootToUpdate">The ConditionalAccessRoot to update.</param>
        /// <returns>The updated ConditionalAccessRoot.</returns>
        System.Threading.Tasks.Task<ConditionalAccessRoot> UpdateAsync(ConditionalAccessRoot conditionalAccessRootToUpdate);

        /// <summary>
        /// Updates the specified ConditionalAccessRoot using PATCH.
        /// </summary>
        /// <param name="conditionalAccessRootToUpdate">The ConditionalAccessRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConditionalAccessRoot.</returns>
        System.Threading.Tasks.Task<ConditionalAccessRoot> UpdateAsync(ConditionalAccessRoot conditionalAccessRootToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessRootRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessRootRequest Expand(Expression<Func<ConditionalAccessRoot, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessRootRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessRootRequest Select(Expression<Func<ConditionalAccessRoot, object>> selectExpression);

    }
}
