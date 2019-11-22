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
    /// The type Customer Payment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CustomerPayment : Entity
    {
    
		///<summary>
		/// The CustomerPayment constructor
		///</summary>
        public CustomerPayment()
        {
            this.ODataType = "microsoft.graph.customerPayment";
        }
	
        /// <summary>
        /// Gets or sets journal display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "journalDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string JournalDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets line number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lineNumber", Required = Newtonsoft.Json.Required.Default)]
        public Int32? LineNumber { get; set; }
    
        /// <summary>
        /// Gets or sets customer id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customerId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? CustomerId { get; set; }
    
        /// <summary>
        /// Gets or sets customer number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customerNumber", Required = Newtonsoft.Json.Required.Default)]
        public string CustomerNumber { get; set; }
    
        /// <summary>
        /// Gets or sets contact id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactId", Required = Newtonsoft.Json.Required.Default)]
        public string ContactId { get; set; }
    
        /// <summary>
        /// Gets or sets posting date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postingDate", Required = Newtonsoft.Json.Required.Default)]
        public Date PostingDate { get; set; }
    
        /// <summary>
        /// Gets or sets document number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "documentNumber", Required = Newtonsoft.Json.Required.Default)]
        public string DocumentNumber { get; set; }
    
        /// <summary>
        /// Gets or sets external document number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalDocumentNumber", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalDocumentNumber { get; set; }
    
        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? Amount { get; set; }
    
        /// <summary>
        /// Gets or sets applies to invoice id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliesToInvoiceId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? AppliesToInvoiceId { get; set; }
    
        /// <summary>
        /// Gets or sets applies to invoice number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliesToInvoiceNumber", Required = Newtonsoft.Json.Required.Default)]
        public string AppliesToInvoiceNumber { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets comment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "comment", Required = Newtonsoft.Json.Required.Default)]
        public string Comment { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets customer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customer", Required = Newtonsoft.Json.Required.Default)]
        public Customer Customer { get; set; }
    
    }
}

