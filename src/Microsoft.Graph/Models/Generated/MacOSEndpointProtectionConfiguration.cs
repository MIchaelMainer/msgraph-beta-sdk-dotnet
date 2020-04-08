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
    /// The type Mac OSEndpoint Protection Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MacOSEndpointProtectionConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The MacOSEndpointProtectionConfiguration constructor
		///</summary>
        public MacOSEndpointProtectionConfiguration()
        {
            this.ODataType = "microsoft.graph.macOSEndpointProtectionConfiguration";
        }
	
        /// <summary>
        /// Gets or sets gatekeeper allowed app source.
        /// System and Privacy setting that determines which download locations apps can be run from on a macOS device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gatekeeperAllowedAppSource", Required = Newtonsoft.Json.Required.Default)]
        public MacOSGatekeeperAppSources? GatekeeperAllowedAppSource { get; set; }
    
        /// <summary>
        /// Gets or sets gatekeeper block override.
        /// If set to true, the user override for Gatekeeper will be disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gatekeeperBlockOverride", Required = Newtonsoft.Json.Required.Default)]
        public bool? GatekeeperBlockOverride { get; set; }
    
        /// <summary>
        /// Gets or sets firewall enabled.
        /// Whether the firewall should be enabled or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firewallEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? FirewallEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets firewall block all incoming.
        /// Corresponds to the ???Block all incoming connections??? option.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firewallBlockAllIncoming", Required = Newtonsoft.Json.Required.Default)]
        public bool? FirewallBlockAllIncoming { get; set; }
    
        /// <summary>
        /// Gets or sets firewall enable stealth mode.
        /// Corresponds to ???Enable stealth mode.???
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firewallEnableStealthMode", Required = Newtonsoft.Json.Required.Default)]
        public bool? FirewallEnableStealthMode { get; set; }
    
        /// <summary>
        /// Gets or sets firewall applications.
        /// List of applications with firewall settings. Firewall settings for applications not on this list are determined by the user. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firewallApplications", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MacOSFirewallApplication> FirewallApplications { get; set; }
    
        /// <summary>
        /// Gets or sets file vault enabled.
        /// Whether FileVault should be enabled or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? FileVaultEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets file vault selected recovery key types.
        /// Required if FileVault is enabled, determines the type(s) of recovery key to use. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultSelectedRecoveryKeyTypes", Required = Newtonsoft.Json.Required.Default)]
        public MacOSFileVaultRecoveryKeyTypes? FileVaultSelectedRecoveryKeyTypes { get; set; }
    
        /// <summary>
        /// Gets or sets file vault institutional recovery key certificate.
        /// Required if selected recovery key type(s) include InstitutionalRecoveryKey. The DER Encoded certificate file used to set an institutional recovery key.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultInstitutionalRecoveryKeyCertificate", Required = Newtonsoft.Json.Required.Default)]
        public byte[] FileVaultInstitutionalRecoveryKeyCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets file vault institutional recovery key certificate file name.
        /// File name of the institutional recovery key certificate to display in UI. (*.der).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultInstitutionalRecoveryKeyCertificateFileName", Required = Newtonsoft.Json.Required.Default)]
        public string FileVaultInstitutionalRecoveryKeyCertificateFileName { get; set; }
    
        /// <summary>
        /// Gets or sets file vault personal recovery key help message.
        /// Required if selected recovery key type(s) include PersonalRecoveryKey. A short message displayed to the user that explains how they can retrieve their personal recovery key.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultPersonalRecoveryKeyHelpMessage", Required = Newtonsoft.Json.Required.Default)]
        public string FileVaultPersonalRecoveryKeyHelpMessage { get; set; }
    
        /// <summary>
        /// Gets or sets file vault allow deferral until sign out.
        /// Optional. If set to true, the user can defer the enabling of FileVault until they sign out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultAllowDeferralUntilSignOut", Required = Newtonsoft.Json.Required.Default)]
        public bool? FileVaultAllowDeferralUntilSignOut { get; set; }
    
        /// <summary>
        /// Gets or sets file vault number of times user can ignore.
        /// Optional. When using the Defer option, this is the maximum number of times the user can ignore prompts to enable FileVault before FileVault will be required for the user to sign in. If set to -1, it will always prompt to enable FileVault until FileVault is enabled, though it will allow the user to bypass enabling FileVault. Setting this to 0 will disable the feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultNumberOfTimesUserCanIgnore", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FileVaultNumberOfTimesUserCanIgnore { get; set; }
    
        /// <summary>
        /// Gets or sets file vault disable prompt at sign out.
        /// Optional. When using the Defer option, if set to true, the user is not prompted to enable FileVault at sign-out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultDisablePromptAtSignOut", Required = Newtonsoft.Json.Required.Default)]
        public bool? FileVaultDisablePromptAtSignOut { get; set; }
    
        /// <summary>
        /// Gets or sets file vault personal recovery key rotation in months.
        /// Optional. If selected recovery key type(s) include PersonalRecoveryKey, the frequency to rotate that key, in months.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultPersonalRecoveryKeyRotationInMonths", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FileVaultPersonalRecoveryKeyRotationInMonths { get; set; }
    
        /// <summary>
        /// Gets or sets file vault hide personal recovery key.
        /// Optional. A hidden personal recovery key does not appear on the user's screen during FileVault encryption, reducing the risk of it ending up in the wrong hands.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultHidePersonalRecoveryKey", Required = Newtonsoft.Json.Required.Default)]
        public bool? FileVaultHidePersonalRecoveryKey { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection real time.
        /// Determines whether or not to enable real-time protection for Microsoft Defender Advanced Threat Protection on macOS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "advancedThreatProtectionRealTime", Required = Newtonsoft.Json.Required.Default)]
        public Enablement? AdvancedThreatProtectionRealTime { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection cloud delivered.
        /// Determines whether or not to enable cloud-delivered protection for Microsoft Defender Advanced Threat Protection on macOS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "advancedThreatProtectionCloudDelivered", Required = Newtonsoft.Json.Required.Default)]
        public Enablement? AdvancedThreatProtectionCloudDelivered { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection automatic sample submission.
        /// Determines whether or not to enable automatic file sample submission for Microsoft Defender Advanced Threat Protection on macOS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "advancedThreatProtectionAutomaticSampleSubmission", Required = Newtonsoft.Json.Required.Default)]
        public Enablement? AdvancedThreatProtectionAutomaticSampleSubmission { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection diagnostic data collection.
        /// Determines whether or not to enable diagnostic and usage data collection for Microsoft Defender Advanced Threat Protection on macOS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "advancedThreatProtectionDiagnosticDataCollection", Required = Newtonsoft.Json.Required.Default)]
        public Enablement? AdvancedThreatProtectionDiagnosticDataCollection { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection excluded folders.
        /// A list of paths to folders to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "advancedThreatProtectionExcludedFolders", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AdvancedThreatProtectionExcludedFolders { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection excluded files.
        /// A list of paths to files to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "advancedThreatProtectionExcludedFiles", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AdvancedThreatProtectionExcludedFiles { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection excluded extensions.
        /// A list of file extensions to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "advancedThreatProtectionExcludedExtensions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AdvancedThreatProtectionExcludedExtensions { get; set; }
    
        /// <summary>
        /// Gets or sets advanced threat protection excluded processes.
        /// A list of process names to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "advancedThreatProtectionExcludedProcesses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AdvancedThreatProtectionExcludedProcesses { get; set; }
    
    }
}

