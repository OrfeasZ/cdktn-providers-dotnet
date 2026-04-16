using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnets")]
    public class MagicTransitSiteLanRoutedSubnets : cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRoutedSubnets
    {
        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#next_hop MagicTransitSiteLan#next_hop}
        /// </remarks>
        [JsiiProperty(name: "nextHop", typeJson: "{\"primitive\":\"string\"}")]
        public string NextHop
        {
            get;
            set;
        }

        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#prefix MagicTransitSiteLan#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public string Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#nat MagicTransitSiteLan#nat}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnetsNat\"}", isOptional: true)]
        public cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRoutedSubnetsNat? Nat
        {
            get;
            set;
        }
    }
}
