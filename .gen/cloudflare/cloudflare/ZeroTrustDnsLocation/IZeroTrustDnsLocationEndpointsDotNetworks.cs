using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDnsLocationEndpointsDotNetworks), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDotNetworks")]
    public interface IZeroTrustDnsLocationEndpointsDotNetworks
    {
        /// <summary>Specify the IP address or IP CIDR.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dns_location#network ZeroTrustDnsLocation#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}")]
        string Network
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDnsLocationEndpointsDotNetworks), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDotNetworks")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDotNetworks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the IP address or IP CIDR.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dns_location#network ZeroTrustDnsLocation#network}
            /// </remarks>
            [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}")]
            public string Network
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
