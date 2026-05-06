using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDnsLocation
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDnsLocationEndpointsDoh), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDoh")]
    public interface IZeroTrustDnsLocationEndpointsDoh
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
        [JsiiProperty(name: "networks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDohNetworks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Networks
        {
            get
            {
                return null;
            }
        }

        /// <summary>True if the endpoint requires [user identity](https://developers.cloudflare.com/cloudflare-one/connections/connect-devices/agentless/dns/dns-over-https/#filter-doh-requests-by-user) authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#require_token ZeroTrustDnsLocation#require_token}
        /// </remarks>
        [JsiiProperty(name: "requireToken", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDnsLocationEndpointsDoh), fullyQualifiedName: "cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDoh")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDnsLocation.IZeroTrustDnsLocationEndpointsDoh
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
            [JsiiProperty(name: "networks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.zeroTrustDnsLocation.ZeroTrustDnsLocationEndpointsDohNetworks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Networks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>True if the endpoint requires [user identity](https://developers.cloudflare.com/cloudflare-one/connections/connect-devices/agentless/dns/dns-over-https/#filter-doh-requests-by-user) authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dns_location#require_token ZeroTrustDnsLocation#require_token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireToken", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireToken
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
