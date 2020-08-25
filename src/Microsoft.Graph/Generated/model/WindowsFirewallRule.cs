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
    /// The type WindowsFirewallRule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class WindowsFirewallRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsFirewallRule"/> class.
        /// </summary>
        public WindowsFirewallRule()
        {
            this.ODataType = "microsoft.graph.windowsFirewallRule";
        }

        /// <summary>
        /// Gets or sets displayName.
        /// The display name of the rule. Does not need to be unique.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets packageFamilyName.
        /// The package family name of a Microsoft Store application that's affected by the firewall rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "packageFamilyName", Required = Newtonsoft.Json.Required.Default)]
        public string PackageFamilyName { get; set; }
    
        /// <summary>
        /// Gets or sets filePath.
        /// The full file path of an app that's affected by the firewall rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "filePath", Required = Newtonsoft.Json.Required.Default)]
        public string FilePath { get; set; }
    
        /// <summary>
        /// Gets or sets serviceName.
        /// The name used in cases when a service, not an application, is sending or receiving traffic.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "serviceName", Required = Newtonsoft.Json.Required.Default)]
        public string ServiceName { get; set; }
    
        /// <summary>
        /// Gets or sets protocol.
        /// 0-255 number representing the IP protocol (TCP = 6, UDP = 17). If not specified, the default is All. Valid values 0 to 255
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protocol", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Protocol { get; set; }
    
        /// <summary>
        /// Gets or sets localPortRanges.
        /// List of local port ranges. For example, "100-120", "200", "300-320". If not specified, the default is All.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "localPortRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> LocalPortRanges { get; set; }
    
        /// <summary>
        /// Gets or sets remotePortRanges.
        /// List of remote port ranges. For example, "100-120", "200", "300-320". If not specified, the default is All.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remotePortRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RemotePortRanges { get; set; }
    
        /// <summary>
        /// Gets or sets localAddressRanges.
        /// List of local addresses covered by the rule. Default is any address. Valid tokens include:&amp;lt;ul&amp;gt;&amp;lt;li&amp;gt;"*" indicates any local address. If present, this must be the only token included.&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;A subnet can be specified using either the subnet mask or network prefix notation. If neither a subnet mask nor a network prefix is specified, the subnet mask defaults to 255.255.255.255.&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;A valid IPv6 address.&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;An IPv4 address range in the format of "start address - end address" with no spaces included.&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;An IPv6 address range in the format of "start address - end address" with no spaces included.&amp;lt;/li&amp;gt;&amp;lt;/ul&amp;gt;
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "localAddressRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> LocalAddressRanges { get; set; }
    
        /// <summary>
        /// Gets or sets remoteAddressRanges.
        /// List of tokens specifying the remote addresses covered by the rule. Tokens are case insensitive. Default is any address. Valid tokens include:&amp;lt;ul&amp;gt;&amp;lt;li&amp;gt;"*" indicates any remote address. If present, this must be the only token included.&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;"Defaultgateway"&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;"DHCP"&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;"DNS"&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;"WINS"&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;"Intranet" (supported on Windows versions 1809+)&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;"RmtIntranet" (supported on Windows versions 1809+)&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;"Internet" (supported on Windows versions 1809+)&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;"Ply2Renders" (supported on Windows versions 1809+)&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;"LocalSubnet" indicates any local address on the local subnet.&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;A subnet can be specified using either the subnet mask or network prefix notation. If neither a subnet mask nor a network prefix is specified, the subnet mask defaults to 255.255.255.255.&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;A valid IPv6 address.&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;An IPv4 address range in the format of "start address - end address" with no spaces included.&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;An IPv6 address range in the format of "start address - end address" with no spaces included.&amp;lt;/li&amp;gt;&amp;lt;/ul&amp;gt;
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remoteAddressRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RemoteAddressRanges { get; set; }
    
        /// <summary>
        /// Gets or sets profileTypes.
        /// Specifies the profiles to which the rule belongs. If not specified, the default is All.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profileTypes", Required = Newtonsoft.Json.Required.Default)]
        public WindowsFirewallRuleNetworkProfileTypes? ProfileTypes { get; set; }
    
        /// <summary>
        /// Gets or sets action.
        /// The action the rule enforces. If not specified, the default is Allowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action", Required = Newtonsoft.Json.Required.Default)]
        public StateManagementSetting? Action { get; set; }
    
        /// <summary>
        /// Gets or sets trafficDirection.
        /// The traffic direction that the rule is enabled for. If not specified, the default is Out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trafficDirection", Required = Newtonsoft.Json.Required.Default)]
        public WindowsFirewallRuleTrafficDirectionType? TrafficDirection { get; set; }
    
        /// <summary>
        /// Gets or sets interfaceTypes.
        /// The interface types of the rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interfaceTypes", Required = Newtonsoft.Json.Required.Default)]
        public WindowsFirewallRuleInterfaceTypes? InterfaceTypes { get; set; }
    
        /// <summary>
        /// Gets or sets edgeTraversal.
        /// Indicates whether edge traversal is enabled or disabled for this rule. The EdgeTraversal setting indicates that specific inbound traffic is allowed to tunnel through NATs and other edge devices using the Teredo tunneling technology. In order for this setting to work correctly, the application or service with the inbound firewall rule needs to support IPv6. The primary application of this setting allows listeners on the host to be globally addressable through a Teredo IPv6 address. New rules have the EdgeTraversal property disabled by default.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "edgeTraversal", Required = Newtonsoft.Json.Required.Default)]
        public StateManagementSetting? EdgeTraversal { get; set; }
    
        /// <summary>
        /// Gets or sets localUserAuthorizations.
        /// Specifies the list of authorized local users for the app container. This is a string in Security Descriptor Definition Language (SDDL) format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "localUserAuthorizations", Required = Newtonsoft.Json.Required.Default)]
        public string LocalUserAuthorizations { get; set; }
    
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
