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
    /// The type Device Health Script Run Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceHealthScriptRunSummary : Entity
    {
    
		///<summary>
		/// The DeviceHealthScriptRunSummary constructor
		///</summary>
        public DeviceHealthScriptRunSummary()
        {
            this.ODataType = "microsoft.graph.deviceHealthScriptRunSummary";
        }
	
        /// <summary>
        /// Gets or sets no issue detected device count.
        /// Number of devices for which the detection script did not find an issue and the device is healthy
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "noIssueDetectedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NoIssueDetectedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets issue detected device count.
        /// Number of devices for which the detection script found an issue
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issueDetectedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? IssueDetectedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets detection script error device count.
        /// Number of devices on which the detection script execution encountered an error and did not complete
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectionScriptErrorDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DetectionScriptErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets detection script pending device count.
        /// Number of devices which have not yet run the latest version of the device health script
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectionScriptPendingDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DetectionScriptPendingDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets issue remediated device count.
        /// Number of devices for which the remediation script was able to resolve the detected issue
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issueRemediatedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? IssueRemediatedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets remediation skipped device count.
        /// Number of devices for which remediation was skipped
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remediationSkippedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RemediationSkippedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets issue reoccurred device count.
        /// Number of devices for which the remediation script executed successfully but failed to resolve the detected issue
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issueReoccurredDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? IssueReoccurredDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets remediation script error device count.
        /// Number of devices for which the remediation script execution encountered an error and did not complete
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remediationScriptErrorDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RemediationScriptErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets last script run date time.
        /// Last run time for the script across all devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastScriptRunDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastScriptRunDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets issue remediated cumulative device count.
        /// Number of devices that were remediated over the last 30 days
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issueRemediatedCumulativeDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? IssueRemediatedCumulativeDeviceCount { get; set; }
    
    }
}
