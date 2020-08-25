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
    /// The interface IAuthenticationFlowsPolicyRequest.
    /// </summary>
    public partial interface IAuthenticationFlowsPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AuthenticationFlowsPolicy using POST.
        /// </summary>
        /// <param name="authenticationFlowsPolicyToCreate">The AuthenticationFlowsPolicy to create.</param>
        /// <returns>The created AuthenticationFlowsPolicy.</returns>
        System.Threading.Tasks.Task<AuthenticationFlowsPolicy> CreateAsync(AuthenticationFlowsPolicy authenticationFlowsPolicyToCreate);        /// <summary>
        /// Creates the specified AuthenticationFlowsPolicy using POST.
        /// </summary>
        /// <param name="authenticationFlowsPolicyToCreate">The AuthenticationFlowsPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuthenticationFlowsPolicy.</returns>
        System.Threading.Tasks.Task<AuthenticationFlowsPolicy> CreateAsync(AuthenticationFlowsPolicy authenticationFlowsPolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AuthenticationFlowsPolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AuthenticationFlowsPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AuthenticationFlowsPolicy.
        /// </summary>
        /// <returns>The AuthenticationFlowsPolicy.</returns>
        System.Threading.Tasks.Task<AuthenticationFlowsPolicy> GetAsync();

        /// <summary>
        /// Gets the specified AuthenticationFlowsPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuthenticationFlowsPolicy.</returns>
        System.Threading.Tasks.Task<AuthenticationFlowsPolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AuthenticationFlowsPolicy using PATCH.
        /// </summary>
        /// <param name="authenticationFlowsPolicyToUpdate">The AuthenticationFlowsPolicy to update.</param>
        /// <returns>The updated AuthenticationFlowsPolicy.</returns>
        System.Threading.Tasks.Task<AuthenticationFlowsPolicy> UpdateAsync(AuthenticationFlowsPolicy authenticationFlowsPolicyToUpdate);

        /// <summary>
        /// Updates the specified AuthenticationFlowsPolicy using PATCH.
        /// </summary>
        /// <param name="authenticationFlowsPolicyToUpdate">The AuthenticationFlowsPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AuthenticationFlowsPolicy.</returns>
        System.Threading.Tasks.Task<AuthenticationFlowsPolicy> UpdateAsync(AuthenticationFlowsPolicy authenticationFlowsPolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFlowsPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFlowsPolicyRequest Expand(Expression<Func<AuthenticationFlowsPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFlowsPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFlowsPolicyRequest Select(Expression<Func<AuthenticationFlowsPolicy, object>> selectExpression);

    }
}
