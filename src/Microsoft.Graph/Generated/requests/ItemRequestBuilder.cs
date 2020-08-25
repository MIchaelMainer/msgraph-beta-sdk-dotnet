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
    /// The type ItemRequestBuilder.
    /// </summary>
    public partial class ItemRequestBuilder : EntityRequestBuilder, IItemRequestBuilder
    {

        /// <summary>
        /// Constructs a new ItemRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ItemRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IItemRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IItemRequest Request(IEnumerable<Option> options)
        {
            return new ItemRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Picture.
        /// </summary>
        /// <returns>The <see cref="IItemPictureCollectionRequestBuilder"/>.</returns>
        public IItemPictureCollectionRequestBuilder Picture
        {
            get
            {
                return new ItemPictureCollectionRequestBuilder(this.AppendSegmentToRequestUrl("picture"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ItemCategory.
        /// </summary>
        /// <returns>The <see cref="IItemCategoryRequestBuilder"/>.</returns>
        public IItemCategoryRequestBuilder ItemCategory
        {
            get
            {
                return new ItemCategoryRequestBuilder(this.AppendSegmentToRequestUrl("itemCategory"), this.Client);
            }
        }
    
    }
}
