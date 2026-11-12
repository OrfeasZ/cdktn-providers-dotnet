using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteWan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.magicTransitSiteWan.MagicTransitSiteWanStaticAddressing")]
    public class MagicTransitSiteWanStaticAddressing : cloudflare.MagicTransitSiteWan.IMagicTransitSiteWanStaticAddressing
    {
        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/magic_transit_site_wan#address MagicTransitSiteWan#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/magic_transit_site_wan#gateway_address MagicTransitSiteWan#gateway_address}
        /// </remarks>
        [JsiiProperty(name: "gatewayAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string GatewayAddress
        {
            get;
            set;
        }

        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/magic_transit_site_wan#secondary_address MagicTransitSiteWan#secondary_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecondaryAddress
        {
            get;
            set;
        }

        /// <summary>Gateway address for the secondary connector of a high availability site.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/magic_transit_site_wan#secondary_gateway_address MagicTransitSiteWan#secondary_gateway_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryGatewayAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecondaryGatewayAddress
        {
            get;
            set;
        }
    }
}
