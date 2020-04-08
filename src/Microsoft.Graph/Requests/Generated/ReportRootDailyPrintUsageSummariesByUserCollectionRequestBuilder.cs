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
    /// The type ReportRootDailyPrintUsageSummariesByUserCollectionRequestBuilder.
    /// </summary>
    public partial class ReportRootDailyPrintUsageSummariesByUserCollectionRequestBuilder : BaseRequestBuilder, IReportRootDailyPrintUsageSummariesByUserCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ReportRootDailyPrintUsageSummariesByUserCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ReportRootDailyPrintUsageSummariesByUserCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IReportRootDailyPrintUsageSummariesByUserCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IReportRootDailyPrintUsageSummariesByUserCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ReportRootDailyPrintUsageSummariesByUserCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPrintUsageSummaryByUserRequestBuilder"/> for the specified ReportRootPrintUsageSummaryByUser.
        /// </summary>
        /// <param name="id">The ID for the ReportRootPrintUsageSummaryByUser.</param>
        /// <returns>The <see cref="IPrintUsageSummaryByUserRequestBuilder"/>.</returns>
        public IPrintUsageSummaryByUserRequestBuilder this[string id]
        {
            get
            {
                return new PrintUsageSummaryByUserRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
