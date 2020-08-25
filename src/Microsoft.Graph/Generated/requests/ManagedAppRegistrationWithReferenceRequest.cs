// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ManagedAppRegistrationWithReferenceRequest.
    /// </summary>
    public partial class ManagedAppRegistrationWithReferenceRequest : BaseRequest, IManagedAppRegistrationWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new ManagedAppRegistrationWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedAppRegistrationWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified ManagedAppRegistration.
        /// </summary>
        /// <returns>The ManagedAppRegistration.</returns>
        public System.Threading.Tasks.Task<ManagedAppRegistration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<ManagedAppRegistration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ManagedAppRegistration>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified ManagedAppRegistration using POST.
        /// </summary>
        /// <param name="managedAppRegistrationToCreate">The ManagedAppRegistration to create.</param>
        /// <returns>The created ManagedAppRegistration.</returns>
        public System.Threading.Tasks.Task<ManagedAppRegistration> CreateAsync(ManagedAppRegistration managedAppRegistrationToCreate)
        {
            return this.CreateAsync(managedAppRegistrationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ManagedAppRegistration using POST.
        /// </summary>
        /// <param name="managedAppRegistrationToCreate">The ManagedAppRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<ManagedAppRegistration> CreateAsync(ManagedAppRegistration managedAppRegistrationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ManagedAppRegistration>(managedAppRegistrationToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified ManagedAppRegistration using PATCH.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration to update.</param>
        /// <returns>The updated ManagedAppRegistration.</returns>
        public System.Threading.Tasks.Task<ManagedAppRegistration> UpdateAsync(ManagedAppRegistration managedAppRegistrationToUpdate)
        {
            return this.UpdateAsync(managedAppRegistrationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ManagedAppRegistration using PATCH.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedAppRegistration.</returns>
        public async System.Threading.Tasks.Task<ManagedAppRegistration> UpdateAsync(ManagedAppRegistration managedAppRegistrationToUpdate, CancellationToken cancellationToken)
        {
			if (managedAppRegistrationToUpdate.AdditionalData != null)
			{
				if (managedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					managedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, managedAppRegistrationToUpdate.GetType().Name)
						});
				}
			}
            if (managedAppRegistrationToUpdate.AdditionalData != null)
            {
                if (managedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    managedAppRegistrationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, managedAppRegistrationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ManagedAppRegistration>(managedAppRegistrationToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified ManagedAppRegistration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ManagedAppRegistration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedAppRegistrationWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedAppRegistrationWithReferenceRequest Expand(Expression<Func<ManagedAppRegistration, object>> expandExpression)
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
        public IManagedAppRegistrationWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedAppRegistrationWithReferenceRequest Select(Expression<Func<ManagedAppRegistration, object>> selectExpression)
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

    }
}
