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
    /// The interface IBookingNamedEntityRequest.
    /// </summary>
    public partial interface IBookingNamedEntityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BookingNamedEntity using POST.
        /// </summary>
        /// <param name="bookingNamedEntityToCreate">The BookingNamedEntity to create.</param>
        /// <returns>The created BookingNamedEntity.</returns>
        System.Threading.Tasks.Task<BookingNamedEntity> CreateAsync(BookingNamedEntity bookingNamedEntityToCreate);        /// <summary>
        /// Creates the specified BookingNamedEntity using POST.
        /// </summary>
        /// <param name="bookingNamedEntityToCreate">The BookingNamedEntity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BookingNamedEntity.</returns>
        System.Threading.Tasks.Task<BookingNamedEntity> CreateAsync(BookingNamedEntity bookingNamedEntityToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified BookingNamedEntity.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified BookingNamedEntity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified BookingNamedEntity.
        /// </summary>
        /// <returns>The BookingNamedEntity.</returns>
        System.Threading.Tasks.Task<BookingNamedEntity> GetAsync();

        /// <summary>
        /// Gets the specified BookingNamedEntity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BookingNamedEntity.</returns>
        System.Threading.Tasks.Task<BookingNamedEntity> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified BookingNamedEntity using PATCH.
        /// </summary>
        /// <param name="bookingNamedEntityToUpdate">The BookingNamedEntity to update.</param>
        /// <returns>The updated BookingNamedEntity.</returns>
        System.Threading.Tasks.Task<BookingNamedEntity> UpdateAsync(BookingNamedEntity bookingNamedEntityToUpdate);

        /// <summary>
        /// Updates the specified BookingNamedEntity using PATCH.
        /// </summary>
        /// <param name="bookingNamedEntityToUpdate">The BookingNamedEntity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BookingNamedEntity.</returns>
        System.Threading.Tasks.Task<BookingNamedEntity> UpdateAsync(BookingNamedEntity bookingNamedEntityToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingNamedEntityRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingNamedEntityRequest Expand(Expression<Func<BookingNamedEntity, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingNamedEntityRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingNamedEntityRequest Select(Expression<Func<BookingNamedEntity, object>> selectExpression);

    }
}
