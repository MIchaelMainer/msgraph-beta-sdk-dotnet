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
    /// The type DimensionRequest.
    /// </summary>
    public partial class DimensionRequest : BaseRequest, IDimensionRequest
    {
        /// <summary>
        /// Constructs a new DimensionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DimensionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Dimension using POST.
        /// </summary>
        /// <param name="dimensionToCreate">The Dimension to create.</param>
        /// <returns>The created Dimension.</returns>
        public System.Threading.Tasks.Task<Dimension> CreateAsync(Dimension dimensionToCreate)
        {
            return this.CreateAsync(dimensionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Dimension using POST.
        /// </summary>
        /// <param name="dimensionToCreate">The Dimension to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Dimension.</returns>
        public async System.Threading.Tasks.Task<Dimension> CreateAsync(Dimension dimensionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Dimension>(dimensionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Dimension.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Dimension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Dimension>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Dimension.
        /// </summary>
        /// <returns>The Dimension.</returns>
        public System.Threading.Tasks.Task<Dimension> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Dimension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Dimension.</returns>
        public async System.Threading.Tasks.Task<Dimension> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Dimension>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Dimension using PATCH.
        /// </summary>
        /// <param name="dimensionToUpdate">The Dimension to update.</param>
        /// <returns>The updated Dimension.</returns>
        public System.Threading.Tasks.Task<Dimension> UpdateAsync(Dimension dimensionToUpdate)
        {
            return this.UpdateAsync(dimensionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Dimension using PATCH.
        /// </summary>
        /// <param name="dimensionToUpdate">The Dimension to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Dimension.</returns>
        public async System.Threading.Tasks.Task<Dimension> UpdateAsync(Dimension dimensionToUpdate, CancellationToken cancellationToken)
        {
			if (dimensionToUpdate.AdditionalData != null)
			{
				if (dimensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					dimensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, dimensionToUpdate.GetType().Name)
						});
				}
			}
            if (dimensionToUpdate.AdditionalData != null)
            {
                if (dimensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    dimensionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, dimensionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Dimension>(dimensionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDimensionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDimensionRequest Expand(Expression<Func<Dimension, object>> expandExpression)
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
        public IDimensionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDimensionRequest Select(Expression<Func<Dimension, object>> selectExpression)
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
        /// <param name="dimensionToInitialize">The <see cref="Dimension"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Dimension dimensionToInitialize)
        {

            if (dimensionToInitialize != null && dimensionToInitialize.AdditionalData != null)
            {

                if (dimensionToInitialize.DimensionValues != null && dimensionToInitialize.DimensionValues.CurrentPage != null)
                {
                    dimensionToInitialize.DimensionValues.AdditionalData = dimensionToInitialize.AdditionalData;

                    object nextPageLink;
                    dimensionToInitialize.AdditionalData.TryGetValue("dimensionValues@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        dimensionToInitialize.DimensionValues.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
