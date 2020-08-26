// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type MediaStream.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter))]
    public partial class MediaStream
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaStream"/> class.
        /// </summary>
        public MediaStream()
        {
            this.ODataType = "microsoft.graph.callRecords.mediaStream";
        }

        /// <summary>
        /// Gets or sets streamId.
        /// Unique identifier for the stream.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "streamId", Required = Newtonsoft.Json.Required.Default)]
        public string StreamId { get; set; }
    
        /// <summary>
        /// Gets or sets startDateTime.
        /// UTC time when the stream started. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets endDateTime.
        /// UTC time when the stream ended. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets streamDirection.
        /// Indicates the direction of the media stream. Possible values are: callerToCallee, calleeToCaller.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "streamDirection", Required = Newtonsoft.Json.Required.Default)]
        public MediaStreamDirection? StreamDirection { get; set; }
    
        /// <summary>
        /// Gets or sets averageAudioDegradation.
        /// Average Network Mean Opinion Score degradation for stream. Represents how much the network loss and jitter has impacted the quality of received audio.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageAudioDegradation", Required = Newtonsoft.Json.Required.Default)]
        public Single? AverageAudioDegradation { get; set; }
    
        /// <summary>
        /// Gets or sets averageJitter.
        /// Average jitter for the stream computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageJitter", Required = Newtonsoft.Json.Required.Default)]
        public Microsoft.Graph.Duration AverageJitter { get; set; }
    
        /// <summary>
        /// Gets or sets maxJitter.
        /// Maximum jitter for the stream computed as specified in RFC 3550, denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxJitter", Required = Newtonsoft.Json.Required.Default)]
        public Microsoft.Graph.Duration MaxJitter { get; set; }
    
        /// <summary>
        /// Gets or sets averagePacketLossRate.
        /// Average packet loss rate for stream.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averagePacketLossRate", Required = Newtonsoft.Json.Required.Default)]
        public Single? AveragePacketLossRate { get; set; }
    
        /// <summary>
        /// Gets or sets maxPacketLossRate.
        /// Maximum packet loss rate for the stream.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxPacketLossRate", Required = Newtonsoft.Json.Required.Default)]
        public Single? MaxPacketLossRate { get; set; }
    
        /// <summary>
        /// Gets or sets averageRatioOfConcealedSamples.
        /// Ratio of the number of audio frames with samples generated by packet loss concealment to the total number of audio frames.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageRatioOfConcealedSamples", Required = Newtonsoft.Json.Required.Default)]
        public Single? AverageRatioOfConcealedSamples { get; set; }
    
        /// <summary>
        /// Gets or sets maxRatioOfConcealedSamples.
        /// Maximum ratio of packets concealed by the healer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxRatioOfConcealedSamples", Required = Newtonsoft.Json.Required.Default)]
        public Single? MaxRatioOfConcealedSamples { get; set; }
    
        /// <summary>
        /// Gets or sets averageRoundTripTime.
        /// Average network propagation round-trip time computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageRoundTripTime", Required = Newtonsoft.Json.Required.Default)]
        public Microsoft.Graph.Duration AverageRoundTripTime { get; set; }
    
        /// <summary>
        /// Gets or sets maxRoundTripTime.
        /// Maximum network propagation round-trip time computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxRoundTripTime", Required = Newtonsoft.Json.Required.Default)]
        public Microsoft.Graph.Duration MaxRoundTripTime { get; set; }
    
        /// <summary>
        /// Gets or sets packetUtilization.
        /// Packet count for the stream.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "packetUtilization", Required = Newtonsoft.Json.Required.Default)]
        public Int64? PacketUtilization { get; set; }
    
        /// <summary>
        /// Gets or sets averageBandwidthEstimate.
        /// Average estimated bandwidth available between two endpoints in bits per second.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageBandwidthEstimate", Required = Newtonsoft.Json.Required.Default)]
        public Int64? AverageBandwidthEstimate { get; set; }
    
        /// <summary>
        /// Gets or sets wasMediaBypassed.
        /// True if the media stream bypassed the Mediation Server and went straight between client and PSTN Gateway/PBX, false otherwise.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wasMediaBypassed", Required = Newtonsoft.Json.Required.Default)]
        public bool? WasMediaBypassed { get; set; }
    
        /// <summary>
        /// Gets or sets postForwardErrorCorrectionPacketLossRate.
        /// Packet loss rate after FEC has been applied aggregated across all video streams and codecs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postForwardErrorCorrectionPacketLossRate", Required = Newtonsoft.Json.Required.Default)]
        public Single? PostForwardErrorCorrectionPacketLossRate { get; set; }
    
        /// <summary>
        /// Gets or sets averageVideoFrameLossPercentage.
        /// Average percentage of video frames lost as displayed to the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageVideoFrameLossPercentage", Required = Newtonsoft.Json.Required.Default)]
        public Single? AverageVideoFrameLossPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets averageReceivedFrameRate.
        /// Average frames per second received for all video streams computed over the duration of the session.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageReceivedFrameRate", Required = Newtonsoft.Json.Required.Default)]
        public Single? AverageReceivedFrameRate { get; set; }
    
        /// <summary>
        /// Gets or sets lowFrameRateRatio.
        /// Fraction of the call where frame rate is less than 7.5 frames per second.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lowFrameRateRatio", Required = Newtonsoft.Json.Required.Default)]
        public Single? LowFrameRateRatio { get; set; }
    
        /// <summary>
        /// Gets or sets averageVideoPacketLossRate.
        /// Average fraction of packets lost, as specified in [RFC 3550][], computed over the duration of the session.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageVideoPacketLossRate", Required = Newtonsoft.Json.Required.Default)]
        public Single? AverageVideoPacketLossRate { get; set; }
    
        /// <summary>
        /// Gets or sets averageVideoFrameRate.
        /// Average frames per second received for a video stream, computed over the duration of the session.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageVideoFrameRate", Required = Newtonsoft.Json.Required.Default)]
        public Single? AverageVideoFrameRate { get; set; }
    
        /// <summary>
        /// Gets or sets lowVideoProcessingCapabilityRatio.
        /// Fraction of the call that the client is running less than 70% expected video processing capability.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lowVideoProcessingCapabilityRatio", Required = Newtonsoft.Json.Required.Default)]
        public Single? LowVideoProcessingCapabilityRatio { get; set; }
    
        /// <summary>
        /// Gets or sets averageAudioNetworkJitter.
        /// Average jitter for the stream computed as specified in [RFC 3550][], denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageAudioNetworkJitter", Required = Newtonsoft.Json.Required.Default)]
        public Microsoft.Graph.Duration AverageAudioNetworkJitter { get; set; }
    
        /// <summary>
        /// Gets or sets maxAudioNetworkJitter.
        /// Maximum of audio network jitter computed over each of the 20 second windows during the session, denoted in [ISO 8601][] format. For example, 1 second is denoted as 'PT1S', where 'P' is the duration designator, 'T' is the time designator, and 'S' is the second designator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxAudioNetworkJitter", Required = Newtonsoft.Json.Required.Default)]
        public Microsoft.Graph.Duration MaxAudioNetworkJitter { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}