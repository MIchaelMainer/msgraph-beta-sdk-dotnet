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
    /// The type BitLockerSystemDrivePolicy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class BitLockerSystemDrivePolicy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BitLockerSystemDrivePolicy"/> class.
        /// </summary>
        public BitLockerSystemDrivePolicy()
        {
            this.ODataType = "microsoft.graph.bitLockerSystemDrivePolicy";
        }

        /// <summary>
        /// Gets or sets encryptionMethod.
        /// Select the encryption method for operating system drives.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptionMethod", Required = Newtonsoft.Json.Required.Default)]
        public BitLockerEncryptionMethod? EncryptionMethod { get; set; }
    
        /// <summary>
        /// Gets or sets startupAuthenticationRequired.
        /// Require additional authentication at startup.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startupAuthenticationRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? StartupAuthenticationRequired { get; set; }
    
        /// <summary>
        /// Gets or sets startupAuthenticationBlockWithoutTpmChip.
        /// Indicates whether to allow BitLocker without a compatible TPM (requires a password or a startup key on a USB flash drive).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startupAuthenticationBlockWithoutTpmChip", Required = Newtonsoft.Json.Required.Default)]
        public bool? StartupAuthenticationBlockWithoutTpmChip { get; set; }
    
        /// <summary>
        /// Gets or sets startupAuthenticationTpmUsage.
        /// Indicates if TPM startup is allowed/required/disallowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startupAuthenticationTpmUsage", Required = Newtonsoft.Json.Required.Default)]
        public ConfigurationUsage? StartupAuthenticationTpmUsage { get; set; }
    
        /// <summary>
        /// Gets or sets startupAuthenticationTpmPinUsage.
        /// Indicates if TPM startup pin is allowed/required/disallowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startupAuthenticationTpmPinUsage", Required = Newtonsoft.Json.Required.Default)]
        public ConfigurationUsage? StartupAuthenticationTpmPinUsage { get; set; }
    
        /// <summary>
        /// Gets or sets startupAuthenticationTpmKeyUsage.
        /// Indicates if TPM startup key is allowed/required/disallowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startupAuthenticationTpmKeyUsage", Required = Newtonsoft.Json.Required.Default)]
        public ConfigurationUsage? StartupAuthenticationTpmKeyUsage { get; set; }
    
        /// <summary>
        /// Gets or sets startupAuthenticationTpmPinAndKeyUsage.
        /// Indicates if TPM startup pin key and key are allowed/required/disallowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startupAuthenticationTpmPinAndKeyUsage", Required = Newtonsoft.Json.Required.Default)]
        public ConfigurationUsage? StartupAuthenticationTpmPinAndKeyUsage { get; set; }
    
        /// <summary>
        /// Gets or sets minimumPinLength.
        /// Indicates the minimum length of startup pin. Valid values 4 to 20
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumPinLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MinimumPinLength { get; set; }
    
        /// <summary>
        /// Gets or sets recoveryOptions.
        /// Allows to recover BitLocker encrypted operating system drives in the absence of the required startup key information. This policy setting is applied when you turn on BitLocker.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recoveryOptions", Required = Newtonsoft.Json.Required.Default)]
        public BitLockerRecoveryOptions RecoveryOptions { get; set; }
    
        /// <summary>
        /// Gets or sets prebootRecoveryEnableMessageAndUrl.
        /// Enable pre-boot recovery message and Url. If requireStartupAuthentication is false, this value does not affect.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prebootRecoveryEnableMessageAndUrl", Required = Newtonsoft.Json.Required.Default)]
        public bool? PrebootRecoveryEnableMessageAndUrl { get; set; }
    
        /// <summary>
        /// Gets or sets prebootRecoveryMessage.
        /// Defines a custom recovery message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prebootRecoveryMessage", Required = Newtonsoft.Json.Required.Default)]
        public string PrebootRecoveryMessage { get; set; }
    
        /// <summary>
        /// Gets or sets prebootRecoveryUrl.
        /// Defines a custom recovery URL.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prebootRecoveryUrl", Required = Newtonsoft.Json.Required.Default)]
        public string PrebootRecoveryUrl { get; set; }
    
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
