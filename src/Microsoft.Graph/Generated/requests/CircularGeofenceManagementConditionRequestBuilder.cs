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
    /// The type CircularGeofenceManagementConditionRequestBuilder.
    /// </summary>
    public partial class CircularGeofenceManagementConditionRequestBuilder : LocationManagementConditionRequestBuilder, ICircularGeofenceManagementConditionRequestBuilder
    {

        /// <summary>
        /// Constructs a new CircularGeofenceManagementConditionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CircularGeofenceManagementConditionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ICircularGeofenceManagementConditionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ICircularGeofenceManagementConditionRequest Request(IEnumerable<Option> options)
        {
            return new CircularGeofenceManagementConditionRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
