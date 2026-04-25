using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDnsLocationNetworks), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationNetworks")]
    public interface IZeroTrustDnsLocationNetworks
    {
        /// <summary>Specify the IPv4 address or IPv4 CIDR. Limit IPv4 CIDRs to a maximum of /24.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#network ZeroTrustDnsLocation#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}")]
        string Network
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDnsLocationNetworks), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationNetworks")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationNetworks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the IPv4 address or IPv4 CIDR. Limit IPv4 CIDRs to a maximum of /24.</summary>
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
