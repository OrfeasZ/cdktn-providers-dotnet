using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDnsLocationEndpoints), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpoints")]
    public interface IZeroTrustDnsLocationEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#doh ZeroTrustDnsLocation#doh}.</summary>
        [JsiiProperty(name: "doh", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDoh\"}")]
        cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDoh Doh
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#dot ZeroTrustDnsLocation#dot}.</summary>
        [JsiiProperty(name: "dot", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDot\"}")]
        cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDot Dot
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#ipv4 ZeroTrustDnsLocation#ipv4}.</summary>
        [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv4\"}")]
        cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv4 Ipv4
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#ipv6 ZeroTrustDnsLocation#ipv6}.</summary>
        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6\"}")]
        cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv6 Ipv6
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDnsLocationEndpoints), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpoints")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpoints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#doh ZeroTrustDnsLocation#doh}.</summary>
            [JsiiProperty(name: "doh", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDoh\"}")]
            public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDoh Doh
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDoh>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#dot ZeroTrustDnsLocation#dot}.</summary>
            [JsiiProperty(name: "dot", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDot\"}")]
            public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDot Dot
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDot>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#ipv4 ZeroTrustDnsLocation#ipv4}.</summary>
            [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv4\"}")]
            public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv4 Ipv4
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv4>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dns_location#ipv6 ZeroTrustDnsLocation#ipv6}.</summary>
            [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6\"}")]
            public cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv6 Ipv6
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv6>()!;
            }
        }
    }
}
