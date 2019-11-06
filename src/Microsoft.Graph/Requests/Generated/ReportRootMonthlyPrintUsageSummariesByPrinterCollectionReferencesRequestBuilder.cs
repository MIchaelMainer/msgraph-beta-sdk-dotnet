// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequestBuilder.
    /// </summary>
    public partial class ReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequestBuilder : BaseRequestBuilder, IReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequest(this.RequestUrl, this.Client, options);
        }
    }
}