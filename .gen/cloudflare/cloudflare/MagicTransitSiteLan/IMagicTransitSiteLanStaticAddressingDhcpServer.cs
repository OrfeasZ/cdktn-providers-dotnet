using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiInterface(nativeType: typeof(IMagicTransitSiteLanStaticAddressingDhcpServer), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpServer")]
    public interface IMagicTransitSiteLanStaticAddressingDhcpServer
    {
        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dhcp_pool_end MagicTransitSiteLan#dhcp_pool_end}
        /// </remarks>
        [JsiiProperty(name: "dhcpPoolEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DhcpPoolEnd
        {
            get
            {
                return null;
            }
        }

        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dhcp_pool_start MagicTransitSiteLan#dhcp_pool_start}
        /// </remarks>
        [JsiiProperty(name: "dhcpPoolStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DhcpPoolStart
        {
            get
            {
                return null;
            }
        }

        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dns_server MagicTransitSiteLan#dns_server}
        /// </remarks>
        [JsiiProperty(name: "dnsServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dns_servers MagicTransitSiteLan#dns_servers}.</summary>
        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DnsServers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Mapping of MAC addresses to IP addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#reservations MagicTransitSiteLan#reservations}
        /// </remarks>
        [JsiiProperty(name: "reservations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Reservations
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitSiteLanStaticAddressingDhcpServer), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpServer")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpServer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A valid IPv4 address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dhcp_pool_end MagicTransitSiteLan#dhcp_pool_end}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dhcpPoolEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DhcpPoolEnd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A valid IPv4 address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dhcp_pool_start MagicTransitSiteLan#dhcp_pool_start}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dhcpPoolStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DhcpPoolStart
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A valid IPv4 address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dns_server MagicTransitSiteLan#dns_server}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsServer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dns_servers MagicTransitSiteLan#dns_servers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DnsServers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Mapping of MAC addresses to IP addresses.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#reservations MagicTransitSiteLan#reservations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reservations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Reservations
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
