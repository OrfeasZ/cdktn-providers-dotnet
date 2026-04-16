using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiInterface(nativeType: typeof(IMagicTransitSiteLanNat), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanNat")]
    public interface IMagicTransitSiteLanNat
    {
        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#static_prefix MagicTransitSiteLan#static_prefix}
        /// </remarks>
        [JsiiProperty(name: "staticPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StaticPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitSiteLanNat), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanNat")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanNat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A valid CIDR notation representing an IP range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#static_prefix MagicTransitSiteLan#static_prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "staticPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StaticPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
