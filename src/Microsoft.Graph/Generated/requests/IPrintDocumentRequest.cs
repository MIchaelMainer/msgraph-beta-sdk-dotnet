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
    /// The interface IPrintDocumentRequest.
    /// </summary>
    public partial interface IPrintDocumentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrintDocument using POST.
        /// </summary>
        /// <param name="printDocumentToCreate">The PrintDocument to create.</param>
        /// <returns>The created PrintDocument.</returns>
        System.Threading.Tasks.Task<PrintDocument> CreateAsync(PrintDocument printDocumentToCreate);        /// <summary>
        /// Creates the specified PrintDocument using POST.
        /// </summary>
        /// <param name="printDocumentToCreate">The PrintDocument to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintDocument.</returns>
        System.Threading.Tasks.Task<PrintDocument> CreateAsync(PrintDocument printDocumentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PrintDocument.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PrintDocument.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PrintDocument.
        /// </summary>
        /// <returns>The PrintDocument.</returns>
        System.Threading.Tasks.Task<PrintDocument> GetAsync();

        /// <summary>
        /// Gets the specified PrintDocument.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrintDocument.</returns>
        System.Threading.Tasks.Task<PrintDocument> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PrintDocument using PATCH.
        /// </summary>
        /// <param name="printDocumentToUpdate">The PrintDocument to update.</param>
        /// <returns>The updated PrintDocument.</returns>
        System.Threading.Tasks.Task<PrintDocument> UpdateAsync(PrintDocument printDocumentToUpdate);

        /// <summary>
        /// Updates the specified PrintDocument using PATCH.
        /// </summary>
        /// <param name="printDocumentToUpdate">The PrintDocument to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrintDocument.</returns>
        System.Threading.Tasks.Task<PrintDocument> UpdateAsync(PrintDocument printDocumentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintDocumentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintDocumentRequest Expand(Expression<Func<PrintDocument, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintDocumentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintDocumentRequest Select(Expression<Func<PrintDocument, object>> selectExpression);

    }
}
