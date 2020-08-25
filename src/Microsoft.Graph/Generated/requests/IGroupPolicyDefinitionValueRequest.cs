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
    /// The interface IGroupPolicyDefinitionValueRequest.
    /// </summary>
    public partial interface IGroupPolicyDefinitionValueRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupPolicyDefinitionValue using POST.
        /// </summary>
        /// <param name="groupPolicyDefinitionValueToCreate">The GroupPolicyDefinitionValue to create.</param>
        /// <returns>The created GroupPolicyDefinitionValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyDefinitionValue> CreateAsync(GroupPolicyDefinitionValue groupPolicyDefinitionValueToCreate);        /// <summary>
        /// Creates the specified GroupPolicyDefinitionValue using POST.
        /// </summary>
        /// <param name="groupPolicyDefinitionValueToCreate">The GroupPolicyDefinitionValue to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyDefinitionValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyDefinitionValue> CreateAsync(GroupPolicyDefinitionValue groupPolicyDefinitionValueToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GroupPolicyDefinitionValue.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyDefinitionValue.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GroupPolicyDefinitionValue.
        /// </summary>
        /// <returns>The GroupPolicyDefinitionValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyDefinitionValue> GetAsync();

        /// <summary>
        /// Gets the specified GroupPolicyDefinitionValue.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyDefinitionValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyDefinitionValue> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GroupPolicyDefinitionValue using PATCH.
        /// </summary>
        /// <param name="groupPolicyDefinitionValueToUpdate">The GroupPolicyDefinitionValue to update.</param>
        /// <returns>The updated GroupPolicyDefinitionValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyDefinitionValue> UpdateAsync(GroupPolicyDefinitionValue groupPolicyDefinitionValueToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyDefinitionValue using PATCH.
        /// </summary>
        /// <param name="groupPolicyDefinitionValueToUpdate">The GroupPolicyDefinitionValue to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyDefinitionValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyDefinitionValue> UpdateAsync(GroupPolicyDefinitionValue groupPolicyDefinitionValueToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyDefinitionValueRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyDefinitionValueRequest Expand(Expression<Func<GroupPolicyDefinitionValue, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyDefinitionValueRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyDefinitionValueRequest Select(Expression<Func<GroupPolicyDefinitionValue, object>> selectExpression);

    }
}
