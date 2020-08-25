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
    /// The type DeviceManagementDerivedCredentialSettingsWithReferenceRequest.
    /// </summary>
    public partial class DeviceManagementDerivedCredentialSettingsWithReferenceRequest : BaseRequest, IDeviceManagementDerivedCredentialSettingsWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementDerivedCredentialSettingsWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementDerivedCredentialSettingsWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified DeviceManagementDerivedCredentialSettings.
        /// </summary>
        /// <returns>The DeviceManagementDerivedCredentialSettings.</returns>
        public System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementDerivedCredentialSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementDerivedCredentialSettings.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceManagementDerivedCredentialSettings>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified DeviceManagementDerivedCredentialSettings using POST.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToCreate">The DeviceManagementDerivedCredentialSettings to create.</param>
        /// <returns>The created DeviceManagementDerivedCredentialSettings.</returns>
        public System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> CreateAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToCreate)
        {
            return this.CreateAsync(deviceManagementDerivedCredentialSettingsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceManagementDerivedCredentialSettings using POST.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToCreate">The DeviceManagementDerivedCredentialSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementDerivedCredentialSettings.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> CreateAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceManagementDerivedCredentialSettings>(deviceManagementDerivedCredentialSettingsToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified DeviceManagementDerivedCredentialSettings using PATCH.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToUpdate">The DeviceManagementDerivedCredentialSettings to update.</param>
        /// <returns>The updated DeviceManagementDerivedCredentialSettings.</returns>
        public System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> UpdateAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToUpdate)
        {
            return this.UpdateAsync(deviceManagementDerivedCredentialSettingsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceManagementDerivedCredentialSettings using PATCH.
        /// </summary>
        /// <param name="deviceManagementDerivedCredentialSettingsToUpdate">The DeviceManagementDerivedCredentialSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementDerivedCredentialSettings.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementDerivedCredentialSettings> UpdateAsync(DeviceManagementDerivedCredentialSettings deviceManagementDerivedCredentialSettingsToUpdate, CancellationToken cancellationToken)
        {
			if (deviceManagementDerivedCredentialSettingsToUpdate.AdditionalData != null)
			{
				if (deviceManagementDerivedCredentialSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceManagementDerivedCredentialSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementDerivedCredentialSettingsToUpdate.GetType().Name)
						});
				}
			}
            if (deviceManagementDerivedCredentialSettingsToUpdate.AdditionalData != null)
            {
                if (deviceManagementDerivedCredentialSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceManagementDerivedCredentialSettingsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceManagementDerivedCredentialSettingsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceManagementDerivedCredentialSettings>(deviceManagementDerivedCredentialSettingsToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified DeviceManagementDerivedCredentialSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementDerivedCredentialSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceManagementDerivedCredentialSettings>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementDerivedCredentialSettingsWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementDerivedCredentialSettingsWithReferenceRequest Expand(Expression<Func<DeviceManagementDerivedCredentialSettings, object>> expandExpression)
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
        public IDeviceManagementDerivedCredentialSettingsWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementDerivedCredentialSettingsWithReferenceRequest Select(Expression<Func<DeviceManagementDerivedCredentialSettings, object>> selectExpression)
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
