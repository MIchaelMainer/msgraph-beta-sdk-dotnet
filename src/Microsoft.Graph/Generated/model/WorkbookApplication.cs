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
    /// The type Workbook Application.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookApplication : Entity
    {
    
		///<summary>
		/// The WorkbookApplication constructor
		///</summary>
        public WorkbookApplication()
        {
            this.ODataType = "microsoft.graph.workbookApplication";
        }
	
        /// <summary>
        /// Gets or sets calculation mode.
        /// Returns the calculation mode used in the workbook. Possible values are: Automatic, AutomaticExceptTables, Manual.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calculationMode", Required = Newtonsoft.Json.Required.Default)]
        public string CalculationMode { get; set; }
    
    }
}

