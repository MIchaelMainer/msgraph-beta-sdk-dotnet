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
    /// The type GroupPolicyOperationRequest.
    /// </summary>
    public partial class GroupPolicyOperationRequest : BaseRequest, IGroupPolicyOperationRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyOperationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyOperationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyOperation using POST.
        /// </summary>
        /// <param name="groupPolicyOperationToCreate">The GroupPolicyOperation to create.</param>
        /// <returns>The created GroupPolicyOperation.</returns>
        public System.Threading.Tasks.Task<GroupPolicyOperation> CreateAsync(GroupPolicyOperation groupPolicyOperationToCreate)
        {
            return this.CreateAsync(groupPolicyOperationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified GroupPolicyOperation using POST.
        /// </summary>
        /// <param name="groupPolicyOperationToCreate">The GroupPolicyOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyOperation.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyOperation> CreateAsync(GroupPolicyOperation groupPolicyOperationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<GroupPolicyOperation>(groupPolicyOperationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified GroupPolicyOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<GroupPolicyOperation>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified GroupPolicyOperation.
        /// </summary>
        /// <returns>The GroupPolicyOperation.</returns>
        public System.Threading.Tasks.Task<GroupPolicyOperation> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GroupPolicyOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyOperation.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyOperation> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<GroupPolicyOperation>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyOperation using PATCH.
        /// </summary>
        /// <param name="groupPolicyOperationToUpdate">The GroupPolicyOperation to update.</param>
        /// <returns>The updated GroupPolicyOperation.</returns>
        public System.Threading.Tasks.Task<GroupPolicyOperation> UpdateAsync(GroupPolicyOperation groupPolicyOperationToUpdate)
        {
            return this.UpdateAsync(groupPolicyOperationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified GroupPolicyOperation using PATCH.
        /// </summary>
        /// <param name="groupPolicyOperationToUpdate">The GroupPolicyOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyOperation.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyOperation> UpdateAsync(GroupPolicyOperation groupPolicyOperationToUpdate, CancellationToken cancellationToken)
        {
			if (groupPolicyOperationToUpdate.AdditionalData != null)
			{
				if (groupPolicyOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					groupPolicyOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupPolicyOperationToUpdate.GetType().Name)
						});
				}
			}
            if (groupPolicyOperationToUpdate.AdditionalData != null)
            {
                if (groupPolicyOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    groupPolicyOperationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupPolicyOperationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<GroupPolicyOperation>(groupPolicyOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyOperationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyOperationRequest Expand(Expression<Func<GroupPolicyOperation, object>> expandExpression)
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
        public IGroupPolicyOperationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyOperationRequest Select(Expression<Func<GroupPolicyOperation, object>> selectExpression)
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
        /// <param name="groupPolicyOperationToInitialize">The <see cref="GroupPolicyOperation"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyOperation groupPolicyOperationToInitialize)
        {

        }
    }
}