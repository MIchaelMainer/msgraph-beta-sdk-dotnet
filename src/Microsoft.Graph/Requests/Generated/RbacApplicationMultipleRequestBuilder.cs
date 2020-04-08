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
    /// The type RbacApplicationMultipleRequestBuilder.
    /// </summary>
    public partial class RbacApplicationMultipleRequestBuilder : EntityRequestBuilder, IRbacApplicationMultipleRequestBuilder
    {

        /// <summary>
        /// Constructs a new RbacApplicationMultipleRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public RbacApplicationMultipleRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IRbacApplicationMultipleRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IRbacApplicationMultipleRequest Request(IEnumerable<Option> options)
        {
            return new RbacApplicationMultipleRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for RoleDefinitions.
        /// </summary>
        /// <returns>The <see cref="IRbacApplicationMultipleRoleDefinitionsCollectionRequestBuilder"/>.</returns>
        public IRbacApplicationMultipleRoleDefinitionsCollectionRequestBuilder RoleDefinitions
        {
            get
            {
                return new RbacApplicationMultipleRoleDefinitionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("roleDefinitions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RoleAssignments.
        /// </summary>
        /// <returns>The <see cref="IRbacApplicationMultipleRoleAssignmentsCollectionRequestBuilder"/>.</returns>
        public IRbacApplicationMultipleRoleAssignmentsCollectionRequestBuilder RoleAssignments
        {
            get
            {
                return new RbacApplicationMultipleRoleAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("roleAssignments"), this.Client);
            }
        }
    
    }
}
