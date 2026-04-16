using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiInterface(nativeType: typeof(IMagicTransitSiteLanStaticAddressingDhcpRelay), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpRelay")]
    public interface IMagicTransitSiteLanStaticAddressingDhcpRelay
    {
        /// <summary>List of DHCP server IPs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#server_addresses MagicTransitSiteLan#server_addresses}
        /// </remarks>
        [JsiiProperty(name: "serverAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ServerAddresses
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitSiteLanStaticAddressingDhcpRelay), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanStaticAddressingDhcpRelay")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanStaticAddressingDhcpRelay
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of DHCP server IPs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_lan#server_addresses MagicTransitSiteLan#server_addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ServerAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
