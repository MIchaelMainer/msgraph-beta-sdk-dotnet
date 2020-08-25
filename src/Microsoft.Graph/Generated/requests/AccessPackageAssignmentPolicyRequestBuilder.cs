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
    /// The type AccessPackageAssignmentPolicyRequestBuilder.
    /// </summary>
    public partial class AccessPackageAssignmentPolicyRequestBuilder : EntityRequestBuilder, IAccessPackageAssignmentPolicyRequestBuilder
    {

        /// <summary>
        /// Constructs a new AccessPackageAssignmentPolicyRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessPackageAssignmentPolicyRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAccessPackageAssignmentPolicyRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAccessPackageAssignmentPolicyRequest Request(IEnumerable<Option> options)
        {
            return new AccessPackageAssignmentPolicyRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AccessPackage.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageWithReferenceRequestBuilder"/>.</returns>
        public IAccessPackageWithReferenceRequestBuilder AccessPackage
        {
            get
            {
                return new AccessPackageWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("accessPackage"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageCatalog.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageCatalogRequestBuilder"/>.</returns>
        public IAccessPackageCatalogRequestBuilder AccessPackageCatalog
        {
            get
            {
                return new AccessPackageCatalogRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageCatalog"), this.Client);
            }
        }
    
    }
}
