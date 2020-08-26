// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type EducationLinkResource.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationLinkResource : EducationResource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EducationLinkResource"/> class.
        /// </summary>
        public EducationLinkResource()
        {
            this.ODataType = "microsoft.graph.educationLinkResource";
        }

        /// <summary>
        /// Gets or sets link.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "link", Required = Newtonsoft.Json.Required.Default)]
        public string Link { get; set; }
    
    }
}