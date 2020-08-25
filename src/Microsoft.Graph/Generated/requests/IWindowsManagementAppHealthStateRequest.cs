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
    /// The interface IWindowsManagementAppHealthStateRequest.
    /// </summary>
    public partial interface IWindowsManagementAppHealthStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsManagementAppHealthState using POST.
        /// </summary>
        /// <param name="windowsManagementAppHealthStateToCreate">The WindowsManagementAppHealthState to create.</param>
        /// <returns>The created WindowsManagementAppHealthState.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthState> CreateAsync(WindowsManagementAppHealthState windowsManagementAppHealthStateToCreate);        /// <summary>
        /// Creates the specified WindowsManagementAppHealthState using POST.
        /// </summary>
        /// <param name="windowsManagementAppHealthStateToCreate">The WindowsManagementAppHealthState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsManagementAppHealthState.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthState> CreateAsync(WindowsManagementAppHealthState windowsManagementAppHealthStateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsManagementAppHealthState.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsManagementAppHealthState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsManagementAppHealthState.
        /// </summary>
        /// <returns>The WindowsManagementAppHealthState.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthState> GetAsync();

        /// <summary>
        /// Gets the specified WindowsManagementAppHealthState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsManagementAppHealthState.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthState> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsManagementAppHealthState using PATCH.
        /// </summary>
        /// <param name="windowsManagementAppHealthStateToUpdate">The WindowsManagementAppHealthState to update.</param>
        /// <returns>The updated WindowsManagementAppHealthState.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthState> UpdateAsync(WindowsManagementAppHealthState windowsManagementAppHealthStateToUpdate);

        /// <summary>
        /// Updates the specified WindowsManagementAppHealthState using PATCH.
        /// </summary>
        /// <param name="windowsManagementAppHealthStateToUpdate">The WindowsManagementAppHealthState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsManagementAppHealthState.</returns>
        System.Threading.Tasks.Task<WindowsManagementAppHealthState> UpdateAsync(WindowsManagementAppHealthState windowsManagementAppHealthStateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppHealthStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppHealthStateRequest Expand(Expression<Func<WindowsManagementAppHealthState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppHealthStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppHealthStateRequest Select(Expression<Func<WindowsManagementAppHealthState, object>> selectExpression);

    }
}
