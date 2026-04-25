using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDnsLocationEndpointsIpv6Networks), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6Networks")]
    public interface IZeroTrustDnsLocationEndpointsIpv6Networks
    {
        /// <summary>Specify the IPv6 address or IPv6 CIDR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#network ZeroTrustDnsLocation#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}")]
        string Network
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDnsLocationEndpointsIpv6Networks), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6Networks")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv6Networks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the IPv6 address or IPv6 CIDR.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#network ZeroTrustDnsLocation#network}
            /// </remarks>
            [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}")]
            public string Network
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
