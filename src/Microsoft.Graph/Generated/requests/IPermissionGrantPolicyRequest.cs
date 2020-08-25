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
    /// The interface IPermissionGrantPolicyRequest.
    /// </summary>
    public partial interface IPermissionGrantPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PermissionGrantPolicy using POST.
        /// </summary>
        /// <param name="permissionGrantPolicyToCreate">The PermissionGrantPolicy to create.</param>
        /// <returns>The created PermissionGrantPolicy.</returns>
        System.Threading.Tasks.Task<PermissionGrantPolicy> CreateAsync(PermissionGrantPolicy permissionGrantPolicyToCreate);        /// <summary>
        /// Creates the specified PermissionGrantPolicy using POST.
        /// </summary>
        /// <param name="permissionGrantPolicyToCreate">The PermissionGrantPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PermissionGrantPolicy.</returns>
        System.Threading.Tasks.Task<PermissionGrantPolicy> CreateAsync(PermissionGrantPolicy permissionGrantPolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PermissionGrantPolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PermissionGrantPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PermissionGrantPolicy.
        /// </summary>
        /// <returns>The PermissionGrantPolicy.</returns>
        System.Threading.Tasks.Task<PermissionGrantPolicy> GetAsync();

        /// <summary>
        /// Gets the specified PermissionGrantPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PermissionGrantPolicy.</returns>
        System.Threading.Tasks.Task<PermissionGrantPolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PermissionGrantPolicy using PATCH.
        /// </summary>
        /// <param name="permissionGrantPolicyToUpdate">The PermissionGrantPolicy to update.</param>
        /// <returns>The updated PermissionGrantPolicy.</returns>
        System.Threading.Tasks.Task<PermissionGrantPolicy> UpdateAsync(PermissionGrantPolicy permissionGrantPolicyToUpdate);

        /// <summary>
        /// Updates the specified PermissionGrantPolicy using PATCH.
        /// </summary>
        /// <param name="permissionGrantPolicyToUpdate">The PermissionGrantPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PermissionGrantPolicy.</returns>
        System.Threading.Tasks.Task<PermissionGrantPolicy> UpdateAsync(PermissionGrantPolicy permissionGrantPolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPermissionGrantPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPermissionGrantPolicyRequest Expand(Expression<Func<PermissionGrantPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPermissionGrantPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPermissionGrantPolicyRequest Select(Expression<Func<PermissionGrantPolicy, object>> selectExpression);

    }
}
