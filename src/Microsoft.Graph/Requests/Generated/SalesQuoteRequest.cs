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
    /// The type SalesQuoteRequest.
    /// </summary>
    public partial class SalesQuoteRequest : BaseRequest, ISalesQuoteRequest
    {
        /// <summary>
        /// Constructs a new SalesQuoteRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SalesQuoteRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SalesQuote using POST.
        /// </summary>
        /// <param name="salesQuoteToCreate">The SalesQuote to create.</param>
        /// <returns>The created SalesQuote.</returns>
        public System.Threading.Tasks.Task<SalesQuote> CreateAsync(SalesQuote salesQuoteToCreate)
        {
            return this.CreateAsync(salesQuoteToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SalesQuote using POST.
        /// </summary>
        /// <param name="salesQuoteToCreate">The SalesQuote to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SalesQuote.</returns>
        public async System.Threading.Tasks.Task<SalesQuote> CreateAsync(SalesQuote salesQuoteToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<SalesQuote>(salesQuoteToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified SalesQuote.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SalesQuote.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<SalesQuote>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified SalesQuote.
        /// </summary>
        /// <returns>The SalesQuote.</returns>
        public System.Threading.Tasks.Task<SalesQuote> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SalesQuote.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SalesQuote.</returns>
        public async System.Threading.Tasks.Task<SalesQuote> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<SalesQuote>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified SalesQuote using PATCH.
        /// </summary>
        /// <param name="salesQuoteToUpdate">The SalesQuote to update.</param>
        /// <returns>The updated SalesQuote.</returns>
        public System.Threading.Tasks.Task<SalesQuote> UpdateAsync(SalesQuote salesQuoteToUpdate)
        {
            return this.UpdateAsync(salesQuoteToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SalesQuote using PATCH.
        /// </summary>
        /// <param name="salesQuoteToUpdate">The SalesQuote to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SalesQuote.</returns>
        public async System.Threading.Tasks.Task<SalesQuote> UpdateAsync(SalesQuote salesQuoteToUpdate, CancellationToken cancellationToken)
        {
			if (salesQuoteToUpdate.AdditionalData != null)
			{
				if (salesQuoteToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					salesQuoteToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, salesQuoteToUpdate.GetType().Name)
						});
				}
			}
            if (salesQuoteToUpdate.AdditionalData != null)
            {
                if (salesQuoteToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    salesQuoteToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, salesQuoteToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<SalesQuote>(salesQuoteToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISalesQuoteRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISalesQuoteRequest Expand(Expression<Func<SalesQuote, object>> expandExpression)
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
        public ISalesQuoteRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISalesQuoteRequest Select(Expression<Func<SalesQuote, object>> selectExpression)
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
        /// <param name="salesQuoteToInitialize">The <see cref="SalesQuote"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SalesQuote salesQuoteToInitialize)
        {

            if (salesQuoteToInitialize != null && salesQuoteToInitialize.AdditionalData != null)
            {

                if (salesQuoteToInitialize.SalesQuoteLines != null && salesQuoteToInitialize.SalesQuoteLines.CurrentPage != null)
                {
                    salesQuoteToInitialize.SalesQuoteLines.AdditionalData = salesQuoteToInitialize.AdditionalData;

                    object nextPageLink;
                    salesQuoteToInitialize.AdditionalData.TryGetValue("salesQuoteLines@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        salesQuoteToInitialize.SalesQuoteLines.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}