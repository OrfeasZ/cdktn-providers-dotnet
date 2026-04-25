using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiByValue(fqn: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpServer")]
    public class MagicTransitSiteLanStaticAddressingDhcpServer : cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpServer
    {
        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dhcp_pool_end MagicTransitSiteLan#dhcp_pool_end}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dhcpPoolEnd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DhcpPoolEnd
        {
            get;
            set;
        }

        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dhcp_pool_start MagicTransitSiteLan#dhcp_pool_start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dhcpPoolStart", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DhcpPoolStart
        {
            get;
            set;
        }

        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dns_server MagicTransitSiteLan#dns_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dnsServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsServer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dns_servers MagicTransitSiteLan#dns_servers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DnsServers
        {
            get;
            set;
        }

        /// <summary>Mapping of MAC addresses to IP addresses.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#reservations MagicTransitSiteLan#reservations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reservations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Reservations
        {
            get;
            set;
        }
    }
}
