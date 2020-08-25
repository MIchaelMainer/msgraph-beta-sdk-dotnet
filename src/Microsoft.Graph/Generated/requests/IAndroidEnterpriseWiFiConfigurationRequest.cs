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
    /// The interface IAndroidEnterpriseWiFiConfigurationRequest.
    /// </summary>
    public partial interface IAndroidEnterpriseWiFiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidEnterpriseWiFiConfigurationToCreate">The AndroidEnterpriseWiFiConfiguration to create.</param>
        /// <returns>The created AndroidEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> CreateAsync(AndroidEnterpriseWiFiConfiguration androidEnterpriseWiFiConfigurationToCreate);        /// <summary>
        /// Creates the specified AndroidEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidEnterpriseWiFiConfigurationToCreate">The AndroidEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> CreateAsync(AndroidEnterpriseWiFiConfiguration androidEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidEnterpriseWiFiConfiguration.
        /// </summary>
        /// <returns>The AndroidEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidEnterpriseWiFiConfigurationToUpdate">The AndroidEnterpriseWiFiConfiguration to update.</param>
        /// <returns>The updated AndroidEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> UpdateAsync(AndroidEnterpriseWiFiConfiguration androidEnterpriseWiFiConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AndroidEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidEnterpriseWiFiConfigurationToUpdate">The AndroidEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidEnterpriseWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidEnterpriseWiFiConfiguration> UpdateAsync(AndroidEnterpriseWiFiConfiguration androidEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidEnterpriseWiFiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidEnterpriseWiFiConfigurationRequest Expand(Expression<Func<AndroidEnterpriseWiFiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidEnterpriseWiFiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidEnterpriseWiFiConfigurationRequest Select(Expression<Func<AndroidEnterpriseWiFiConfiguration, object>> selectExpression);

    }
}
