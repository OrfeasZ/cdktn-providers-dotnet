using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiInterface(nativeType: typeof(IMagicTransitSiteLanRemoteSubnets), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanRemoteSubnets")]
    public interface IMagicTransitSiteLanRemoteSubnets
    {
        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/magic_transit_site_lan#local_alias_prefix MagicTransitSiteLan#local_alias_prefix}
        /// </remarks>
        [JsiiProperty(name: "localAliasPrefix", typeJson: "{\"primitive\":\"string\"}")]
        string LocalAliasPrefix
        {
            get;
        }

        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/magic_transit_site_lan#remote_prefix MagicTransitSiteLan#remote_prefix}
        /// </remarks>
        [JsiiProperty(name: "remotePrefix", typeJson: "{\"primitive\":\"string\"}")]
        string RemotePrefix
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitSiteLanRemoteSubnets), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanRemoteSubnets")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRemoteSubnets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A valid CIDR notation representing an IP range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/magic_transit_site_lan#local_alias_prefix MagicTransitSiteLan#local_alias_prefix}
            /// </remarks>
            [JsiiProperty(name: "localAliasPrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string LocalAliasPrefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A valid CIDR notation representing an IP range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/magic_transit_site_lan#remote_prefix MagicTransitSiteLan#remote_prefix}
            /// </remarks>
            [JsiiProperty(name: "remotePrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string RemotePrefix
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
