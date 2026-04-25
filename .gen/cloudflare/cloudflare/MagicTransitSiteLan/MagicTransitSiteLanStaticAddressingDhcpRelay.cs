using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiByValue(fqn: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpRelay")]
    public class MagicTransitSiteLanStaticAddressingDhcpRelay : cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpRelay
    {
        /// <summary>List of DHCP server IPs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#server_addresses MagicTransitSiteLan#server_addresses}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ServerAddresses
        {
            get;
            set;
        }
    }
}
