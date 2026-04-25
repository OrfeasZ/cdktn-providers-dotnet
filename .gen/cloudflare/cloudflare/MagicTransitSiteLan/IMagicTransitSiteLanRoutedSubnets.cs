using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiInterface(nativeType: typeof(IMagicTransitSiteLanRoutedSubnets), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnets")]
    public interface IMagicTransitSiteLanRoutedSubnets
    {
        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#next_hop MagicTransitSiteLan#next_hop}
        /// </remarks>
        [JsiiProperty(name: "nextHop", typeJson: "{\"primitive\":\"string\"}")]
        string NextHop
        {
            get;
        }

        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#prefix MagicTransitSiteLan#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#nat MagicTransitSiteLan#nat}.</summary>
        [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnetsNat\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRoutedSubnetsNat? Nat
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitSiteLanRoutedSubnets), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnets")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRoutedSubnets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A valid IPv4 address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#next_hop MagicTransitSiteLan#next_hop}
            /// </remarks>
            [JsiiProperty(name: "nextHop", typeJson: "{\"primitive\":\"string\"}")]
            public string NextHop
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A valid CIDR notation representing an IP range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#prefix MagicTransitSiteLan#prefix}
            /// </remarks>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/magic_transit_site_lan#nat MagicTransitSiteLan#nat}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnetsNat\"}", isOptional: true)]
            public cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRoutedSubnetsNat? Nat
            {
                get => GetInstanceProperty<cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRoutedSubnetsNat?>();
            }
        }
    }
}
