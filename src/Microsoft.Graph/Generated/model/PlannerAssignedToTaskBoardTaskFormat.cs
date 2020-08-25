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
    /// The type Planner Assigned To Task Board Task Format.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlannerAssignedToTaskBoardTaskFormat : PlannerDelta
    {
    
		///<summary>
		/// The PlannerAssignedToTaskBoardTaskFormat constructor
		///</summary>
        public PlannerAssignedToTaskBoardTaskFormat()
        {
            this.ODataType = "microsoft.graph.plannerAssignedToTaskBoardTaskFormat";
        }
	
        /// <summary>
        /// Gets or sets unassigned order hint.
        /// Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unassignedOrderHint", Required = Newtonsoft.Json.Required.Default)]
        public string UnassignedOrderHint { get; set; }
    
        /// <summary>
        /// Gets or sets order hints by assignee.
        /// Dictionary of hints used to order tasks on the AssignedTo view of the Task Board. The key of each entry is one of the users the task is assigned to and the value is the order hint. The format of each value is defined as outlined here.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orderHintsByAssignee", Required = Newtonsoft.Json.Required.Default)]
        public PlannerOrderHintsByAssignee OrderHintsByAssignee { get; set; }
    
    }
}

