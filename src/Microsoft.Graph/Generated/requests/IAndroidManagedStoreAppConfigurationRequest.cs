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
    /// The interface IAndroidManagedStoreAppConfigurationRequest.
    /// </summary>
    public partial interface IAndroidManagedStoreAppConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidManagedStoreAppConfiguration using POST.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationToCreate">The AndroidManagedStoreAppConfiguration to create.</param>
        /// <returns>The created AndroidManagedStoreAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfiguration> CreateAsync(AndroidManagedStoreAppConfiguration androidManagedStoreAppConfigurationToCreate);        /// <summary>
        /// Creates the specified AndroidManagedStoreAppConfiguration using POST.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationToCreate">The AndroidManagedStoreAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidManagedStoreAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfiguration> CreateAsync(AndroidManagedStoreAppConfiguration androidManagedStoreAppConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAppConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidManagedStoreAppConfiguration.
        /// </summary>
        /// <returns>The AndroidManagedStoreAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidManagedStoreAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidManagedStoreAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidManagedStoreAppConfiguration using PATCH.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationToUpdate">The AndroidManagedStoreAppConfiguration to update.</param>
        /// <returns>The updated AndroidManagedStoreAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfiguration> UpdateAsync(AndroidManagedStoreAppConfiguration androidManagedStoreAppConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AndroidManagedStoreAppConfiguration using PATCH.
        /// </summary>
        /// <param name="androidManagedStoreAppConfigurationToUpdate">The AndroidManagedStoreAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidManagedStoreAppConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidManagedStoreAppConfiguration> UpdateAsync(AndroidManagedStoreAppConfiguration androidManagedStoreAppConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAppConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAppConfigurationRequest Expand(Expression<Func<AndroidManagedStoreAppConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAppConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidManagedStoreAppConfigurationRequest Select(Expression<Func<AndroidManagedStoreAppConfiguration, object>> selectExpression);

    }
}
