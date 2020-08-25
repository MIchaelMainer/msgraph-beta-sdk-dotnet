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
    /// The type Swap Shifts Change Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SwapShiftsChangeRequestObject : OfferShiftRequestObject
    {
    
		///<summary>
		/// The SwapShiftsChangeRequest constructor
		///</summary>
        public SwapShiftsChangeRequestObject()
        {
            this.ODataType = "microsoft.graph.swapShiftsChangeRequest";
        }
	
        /// <summary>
        /// Gets or sets recipient shift id.
        /// ShiftId for the recipient user with whom the request is to swap.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipientShiftId", Required = Newtonsoft.Json.Required.Default)]
        public string RecipientShiftId { get; set; }
    
    }
}

