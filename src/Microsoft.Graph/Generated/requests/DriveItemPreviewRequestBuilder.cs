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
    /// The type DriveItemPreviewRequestBuilder.
    /// </summary>
    public partial class DriveItemPreviewRequestBuilder : BaseActionMethodRequestBuilder<IDriveItemPreviewRequest>, IDriveItemPreviewRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DriveItemPreviewRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="viewer">A viewer parameter for the OData method call.</param>
        /// <param name="chromeless">A chromeless parameter for the OData method call.</param>
        /// <param name="allowEdit">A allowEdit parameter for the OData method call.</param>
        /// <param name="page">A page parameter for the OData method call.</param>
        /// <param name="zoom">A zoom parameter for the OData method call.</param>
        public DriveItemPreviewRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string viewer,
            bool? chromeless,
            bool? allowEdit,
            string page,
            double? zoom)
            : base(requestUrl, client)
        {
            this.SetParameter("viewer", viewer, true);
            this.SetParameter("chromeless", chromeless, true);
            this.SetParameter("allowEdit", allowEdit, true);
            this.SetParameter("page", page, true);
            this.SetParameter("zoom", zoom, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDriveItemPreviewRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DriveItemPreviewRequest(functionUrl, this.Client, options);

            if (this.HasParameter("viewer"))
            {
                request.RequestBody.Viewer = this.GetParameter<string>("viewer");
            }

            if (this.HasParameter("chromeless"))
            {
                request.RequestBody.Chromeless = this.GetParameter<bool?>("chromeless");
            }

            if (this.HasParameter("allowEdit"))
            {
                request.RequestBody.AllowEdit = this.GetParameter<bool?>("allowEdit");
            }

            if (this.HasParameter("page"))
            {
                request.RequestBody.Page = this.GetParameter<string>("page");
            }

            if (this.HasParameter("zoom"))
            {
                request.RequestBody.Zoom = this.GetParameter<double?>("zoom");
            }

            return request;
        }
    }
}
