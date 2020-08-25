// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IManagedDeviceLogCollectionRequestsCollectionRequestBuilder.
    /// </summary>
    public partial interface IManagedDeviceLogCollectionRequestsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagedDeviceLogCollectionRequestsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagedDeviceLogCollectionRequestsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceLogCollectionResponseRequestBuilder"/> for the specified DeviceLogCollectionResponse.
        /// </summary>
        /// <param name="id">The ID for the DeviceLogCollectionResponse.</param>
        /// <returns>The <see cref="IDeviceLogCollectionResponseRequestBuilder"/>.</returns>
        IDeviceLogCollectionResponseRequestBuilder this[string id] { get; }

        
    }
}
