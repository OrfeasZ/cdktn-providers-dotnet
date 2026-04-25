using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressing")]
    public class MagicTransitSiteLanStaticAddressing : cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressing
    {
        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#address MagicTransitSiteLan#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dhcp_relay MagicTransitSiteLan#dhcp_relay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dhcpRelay", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpRelay\"}", isOptional: true)]
        public cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpRelay? DhcpRelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#dhcp_server MagicTransitSiteLan#dhcp_server}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dhcpServer", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpServer\"}", isOptional: true)]
        public cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpServer? DhcpServer
        {
            get;
            set;
        }

        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#secondary_address MagicTransitSiteLan#secondary_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecondaryAddress
        {
            get;
            set;
        }

        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#virtual_address MagicTransitSiteLan#virtual_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualAddress
        {
            get;
            set;
        }
    }
}
