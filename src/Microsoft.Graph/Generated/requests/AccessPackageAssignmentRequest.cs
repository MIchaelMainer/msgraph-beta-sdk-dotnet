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
    /// The type AccessPackageAssignmentRequest.
    /// </summary>
    public partial class AccessPackageAssignmentRequest : BaseRequest, IAccessPackageAssignmentRequest
    {
        /// <summary>
        /// Constructs a new AccessPackageAssignmentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AccessPackageAssignmentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AccessPackageAssignment using POST.
        /// </summary>
        /// <param name="accessPackageAssignmentToCreate">The AccessPackageAssignment to create.</param>
        /// <returns>The created AccessPackageAssignment.</returns>
        public System.Threading.Tasks.Task<AccessPackageAssignment> CreateAsync(AccessPackageAssignment accessPackageAssignmentToCreate)
        {
            return this.CreateAsync(accessPackageAssignmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AccessPackageAssignment using POST.
        /// </summary>
        /// <param name="accessPackageAssignmentToCreate">The AccessPackageAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageAssignment.</returns>
        public async System.Threading.Tasks.Task<AccessPackageAssignment> CreateAsync(AccessPackageAssignment accessPackageAssignmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AccessPackageAssignment>(accessPackageAssignmentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified AccessPackageAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AccessPackageAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AccessPackageAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AccessPackageAssignment.
        /// </summary>
        /// <returns>The AccessPackageAssignment.</returns>
        public System.Threading.Tasks.Task<AccessPackageAssignment> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AccessPackageAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageAssignment.</returns>
        public async System.Threading.Tasks.Task<AccessPackageAssignment> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AccessPackageAssignment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified AccessPackageAssignment using PATCH.
        /// </summary>
        /// <param name="accessPackageAssignmentToUpdate">The AccessPackageAssignment to update.</param>
        /// <returns>The updated AccessPackageAssignment.</returns>
        public System.Threading.Tasks.Task<AccessPackageAssignment> UpdateAsync(AccessPackageAssignment accessPackageAssignmentToUpdate)
        {
            return this.UpdateAsync(accessPackageAssignmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AccessPackageAssignment using PATCH.
        /// </summary>
        /// <param name="accessPackageAssignmentToUpdate">The AccessPackageAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageAssignment.</returns>
        public async System.Threading.Tasks.Task<AccessPackageAssignment> UpdateAsync(AccessPackageAssignment accessPackageAssignmentToUpdate, CancellationToken cancellationToken)
        {
			if (accessPackageAssignmentToUpdate.AdditionalData != null)
			{
				if (accessPackageAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					accessPackageAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, accessPackageAssignmentToUpdate.GetType().Name)
						});
				}
			}
            if (accessPackageAssignmentToUpdate.AdditionalData != null)
            {
                if (accessPackageAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    accessPackageAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, accessPackageAssignmentToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AccessPackageAssignment>(accessPackageAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageAssignmentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageAssignmentRequest Expand(Expression<Func<AccessPackageAssignment, object>> expandExpression)
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
        public IAccessPackageAssignmentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageAssignmentRequest Select(Expression<Func<AccessPackageAssignment, object>> selectExpression)
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
        /// <param name="accessPackageAssignmentToInitialize">The <see cref="AccessPackageAssignment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AccessPackageAssignment accessPackageAssignmentToInitialize)
        {

            if (accessPackageAssignmentToInitialize != null && accessPackageAssignmentToInitialize.AdditionalData != null)
            {

                if (accessPackageAssignmentToInitialize.AccessPackageAssignmentRequests != null && accessPackageAssignmentToInitialize.AccessPackageAssignmentRequests.CurrentPage != null)
                {
                    accessPackageAssignmentToInitialize.AccessPackageAssignmentRequests.AdditionalData = accessPackageAssignmentToInitialize.AdditionalData;

                    object nextPageLink;
                    accessPackageAssignmentToInitialize.AdditionalData.TryGetValue("accessPackageAssignmentRequests@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        accessPackageAssignmentToInitialize.AccessPackageAssignmentRequests.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (accessPackageAssignmentToInitialize.AccessPackageAssignmentResourceRoles != null && accessPackageAssignmentToInitialize.AccessPackageAssignmentResourceRoles.CurrentPage != null)
                {
                    accessPackageAssignmentToInitialize.AccessPackageAssignmentResourceRoles.AdditionalData = accessPackageAssignmentToInitialize.AdditionalData;

                    object nextPageLink;
                    accessPackageAssignmentToInitialize.AdditionalData.TryGetValue("accessPackageAssignmentResourceRoles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        accessPackageAssignmentToInitialize.AccessPackageAssignmentResourceRoles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
