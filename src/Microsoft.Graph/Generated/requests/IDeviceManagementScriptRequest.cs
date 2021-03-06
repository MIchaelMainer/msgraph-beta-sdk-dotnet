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
    /// The interface IDeviceManagementScriptRequest.
    /// </summary>
    public partial interface IDeviceManagementScriptRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementScript using POST.
        /// </summary>
        /// <param name="deviceManagementScriptToCreate">The DeviceManagementScript to create.</param>
        /// <returns>The created DeviceManagementScript.</returns>
        System.Threading.Tasks.Task<DeviceManagementScript> CreateAsync(DeviceManagementScript deviceManagementScriptToCreate);        /// <summary>
        /// Creates the specified DeviceManagementScript using POST.
        /// </summary>
        /// <param name="deviceManagementScriptToCreate">The DeviceManagementScript to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementScript.</returns>
        System.Threading.Tasks.Task<DeviceManagementScript> CreateAsync(DeviceManagementScript deviceManagementScriptToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementScript.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementScript.
        /// </summary>
        /// <returns>The DeviceManagementScript.</returns>
        System.Threading.Tasks.Task<DeviceManagementScript> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementScript.</returns>
        System.Threading.Tasks.Task<DeviceManagementScript> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementScript using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptToUpdate">The DeviceManagementScript to update.</param>
        /// <returns>The updated DeviceManagementScript.</returns>
        System.Threading.Tasks.Task<DeviceManagementScript> UpdateAsync(DeviceManagementScript deviceManagementScriptToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementScript using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptToUpdate">The DeviceManagementScript to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementScript.</returns>
        System.Threading.Tasks.Task<DeviceManagementScript> UpdateAsync(DeviceManagementScript deviceManagementScriptToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRequest Expand(Expression<Func<DeviceManagementScript, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRequest Select(Expression<Func<DeviceManagementScript, object>> selectExpression);

    }
}
