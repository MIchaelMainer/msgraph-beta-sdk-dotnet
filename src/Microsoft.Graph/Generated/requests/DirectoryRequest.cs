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
    /// The type DirectoryRequest.
    /// </summary>
    public partial class DirectoryRequest : BaseRequest, IDirectoryRequest
    {
        /// <summary>
        /// Constructs a new DirectoryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DirectoryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Directory using POST.
        /// </summary>
        /// <param name="directoryToCreate">The Directory to create.</param>
        /// <returns>The created Directory.</returns>
        public System.Threading.Tasks.Task<Directory> CreateAsync(Directory directoryToCreate)
        {
            return this.CreateAsync(directoryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Directory using POST.
        /// </summary>
        /// <param name="directoryToCreate">The Directory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Directory.</returns>
        public async System.Threading.Tasks.Task<Directory> CreateAsync(Directory directoryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Directory>(directoryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Directory.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Directory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Directory>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Directory.
        /// </summary>
        /// <returns>The Directory.</returns>
        public System.Threading.Tasks.Task<Directory> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Directory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Directory.</returns>
        public async System.Threading.Tasks.Task<Directory> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Directory>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Directory using PATCH.
        /// </summary>
        /// <param name="directoryToUpdate">The Directory to update.</param>
        /// <returns>The updated Directory.</returns>
        public System.Threading.Tasks.Task<Directory> UpdateAsync(Directory directoryToUpdate)
        {
            return this.UpdateAsync(directoryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Directory using PATCH.
        /// </summary>
        /// <param name="directoryToUpdate">The Directory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Directory.</returns>
        public async System.Threading.Tasks.Task<Directory> UpdateAsync(Directory directoryToUpdate, CancellationToken cancellationToken)
        {
			if (directoryToUpdate.AdditionalData != null)
			{
				if (directoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					directoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, directoryToUpdate.GetType().Name)
						});
				}
			}
            if (directoryToUpdate.AdditionalData != null)
            {
                if (directoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    directoryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, directoryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Directory>(directoryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryRequest Expand(Expression<Func<Directory, object>> expandExpression)
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
        public IDirectoryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDirectoryRequest Select(Expression<Func<Directory, object>> selectExpression)
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
        /// <param name="directoryToInitialize">The <see cref="Directory"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Directory directoryToInitialize)
        {

            if (directoryToInitialize != null && directoryToInitialize.AdditionalData != null)
            {

                if (directoryToInitialize.DeletedItems != null && directoryToInitialize.DeletedItems.CurrentPage != null)
                {
                    directoryToInitialize.DeletedItems.AdditionalData = directoryToInitialize.AdditionalData;

                    object nextPageLink;
                    directoryToInitialize.AdditionalData.TryGetValue("deletedItems@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        directoryToInitialize.DeletedItems.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (directoryToInitialize.FeatureRolloutPolicies != null && directoryToInitialize.FeatureRolloutPolicies.CurrentPage != null)
                {
                    directoryToInitialize.FeatureRolloutPolicies.AdditionalData = directoryToInitialize.AdditionalData;

                    object nextPageLink;
                    directoryToInitialize.AdditionalData.TryGetValue("featureRolloutPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        directoryToInitialize.FeatureRolloutPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
