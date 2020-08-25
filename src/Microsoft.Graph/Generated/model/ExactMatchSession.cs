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
    /// The type Exact Match Session.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ExactMatchSession : ExactMatchJobBase
    {
    
		///<summary>
		/// The ExactMatchSession constructor
		///</summary>
        public ExactMatchSession()
        {
            this.ODataType = "microsoft.graph.exactMatchSession";
        }
	
        /// <summary>
        /// Gets or sets datastore id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "datastoreId", Required = Newtonsoft.Json.Required.Default)]
        public string DatastoreId { get; set; }
    
        /// <summary>
        /// Gets or sets upload agent id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uploadAgentId", Required = Newtonsoft.Json.Required.Default)]
        public string UploadAgentId { get; set; }
    
        /// <summary>
        /// Gets or sets fields.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fields", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Fields { get; set; }
    
        /// <summary>
        /// Gets or sets file name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileName", Required = Newtonsoft.Json.Required.Default)]
        public string FileName { get; set; }
    
        /// <summary>
        /// Gets or sets checksum.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "checksum", Required = Newtonsoft.Json.Required.Default)]
        public string Checksum { get; set; }
    
        /// <summary>
        /// Gets or sets data upload uri.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataUploadURI", Required = Newtonsoft.Json.Required.Default)]
        public string DataUploadURI { get; set; }
    
        /// <summary>
        /// Gets or sets remaining block count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remainingBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RemainingBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets total block count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets upload completion date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uploadCompletionDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? UploadCompletionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets processing completion date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processingCompletionDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ProcessingCompletionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets rows per block.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rowsPerBlock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RowsPerBlock { get; set; }
    
        /// <summary>
        /// Gets or sets total job count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalJobCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalJobCount { get; set; }
    
        /// <summary>
        /// Gets or sets remaining job count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remainingJobCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RemainingJobCount { get; set; }
    
        /// <summary>
        /// Gets or sets salt.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salt", Required = Newtonsoft.Json.Required.Default)]
        public string Salt { get; set; }
    
        /// <summary>
        /// Gets or sets upload agent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uploadAgent", Required = Newtonsoft.Json.Required.Default)]
        public ExactMatchUploadAgent UploadAgent { get; set; }
    
    }
}

