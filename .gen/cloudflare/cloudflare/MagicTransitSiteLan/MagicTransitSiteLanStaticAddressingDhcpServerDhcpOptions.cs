using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpServerDhcpOptions")]
    public class MagicTransitSiteLanStaticAddressingDhcpServerDhcpOptions : cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpServerDhcpOptions
    {
        /// <summary>DHCP option number (1-254).</summary>
        /// <remarks>
        /// Options 0 and 255 are reserved by RFC 2132. Options 3, 6, and 51 are not allowed because they conflict with connector-managed configuration.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/magic_transit_site_lan#code MagicTransitSiteLan#code}
        /// </remarks>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}")]
        public double Code
        {
            get;
            set;
        }

        /// <summary>The type of the option value.</summary>
        /// <remarks>
        /// text: a string (max 255 bytes). hex: colon-separated hex bytes (e.g. "01:04:aa:bb:cc", max 255 bytes). ip: an IPv4 address (e.g. "10.20.30.40"). byte: an unsigned integer 0-255 (1 byte). short: an unsigned integer 0-65535 (2 bytes). integer: an unsigned integer 0-4294967295 (4 bytes).
        /// Available values: "text", "hex", "ip", "byte", "short", "integer".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/magic_transit_site_lan#type MagicTransitSiteLan#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>The option value, interpreted according to the type field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/resources/magic_transit_site_lan#value MagicTransitSiteLan#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
