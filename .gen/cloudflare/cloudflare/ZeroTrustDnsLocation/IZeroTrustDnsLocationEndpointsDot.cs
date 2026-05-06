using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDnsLocationEndpointsDot), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDot")]
    public interface IZeroTrustDnsLocationEndpointsDot
    {
        /// <summary>True if the endpoint is enabled for this location.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#enabled ZeroTrustDnsLocation#enabled}
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

        /// <summary>A list of allowed source IP network ranges for this endpoint.</summary>
        /// <remarks>
        /// When empty, all source IPs are allowed. A non-empty list is only effective if the endpoint is enabled for this location.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#networks ZeroTrustDnsLocation#networks}
        /// </remarks>
        [JsiiProperty(name: "networks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDotNetworks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Networks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDnsLocationEndpointsDot), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDot")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>True if the endpoint is enabled for this location.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#enabled ZeroTrustDnsLocation#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of allowed source IP network ranges for this endpoint.</summary>
            /// <remarks>
            /// When empty, all source IPs are allowed. A non-empty list is only effective if the endpoint is enabled for this location.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#networks ZeroTrustDnsLocation#networks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDotNetworks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Networks
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
