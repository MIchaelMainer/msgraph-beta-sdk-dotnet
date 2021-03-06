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
    /// The type DeviceCommandsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceCommandsCollectionRequestBuilder : BaseRequestBuilder, IDeviceCommandsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceCommandsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceCommandsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceCommandsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceCommandsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceCommandsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICommandRequestBuilder"/> for the specified DeviceCommand.
        /// </summary>
        /// <param name="id">The ID for the DeviceCommand.</param>
        /// <returns>The <see cref="ICommandRequestBuilder"/>.</returns>
        public ICommandRequestBuilder this[string id]
        {
            get
            {
                return new CommandRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
