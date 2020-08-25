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
    /// The interface IOrganizationalBrandingRequest.
    /// </summary>
    public partial interface IOrganizationalBrandingRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OrganizationalBranding using POST.
        /// </summary>
        /// <param name="organizationalBrandingToCreate">The OrganizationalBranding to create.</param>
        /// <returns>The created OrganizationalBranding.</returns>
        System.Threading.Tasks.Task<OrganizationalBranding> CreateAsync(OrganizationalBranding organizationalBrandingToCreate);        /// <summary>
        /// Creates the specified OrganizationalBranding using POST.
        /// </summary>
        /// <param name="organizationalBrandingToCreate">The OrganizationalBranding to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OrganizationalBranding.</returns>
        System.Threading.Tasks.Task<OrganizationalBranding> CreateAsync(OrganizationalBranding organizationalBrandingToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OrganizationalBranding.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OrganizationalBranding.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OrganizationalBranding.
        /// </summary>
        /// <returns>The OrganizationalBranding.</returns>
        System.Threading.Tasks.Task<OrganizationalBranding> GetAsync();

        /// <summary>
        /// Gets the specified OrganizationalBranding.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OrganizationalBranding.</returns>
        System.Threading.Tasks.Task<OrganizationalBranding> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OrganizationalBranding using PATCH.
        /// </summary>
        /// <param name="organizationalBrandingToUpdate">The OrganizationalBranding to update.</param>
        /// <returns>The updated OrganizationalBranding.</returns>
        System.Threading.Tasks.Task<OrganizationalBranding> UpdateAsync(OrganizationalBranding organizationalBrandingToUpdate);

        /// <summary>
        /// Updates the specified OrganizationalBranding using PATCH.
        /// </summary>
        /// <param name="organizationalBrandingToUpdate">The OrganizationalBranding to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OrganizationalBranding.</returns>
        System.Threading.Tasks.Task<OrganizationalBranding> UpdateAsync(OrganizationalBranding organizationalBrandingToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationalBrandingRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationalBrandingRequest Expand(Expression<Func<OrganizationalBranding, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationalBrandingRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationalBrandingRequest Select(Expression<Func<OrganizationalBranding, object>> selectExpression);

    }
}
