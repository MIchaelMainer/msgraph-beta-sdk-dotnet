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
    /// The type PrinterShareAllowedUsersCollectionRequestBuilder.
    /// </summary>
    public partial class PrinterShareAllowedUsersCollectionRequestBuilder : BaseRequestBuilder, IPrinterShareAllowedUsersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new PrinterShareAllowedUsersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrinterShareAllowedUsersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPrinterShareAllowedUsersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPrinterShareAllowedUsersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new PrinterShareAllowedUsersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPrintUserIdentityRequestBuilder"/> for the specified PrinterSharePrintUserIdentity.
        /// </summary>
        /// <param name="id">The ID for the PrinterSharePrintUserIdentity.</param>
        /// <returns>The <see cref="IPrintUserIdentityRequestBuilder"/>.</returns>
        public IPrintUserIdentityRequestBuilder this[string id]
        {
            get
            {
                return new PrintUserIdentityRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
