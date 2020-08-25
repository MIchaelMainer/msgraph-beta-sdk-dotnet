// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IPrinterShareRequestBuilder.
    /// </summary>
    public partial interface IPrinterShareRequestBuilder : IPrinterBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IPrinterShareRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IPrinterShareRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Printer.
        /// </summary>
        /// <returns>The <see cref="IPrinterWithReferenceRequestBuilder"/>.</returns>
        IPrinterWithReferenceRequestBuilder Printer { get; }

        /// <summary>
        /// Gets the request builder for AllowedUsers.
        /// </summary>
        /// <returns>The <see cref="IPrinterShareAllowedUsersCollectionRequestBuilder"/>.</returns>
        IPrinterShareAllowedUsersCollectionRequestBuilder AllowedUsers { get; }

        /// <summary>
        /// Gets the request builder for AllowedGroups.
        /// </summary>
        /// <returns>The <see cref="IPrinterShareAllowedGroupsCollectionRequestBuilder"/>.</returns>
        IPrinterShareAllowedGroupsCollectionRequestBuilder AllowedGroups { get; }
    
    }
}
