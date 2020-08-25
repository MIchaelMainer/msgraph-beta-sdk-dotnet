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
    /// The type DataClassificationServiceClassifyFileJobsCollectionRequestBuilder.
    /// </summary>
    public partial class DataClassificationServiceClassifyFileJobsCollectionRequestBuilder : BaseRequestBuilder, IDataClassificationServiceClassifyFileJobsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DataClassificationServiceClassifyFileJobsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DataClassificationServiceClassifyFileJobsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDataClassificationServiceClassifyFileJobsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDataClassificationServiceClassifyFileJobsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DataClassificationServiceClassifyFileJobsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IJobResponseBaseRequestBuilder"/> for the specified DataClassificationServiceJobResponseBase.
        /// </summary>
        /// <param name="id">The ID for the DataClassificationServiceJobResponseBase.</param>
        /// <returns>The <see cref="IJobResponseBaseRequestBuilder"/>.</returns>
        public IJobResponseBaseRequestBuilder this[string id]
        {
            get
            {
                return new JobResponseBaseRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
