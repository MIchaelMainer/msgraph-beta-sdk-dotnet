// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type NoteDeltaCollectionPage.
    /// </summary>
    public partial class NoteDeltaCollectionPage : CollectionPage<Note>, INoteDeltaCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="INoteDeltaRequest"/> instance.
        /// </summary>
        public INoteDeltaRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new NoteDeltaRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}