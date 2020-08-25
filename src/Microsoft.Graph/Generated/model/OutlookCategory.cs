// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Outlook Category.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OutlookCategory : Entity
    {
    
		///<summary>
		/// The OutlookCategory constructor
		///</summary>
        public OutlookCategory()
        {
            this.ODataType = "microsoft.graph.outlookCategory";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// A unique name that identifies a category in the user's mailbox. After a category is created, the name cannot be changed. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets color.
        /// A pre-set color constant that characterizes a category, and that is mapped to one of 25 predefined colors. See the note below.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "color", Required = Newtonsoft.Json.Required.Default)]
        public CategoryColor? Color { get; set; }
    
    }
}

