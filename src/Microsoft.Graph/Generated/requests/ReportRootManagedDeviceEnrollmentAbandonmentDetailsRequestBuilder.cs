// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ReportRootManagedDeviceEnrollmentAbandonmentDetailsRequestBuilder.
    /// </summary>
    public partial class ReportRootManagedDeviceEnrollmentAbandonmentDetailsRequestBuilder : BaseFunctionMethodRequestBuilder<IReportRootManagedDeviceEnrollmentAbandonmentDetailsRequest>, IReportRootManagedDeviceEnrollmentAbandonmentDetailsRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ReportRootManagedDeviceEnrollmentAbandonmentDetailsRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="skip">A skip parameter for the OData method call.</param>
        /// <param name="top">A top parameter for the OData method call.</param>
        /// <param name="filter">A filter parameter for the OData method call.</param>
        /// <param name="skipToken">A skipToken parameter for the OData method call.</param>
        public ReportRootManagedDeviceEnrollmentAbandonmentDetailsRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32? skip,
            Int32? top,
            string filter,
            string skipToken)
            : base(requestUrl, client)
        {
            this.SetParameter("skip", skip, true);
            this.SetParameter("top", top, true);
            this.SetParameter("filter", filter, true);
            this.SetParameter("skipToken", skipToken, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IReportRootManagedDeviceEnrollmentAbandonmentDetailsRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ReportRootManagedDeviceEnrollmentAbandonmentDetailsRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
