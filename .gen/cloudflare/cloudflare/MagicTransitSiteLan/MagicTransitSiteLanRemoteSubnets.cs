using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanRemoteSubnets")]
    public class MagicTransitSiteLanRemoteSubnets : cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRemoteSubnets
    {
        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/magic_transit_site_lan#local_alias_prefix MagicTransitSiteLan#local_alias_prefix}
        /// </remarks>
        [JsiiProperty(name: "localAliasPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string LocalAliasPrefix
        {
            get;
            set;
        }

        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/magic_transit_site_lan#remote_prefix MagicTransitSiteLan#remote_prefix}
        /// </remarks>
        [JsiiProperty(name: "remotePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string RemotePrefix
        {
            get;
            set;
        }
    }
}
