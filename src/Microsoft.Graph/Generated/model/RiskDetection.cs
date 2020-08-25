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
    /// The type Risk Detection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RiskDetection : Entity
    {
    
		///<summary>
		/// The RiskDetection constructor
		///</summary>
        public RiskDetection()
        {
            this.ODataType = "microsoft.graph.riskDetection";
        }
	
        /// <summary>
        /// Gets or sets request id.
        /// Request ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestId", Required = Newtonsoft.Json.Required.Default)]
        public string RequestId { get; set; }
    
        /// <summary>
        /// Gets or sets correlation id.
        /// Correlation ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "correlationId", Required = Newtonsoft.Json.Required.Default)]
        public string CorrelationId { get; set; }
    
        /// <summary>
        /// Gets or sets risk event type.
        /// The type of risk event detected. The possible values are unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence, genericadminConfirmedUserCompromised, mcasImpossibleTravel, mcasSuspiciousInboxManipulationRules, investigationsThreatIntelligenceSigninLinked, maliciousIPAddressValidCredentialsBlockedIP, and unknownFutureValue. If the risk detection is a premium detection, will show generic
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskEventType", Required = Newtonsoft.Json.Required.Default)]
        public string RiskEventType { get; set; }
    
        /// <summary>
        /// Gets or sets risk type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskType", Required = Newtonsoft.Json.Required.Default)]
        public RiskEventType? RiskType { get; set; }
    
        /// <summary>
        /// Gets or sets risk state.
        /// The state of a detected risky user or sign-in. Possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskState", Required = Newtonsoft.Json.Required.Default)]
        public RiskState? RiskState { get; set; }
    
        /// <summary>
        /// Gets or sets risk level.
        /// Level of the detected risk. Possible values are: low, medium, high, hidden, none, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskLevel", Required = Newtonsoft.Json.Required.Default)]
        public RiskLevel? RiskLevel { get; set; }
    
        /// <summary>
        /// Gets or sets risk detail.
        /// Details of the detected risk. Possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskDetail", Required = Newtonsoft.Json.Required.Default)]
        public RiskDetail? RiskDetail { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// Source of the risk detection. For example, 'activeDirectory'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "source", Required = Newtonsoft.Json.Required.Default)]
        public string Source { get; set; }
    
        /// <summary>
        /// Gets or sets detection timing type.
        /// Timing of the detected risk (real-time/offline). Possible values are: notDefined, realtime, nearRealtime, offline, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectionTimingType", Required = Newtonsoft.Json.Required.Default)]
        public RiskDetectionTimingType? DetectionTimingType { get; set; }
    
        /// <summary>
        /// Gets or sets activity.
        /// Indicates the activity type the detected risk is linked to. . Possible values are: signin, user, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activity", Required = Newtonsoft.Json.Required.Default)]
        public ActivityType? Activity { get; set; }
    
        /// <summary>
        /// Gets or sets token issuer type.
        /// Indicates the type of token issuer for the detected sign-in risk. Possible values are: AzureAD, ADFederationServices, UnknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenIssuerType", Required = Newtonsoft.Json.Required.Default)]
        public TokenIssuerType? TokenIssuerType { get; set; }
    
        /// <summary>
        /// Gets or sets ip address.
        /// Provides the IP address of the client from where the risk occurred.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipAddress", Required = Newtonsoft.Json.Required.Default)]
        public string IpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// Location of the sign-in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "location", Required = Newtonsoft.Json.Required.Default)]
        public SignInLocation Location { get; set; }
    
        /// <summary>
        /// Gets or sets activity date time.
        /// Date and time that the risky activity occurred.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ActivityDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets detected date time.
        /// Date and time that the risk was detected.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DetectedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last updated date time.
        /// Date and time that the risk detection was last updated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUpdatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// Unique ID of the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// The user principal name (UPN) of the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The user principal name (UPN) of the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets additional info.
        /// Additional information associated with the risk detection in JSON format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "additionalInfo", Required = Newtonsoft.Json.Required.Default)]
        public string AdditionalInfo { get; set; }
    
    }
}

