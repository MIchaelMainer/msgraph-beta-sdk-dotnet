// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type PrivilegedRoleAssignmentWithReferenceRequestBuilder.
    /// </summary>
    public partial class PrivilegedRoleAssignmentWithReferenceRequestBuilder : BaseRequestBuilder, IPrivilegedRoleAssignmentWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new PrivilegedRoleAssignmentWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrivilegedRoleAssignmentWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPrivilegedRoleAssignmentWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPrivilegedRoleAssignmentWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new PrivilegedRoleAssignmentWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the privilegedRoleAssignment.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentReferenceRequestBuilder"/>.</returns>
        public IPrivilegedRoleAssignmentReferenceRequestBuilder Reference
        {
            get
            {
                return new PrivilegedRoleAssignmentReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
