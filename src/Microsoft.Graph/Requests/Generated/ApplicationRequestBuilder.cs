// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ApplicationRequestBuilder.
    /// </summary>
    public partial class ApplicationRequestBuilder : DirectoryObjectRequestBuilder, IApplicationRequestBuilder
    {

        /// <summary>
        /// Constructs a new ApplicationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ApplicationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IApplicationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IApplicationRequest Request(IEnumerable<Option> options)
        {
            return new ApplicationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ExtensionProperties.
        /// </summary>
        /// <returns>The <see cref="IApplicationExtensionPropertiesCollectionRequestBuilder"/>.</returns>
        public IApplicationExtensionPropertiesCollectionRequestBuilder ExtensionProperties
        {
            get
            {
                return new ApplicationExtensionPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("extensionProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for CreatedOnBehalfOf.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        public IDirectoryObjectWithReferenceRequestBuilder CreatedOnBehalfOf
        {
            get
            {
                return new DirectoryObjectWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("createdOnBehalfOf"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Owners.
        /// </summary>
        /// <returns>The <see cref="IApplicationOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        public IApplicationOwnersCollectionWithReferencesRequestBuilder Owners
        {
            get
            {
                return new ApplicationOwnersCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("owners"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Policies.
        /// </summary>
        /// <returns>The <see cref="IApplicationPoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        public IApplicationPoliciesCollectionWithReferencesRequestBuilder Policies
        {
            get
            {
                return new ApplicationPoliciesCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("policies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Synchronization.
        /// </summary>
        /// <returns>The <see cref="ISynchronizationRequestBuilder"/>.</returns>
        public ISynchronizationRequestBuilder Synchronization
        {
            get
            {
                return new SynchronizationRequestBuilder(this.AppendSegmentToRequestUrl("synchronization"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for Logo.
        /// </summary>
        /// <returns>The <see cref="IApplicationLogoRequestBuilder"/>.</returns>
        public IApplicationLogoRequestBuilder Logo
        {
            get
            {
                return new ApplicationLogoRequestBuilder(this.AppendSegmentToRequestUrl("logo"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ApplicationAddKey.
        /// </summary>
        /// <returns>The <see cref="IApplicationAddKeyRequestBuilder"/>.</returns>
        public IApplicationAddKeyRequestBuilder AddKey(
            KeyCredential keyCredential,
            string proof,
            PasswordCredential passwordCredential = null)
        {
            return new ApplicationAddKeyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.addKey"),
                this.Client,
                keyCredential,
                proof,
                passwordCredential);
        }

        /// <summary>
        /// Gets the request builder for ApplicationAddPassword.
        /// </summary>
        /// <returns>The <see cref="IApplicationAddPasswordRequestBuilder"/>.</returns>
        public IApplicationAddPasswordRequestBuilder AddPassword(
            PasswordCredential passwordCredential = null)
        {
            return new ApplicationAddPasswordRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.addPassword"),
                this.Client,
                passwordCredential);
        }

        /// <summary>
        /// Gets the request builder for ApplicationRemoveKey.
        /// </summary>
        /// <returns>The <see cref="IApplicationRemoveKeyRequestBuilder"/>.</returns>
        public IApplicationRemoveKeyRequestBuilder RemoveKey(
            Guid keyId,
            string proof)
        {
            return new ApplicationRemoveKeyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.removeKey"),
                this.Client,
                keyId,
                proof);
        }

        /// <summary>
        /// Gets the request builder for ApplicationRemovePassword.
        /// </summary>
        /// <returns>The <see cref="IApplicationRemovePasswordRequestBuilder"/>.</returns>
        public IApplicationRemovePasswordRequestBuilder RemovePassword(
            Guid keyId)
        {
            return new ApplicationRemovePasswordRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.removePassword"),
                this.Client,
                keyId);
        }
    
    }
}
