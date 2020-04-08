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
    /// The type ReportRootMonthlyPrintUsageSummariesByUserCollectionRequestBuilder.
    /// </summary>
    public partial class ReportRootMonthlyPrintUsageSummariesByUserCollectionRequestBuilder : BaseRequestBuilder, IReportRootMonthlyPrintUsageSummariesByUserCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ReportRootMonthlyPrintUsageSummariesByUserCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ReportRootMonthlyPrintUsageSummariesByUserCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IReportRootMonthlyPrintUsageSummariesByUserCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IReportRootMonthlyPrintUsageSummariesByUserCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ReportRootMonthlyPrintUsageSummariesByUserCollectionRequest(this.RequestUrl, this.Client, options);
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
