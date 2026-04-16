using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteWan
{
    [JsiiInterface(nativeType: typeof(IMagicTransitSiteWanStaticAddressing), fullyQualifiedName: "cloudflare.magicTransitSiteWan.MagicTransitSiteWanStaticAddressing")]
    public interface IMagicTransitSiteWanStaticAddressing
    {
        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_wan#address MagicTransitSiteWan#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>A valid IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_wan#gateway_address MagicTransitSiteWan#gateway_address}
        /// </remarks>
        [JsiiProperty(name: "gatewayAddress", typeJson: "{\"primitive\":\"string\"}")]
        string GatewayAddress
        {
            get;
        }

        /// <summary>A valid CIDR notation representing an IP range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_wan#secondary_address MagicTransitSiteWan#secondary_address}
        /// </remarks>
        [JsiiProperty(name: "secondaryAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecondaryAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMagicTransitSiteWanStaticAddressing), fullyQualifiedName: "cloudflare.magicTransitSiteWan.MagicTransitSiteWanStaticAddressing")]
        internal sealed class _Proxy : DeputyBase, cloudflare.MagicTransitSiteWan.IMagicTransitSiteWanStaticAddressing
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A valid CIDR notation representing an IP range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_wan#address MagicTransitSiteWan#address}
            /// </remarks>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A valid IPv4 address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_wan#gateway_address MagicTransitSiteWan#gateway_address}
            /// </remarks>
            [JsiiProperty(name: "gatewayAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string GatewayAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A valid CIDR notation representing an IP range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/magic_transit_site_wan#secondary_address MagicTransitSiteWan#secondary_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecondaryAddress
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
