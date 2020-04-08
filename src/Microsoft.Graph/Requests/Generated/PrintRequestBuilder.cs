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
    /// The type PrintRequestBuilder.
    /// </summary>
    public partial class PrintRequestBuilder : EntityRequestBuilder, IPrintRequestBuilder
    {

        /// <summary>
        /// Constructs a new PrintRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrintRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPrintRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPrintRequest Request(IEnumerable<Option> options)
        {
            return new PrintRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Services.
        /// </summary>
        /// <returns>The <see cref="IPrintServicesCollectionRequestBuilder"/>.</returns>
        public IPrintServicesCollectionRequestBuilder Services
        {
            get
            {
                return new PrintServicesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("services"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Printers.
        /// </summary>
        /// <returns>The <see cref="IPrintPrintersCollectionRequestBuilder"/>.</returns>
        public IPrintPrintersCollectionRequestBuilder Printers
        {
            get
            {
                return new PrintPrintersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("printers"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Connectors.
        /// </summary>
        /// <returns>The <see cref="IPrintConnectorsCollectionRequestBuilder"/>.</returns>
        public IPrintConnectorsCollectionRequestBuilder Connectors
        {
            get
            {
                return new PrintConnectorsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("connectors"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for PrinterShares.
        /// </summary>
        /// <returns>The <see cref="IPrintPrinterSharesCollectionRequestBuilder"/>.</returns>
        public IPrintPrinterSharesCollectionRequestBuilder PrinterShares
        {
            get
            {
                return new PrintPrinterSharesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("printerShares"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Reports.
        /// </summary>
        /// <returns>The <see cref="IPrintReportsCollectionRequestBuilder"/>.</returns>
        public IPrintReportsCollectionRequestBuilder Reports
        {
            get
            {
                return new PrintReportsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("reports"), this.Client);
            }
        }
    
    }
}
