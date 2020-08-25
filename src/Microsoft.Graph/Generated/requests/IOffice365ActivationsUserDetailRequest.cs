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
    /// The interface IOffice365ActivationsUserDetailRequest.
    /// </summary>
    public partial interface IOffice365ActivationsUserDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Office365ActivationsUserDetail using POST.
        /// </summary>
        /// <param name="office365ActivationsUserDetailToCreate">The Office365ActivationsUserDetail to create.</param>
        /// <returns>The created Office365ActivationsUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActivationsUserDetail> CreateAsync(Office365ActivationsUserDetail office365ActivationsUserDetailToCreate);        /// <summary>
        /// Creates the specified Office365ActivationsUserDetail using POST.
        /// </summary>
        /// <param name="office365ActivationsUserDetailToCreate">The Office365ActivationsUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Office365ActivationsUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActivationsUserDetail> CreateAsync(Office365ActivationsUserDetail office365ActivationsUserDetailToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Office365ActivationsUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Office365ActivationsUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Office365ActivationsUserDetail.
        /// </summary>
        /// <returns>The Office365ActivationsUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActivationsUserDetail> GetAsync();

        /// <summary>
        /// Gets the specified Office365ActivationsUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Office365ActivationsUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActivationsUserDetail> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Office365ActivationsUserDetail using PATCH.
        /// </summary>
        /// <param name="office365ActivationsUserDetailToUpdate">The Office365ActivationsUserDetail to update.</param>
        /// <returns>The updated Office365ActivationsUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActivationsUserDetail> UpdateAsync(Office365ActivationsUserDetail office365ActivationsUserDetailToUpdate);

        /// <summary>
        /// Updates the specified Office365ActivationsUserDetail using PATCH.
        /// </summary>
        /// <param name="office365ActivationsUserDetailToUpdate">The Office365ActivationsUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Office365ActivationsUserDetail.</returns>
        System.Threading.Tasks.Task<Office365ActivationsUserDetail> UpdateAsync(Office365ActivationsUserDetail office365ActivationsUserDetailToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365ActivationsUserDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365ActivationsUserDetailRequest Expand(Expression<Func<Office365ActivationsUserDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365ActivationsUserDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOffice365ActivationsUserDetailRequest Select(Expression<Func<Office365ActivationsUserDetail, object>> selectExpression);

    }
}
