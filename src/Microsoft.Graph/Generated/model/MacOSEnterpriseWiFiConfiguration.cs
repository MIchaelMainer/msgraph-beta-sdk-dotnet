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
    /// The type Mac OSEnterprise Wi Fi Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MacOSEnterpriseWiFiConfiguration : MacOSWiFiConfiguration
    {
    
		///<summary>
		/// The MacOSEnterpriseWiFiConfiguration constructor
		///</summary>
        public MacOSEnterpriseWiFiConfiguration()
        {
            this.ODataType = "microsoft.graph.macOSEnterpriseWiFiConfiguration";
        }
	
        /// <summary>
        /// Gets or sets eap type.
        /// Extensible Authentication Protocol (EAP). Indicates the type of EAP protocol set on the Wi-Fi endpoint (router).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eapType", Required = Newtonsoft.Json.Required.Default)]
        public EapType? EapType { get; set; }
    
        /// <summary>
        /// Gets or sets eap fast configuration.
        /// EAP-FAST Configuration Option when EAP-FAST is the selected EAP Type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eapFastConfiguration", Required = Newtonsoft.Json.Required.Default)]
        public EapFastConfiguration? EapFastConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets trusted server certificate names.
        /// Trusted server certificate names when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP. This is the common name used in the certificates issued by your trusted certificate authority (CA). If you provide this information, you can bypass the dynamic trust dialog that is displayed on end users devices when they connect to this Wi-Fi network.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trustedServerCertificateNames", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> TrustedServerCertificateNames { get; set; }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication Method when EAP Type is configured to PEAP or EAP-TTLS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethod", Required = Newtonsoft.Json.Required.Default)]
        public WiFiAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets inner authentication protocol for eap ttls.
        /// Non-EAP Method for Authentication (Inner Identity) when EAP Type is EAP-TTLS and Authenticationmethod is Username and Password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "innerAuthenticationProtocolForEapTtls", Required = Newtonsoft.Json.Required.Default)]
        public NonEapAuthenticationMethodForEapTtlsType? InnerAuthenticationProtocolForEapTtls { get; set; }
    
        /// <summary>
        /// Gets or sets outer identity privacy temporary value.
        /// Enable identity privacy (Outer Identity) when EAP Type is configured to EAP-TTLS, EAP-FAST or PEAP. This property masks usernames with the text you enter. For example, if you use 'anonymous', each user that authenticates with this Wi-Fi connection using their real username is displayed as 'anonymous'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outerIdentityPrivacyTemporaryValue", Required = Newtonsoft.Json.Required.Default)]
        public string OuterIdentityPrivacyTemporaryValue { get; set; }
    
        /// <summary>
        /// Gets or sets root certificate for server validation.
        /// Trusted Root Certificate for Server Validation when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rootCertificateForServerValidation", Required = Newtonsoft.Json.Required.Default)]
        public MacOSTrustedRootCertificate RootCertificateForServerValidation { get; set; }
    
        /// <summary>
        /// Gets or sets root certificates for server validation.
        /// Trusted Root Certificates for Server Validation when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP. If you provide this value you do not need to provide trustedServerCertificateNames, and vice versa.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rootCertificatesForServerValidation", Required = Newtonsoft.Json.Required.Default)]
        public IMacOSEnterpriseWiFiConfigurationRootCertificatesForServerValidationCollectionPage RootCertificatesForServerValidation { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate for client authentication.
        /// Identity Certificate for client authentication when EAP Type is configured to EAP-TLS, EAP-TTLS (with Certificate Authentication), or PEAP (with Certificate Authentication).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityCertificateForClientAuthentication", Required = Newtonsoft.Json.Required.Default)]
        public MacOSCertificateProfileBase IdentityCertificateForClientAuthentication { get; set; }
    
    }
}

