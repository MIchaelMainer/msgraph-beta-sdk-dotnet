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
    /// The interface ISecurityQuestionAuthenticationMethodRequest.
    /// </summary>
    public partial interface ISecurityQuestionAuthenticationMethodRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SecurityQuestionAuthenticationMethod using POST.
        /// </summary>
        /// <param name="securityQuestionAuthenticationMethodToCreate">The SecurityQuestionAuthenticationMethod to create.</param>
        /// <returns>The created SecurityQuestionAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<SecurityQuestionAuthenticationMethod> CreateAsync(SecurityQuestionAuthenticationMethod securityQuestionAuthenticationMethodToCreate);        /// <summary>
        /// Creates the specified SecurityQuestionAuthenticationMethod using POST.
        /// </summary>
        /// <param name="securityQuestionAuthenticationMethodToCreate">The SecurityQuestionAuthenticationMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecurityQuestionAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<SecurityQuestionAuthenticationMethod> CreateAsync(SecurityQuestionAuthenticationMethod securityQuestionAuthenticationMethodToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SecurityQuestionAuthenticationMethod.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SecurityQuestionAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SecurityQuestionAuthenticationMethod.
        /// </summary>
        /// <returns>The SecurityQuestionAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<SecurityQuestionAuthenticationMethod> GetAsync();

        /// <summary>
        /// Gets the specified SecurityQuestionAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecurityQuestionAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<SecurityQuestionAuthenticationMethod> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SecurityQuestionAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="securityQuestionAuthenticationMethodToUpdate">The SecurityQuestionAuthenticationMethod to update.</param>
        /// <returns>The updated SecurityQuestionAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<SecurityQuestionAuthenticationMethod> UpdateAsync(SecurityQuestionAuthenticationMethod securityQuestionAuthenticationMethodToUpdate);

        /// <summary>
        /// Updates the specified SecurityQuestionAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="securityQuestionAuthenticationMethodToUpdate">The SecurityQuestionAuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecurityQuestionAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<SecurityQuestionAuthenticationMethod> UpdateAsync(SecurityQuestionAuthenticationMethod securityQuestionAuthenticationMethodToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityQuestionAuthenticationMethodRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityQuestionAuthenticationMethodRequest Expand(Expression<Func<SecurityQuestionAuthenticationMethod, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityQuestionAuthenticationMethodRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityQuestionAuthenticationMethodRequest Select(Expression<Func<SecurityQuestionAuthenticationMethod, object>> selectExpression);

    }
}
