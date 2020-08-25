// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IMethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The interface IAuditEventGetAuditActivityTypesCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<AuditEventGetAuditActivityTypesCollectionPage>))]
    public interface IAuditEventGetAuditActivityTypesCollectionPage : ICollectionPage<string>
    {
        /// <summary>
        /// Gets the next page <see cref="IAuditEventGetAuditActivityTypesRequest"/> instance.
        /// </summary>
        IAuditEventGetAuditActivityTypesRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
