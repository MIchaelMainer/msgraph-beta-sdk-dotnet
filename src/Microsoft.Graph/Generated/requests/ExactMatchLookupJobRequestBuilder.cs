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
    /// The type ExactMatchLookupJobRequestBuilder.
    /// </summary>
    public partial class ExactMatchLookupJobRequestBuilder : ExactMatchJobBaseRequestBuilder, IExactMatchLookupJobRequestBuilder
    {

        /// <summary>
        /// Constructs a new ExactMatchLookupJobRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ExactMatchLookupJobRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IExactMatchLookupJobRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IExactMatchLookupJobRequest Request(IEnumerable<Option> options)
        {
            return new ExactMatchLookupJobRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for MatchingRows.
        /// </summary>
        /// <returns>The <see cref="IExactMatchLookupJobMatchingRowsCollectionRequestBuilder"/>.</returns>
        public IExactMatchLookupJobMatchingRowsCollectionRequestBuilder MatchingRows
        {
            get
            {
                return new ExactMatchLookupJobMatchingRowsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("matchingRows"), this.Client);
            }
        }
    
    }
}
