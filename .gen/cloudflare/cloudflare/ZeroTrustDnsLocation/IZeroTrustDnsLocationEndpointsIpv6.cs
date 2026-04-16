using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDnsLocationEndpointsIpv6), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6")]
    public interface IZeroTrustDnsLocationEndpointsIpv6
    {
        /// <summary>Indicate whether the IPV6 endpoint is enabled for this location.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dns_location#enabled ZeroTrustDnsLocation#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the list of allowed source IPv6 network ranges for this endpoint.</summary>
        /// <remarks>
        /// When the list is empty, the endpoint allows all source IPs. The list takes effect only if the endpoint is enabled for this location.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dns_location#networks ZeroTrustDnsLocation#networks}
        /// </remarks>
        [JsiiProperty(name: "networks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6Networks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Networks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDnsLocationEndpointsIpv6), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsIpv6
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicate whether the IPV6 endpoint is enabled for this location.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dns_location#enabled ZeroTrustDnsLocation#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specify the list of allowed source IPv6 network ranges for this endpoint.</summary>
            /// <remarks>
            /// When the list is empty, the endpoint allows all source IPs. The list takes effect only if the endpoint is enabled for this location.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dns_location#networks ZeroTrustDnsLocation#networks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsIpv6Networks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Networks
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
