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
    /// The type DailySchedule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DailySchedule : RunSchedule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailySchedule"/> class.
        /// </summary>
        public DailySchedule()
        {
            this.ODataType = "microsoft.graph.dailySchedule";
        }

        /// <summary>
        /// Gets or sets interval.
        /// Interval in number of days
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interval", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Interval { get; set; }
    
    }
}
