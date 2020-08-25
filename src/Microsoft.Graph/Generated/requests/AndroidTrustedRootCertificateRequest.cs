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
    /// The type AndroidTrustedRootCertificateRequest.
    /// </summary>
    public partial class AndroidTrustedRootCertificateRequest : BaseRequest, IAndroidTrustedRootCertificateRequest
    {
        /// <summary>
        /// Constructs a new AndroidTrustedRootCertificateRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidTrustedRootCertificateRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AndroidTrustedRootCertificate using POST.
        /// </summary>
        /// <param name="androidTrustedRootCertificateToCreate">The AndroidTrustedRootCertificate to create.</param>
        /// <returns>The created AndroidTrustedRootCertificate.</returns>
        public System.Threading.Tasks.Task<AndroidTrustedRootCertificate> CreateAsync(AndroidTrustedRootCertificate androidTrustedRootCertificateToCreate)
        {
            return this.CreateAsync(androidTrustedRootCertificateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AndroidTrustedRootCertificate using POST.
        /// </summary>
        /// <param name="androidTrustedRootCertificateToCreate">The AndroidTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidTrustedRootCertificate.</returns>
        public async System.Threading.Tasks.Task<AndroidTrustedRootCertificate> CreateAsync(AndroidTrustedRootCertificate androidTrustedRootCertificateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AndroidTrustedRootCertificate>(androidTrustedRootCertificateToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified AndroidTrustedRootCertificate.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AndroidTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AndroidTrustedRootCertificate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AndroidTrustedRootCertificate.
        /// </summary>
        /// <returns>The AndroidTrustedRootCertificate.</returns>
        public System.Threading.Tasks.Task<AndroidTrustedRootCertificate> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidTrustedRootCertificate.</returns>
        public async System.Threading.Tasks.Task<AndroidTrustedRootCertificate> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AndroidTrustedRootCertificate>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="androidTrustedRootCertificateToUpdate">The AndroidTrustedRootCertificate to update.</param>
        /// <returns>The updated AndroidTrustedRootCertificate.</returns>
        public System.Threading.Tasks.Task<AndroidTrustedRootCertificate> UpdateAsync(AndroidTrustedRootCertificate androidTrustedRootCertificateToUpdate)
        {
            return this.UpdateAsync(androidTrustedRootCertificateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AndroidTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="androidTrustedRootCertificateToUpdate">The AndroidTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidTrustedRootCertificate.</returns>
        public async System.Threading.Tasks.Task<AndroidTrustedRootCertificate> UpdateAsync(AndroidTrustedRootCertificate androidTrustedRootCertificateToUpdate, CancellationToken cancellationToken)
        {
			if (androidTrustedRootCertificateToUpdate.AdditionalData != null)
			{
				if (androidTrustedRootCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					androidTrustedRootCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidTrustedRootCertificateToUpdate.GetType().Name)
						});
				}
			}
            if (androidTrustedRootCertificateToUpdate.AdditionalData != null)
            {
                if (androidTrustedRootCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    androidTrustedRootCertificateToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, androidTrustedRootCertificateToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AndroidTrustedRootCertificate>(androidTrustedRootCertificateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidTrustedRootCertificateRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidTrustedRootCertificateRequest Expand(Expression<Func<AndroidTrustedRootCertificate, object>> expandExpression)
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
        public IAndroidTrustedRootCertificateRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidTrustedRootCertificateRequest Select(Expression<Func<AndroidTrustedRootCertificate, object>> selectExpression)
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
        /// <param name="androidTrustedRootCertificateToInitialize">The <see cref="AndroidTrustedRootCertificate"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AndroidTrustedRootCertificate androidTrustedRootCertificateToInitialize)
        {

        }
    }
}
