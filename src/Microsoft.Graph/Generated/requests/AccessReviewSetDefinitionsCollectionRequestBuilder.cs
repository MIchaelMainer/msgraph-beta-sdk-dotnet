// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type AccessReviewSetDefinitionsCollectionRequestBuilder.
    /// </summary>
    public partial class AccessReviewSetDefinitionsCollectionRequestBuilder : BaseRequestBuilder, IAccessReviewSetDefinitionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AccessReviewSetDefinitionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessReviewSetDefinitionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAccessReviewSetDefinitionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAccessReviewSetDefinitionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AccessReviewSetDefinitionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAccessReviewScheduleDefinitionRequestBuilder"/> for the specified AccessReviewSetAccessReviewScheduleDefinition.
        /// </summary>
        /// <param name="id">The ID for the AccessReviewSetAccessReviewScheduleDefinition.</param>
        /// <returns>The <see cref="IAccessReviewScheduleDefinitionRequestBuilder"/>.</returns>
        public IAccessReviewScheduleDefinitionRequestBuilder this[string id]
        {
            get
            {
                return new AccessReviewScheduleDefinitionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
