// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceCompliancePolicyWithReferenceRequest.
    /// </summary>
    public partial interface IDeviceCompliancePolicyWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified DeviceCompliancePolicy.
        /// </summary>
        /// <returns>The DeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicy> GetAsync();

        /// <summary>
        /// Gets the specified DeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicy> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified DeviceCompliancePolicy using POST.
        /// </summary>
        /// <param name="deviceCompliancePolicyToCreate">The DeviceCompliancePolicy to create.</param>
        /// <returns>The created DeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicy> CreateAsync(DeviceCompliancePolicy deviceCompliancePolicyToCreate);        /// <summary>
        /// Creates the specified DeviceCompliancePolicy using POST.
        /// </summary>
        /// <param name="deviceCompliancePolicyToCreate">The DeviceCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicy> CreateAsync(DeviceCompliancePolicy deviceCompliancePolicyToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified DeviceCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicyToUpdate">The DeviceCompliancePolicy to update.</param>
        /// <returns>The updated DeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicy> UpdateAsync(DeviceCompliancePolicy deviceCompliancePolicyToUpdate);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicyToUpdate">The DeviceCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicy> UpdateAsync(DeviceCompliancePolicy deviceCompliancePolicyToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified DeviceCompliancePolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyWithReferenceRequest Expand(Expression<Func<DeviceCompliancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyWithReferenceRequest Select(Expression<Func<DeviceCompliancePolicy, object>> selectExpression);

    }
}
