// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WorkbookChartAreaFormatRequest.
    /// </summary>
    public partial class WorkbookChartAreaFormatRequest : BaseRequest, IWorkbookChartAreaFormatRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartAreaFormatRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookChartAreaFormatRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookChartAreaFormat using POST.
        /// </summary>
        /// <param name="workbookChartAreaFormatToCreate">The WorkbookChartAreaFormat to create.</param>
        /// <returns>The created WorkbookChartAreaFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartAreaFormat> CreateAsync(WorkbookChartAreaFormat workbookChartAreaFormatToCreate)
        {
            return this.CreateAsync(workbookChartAreaFormatToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartAreaFormat using POST.
        /// </summary>
        /// <param name="workbookChartAreaFormatToCreate">The WorkbookChartAreaFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartAreaFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartAreaFormat> CreateAsync(WorkbookChartAreaFormat workbookChartAreaFormatToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookChartAreaFormat>(workbookChartAreaFormatToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookChartAreaFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartAreaFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookChartAreaFormat>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookChartAreaFormat.
        /// </summary>
        /// <returns>The WorkbookChartAreaFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartAreaFormat> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartAreaFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartAreaFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartAreaFormat> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookChartAreaFormat>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookChartAreaFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartAreaFormatToUpdate">The WorkbookChartAreaFormat to update.</param>
        /// <returns>The updated WorkbookChartAreaFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartAreaFormat> UpdateAsync(WorkbookChartAreaFormat workbookChartAreaFormatToUpdate)
        {
            return this.UpdateAsync(workbookChartAreaFormatToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChartAreaFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartAreaFormatToUpdate">The WorkbookChartAreaFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartAreaFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartAreaFormat> UpdateAsync(WorkbookChartAreaFormat workbookChartAreaFormatToUpdate, CancellationToken cancellationToken)
        {
			if (workbookChartAreaFormatToUpdate.AdditionalData != null)
			{
				if (workbookChartAreaFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookChartAreaFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartAreaFormatToUpdate.GetType().Name)
						});
				}
			}
            if (workbookChartAreaFormatToUpdate.AdditionalData != null)
            {
                if (workbookChartAreaFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookChartAreaFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartAreaFormatToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookChartAreaFormat>(workbookChartAreaFormatToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartAreaFormatRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartAreaFormatRequest Expand(Expression<Func<WorkbookChartAreaFormat, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartAreaFormatRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartAreaFormatRequest Select(Expression<Func<WorkbookChartAreaFormat, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="workbookChartAreaFormatToInitialize">The <see cref="WorkbookChartAreaFormat"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookChartAreaFormat workbookChartAreaFormatToInitialize)
        {

        }
    }
}
