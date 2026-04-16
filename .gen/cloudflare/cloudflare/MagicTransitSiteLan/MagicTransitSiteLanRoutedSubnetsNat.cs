using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiByValue(fqn: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnetsNat")]
    public class MagicTransitSiteLanRoutedSubnetsNat : cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRoutedSubnetsNat
    {
        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#static_prefix MagicTransitSiteLan#static_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "staticPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StaticPrefix
        {
            get;
            set;
        }
    }
}
