using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsEgress), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsEgress")]
    public interface IZeroTrustGatewayPolicyRuleSettingsEgress
    {
        /// <summary>Specify the IPv4 address to use for egress.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#ipv4 ZeroTrustGatewayPolicy#ipv4}
        /// </remarks>
        [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv4
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the fallback IPv4 address to use for egress when the primary IPv4 fails.</summary>
        /// <remarks>
        /// Set '0.0.0.0' to indicate local egress via WARP IPs.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#ipv4_fallback ZeroTrustGatewayPolicy#ipv4_fallback}
        /// </remarks>
        [JsiiProperty(name: "ipv4Fallback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv4Fallback
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the IPv6 range to use for egress.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#ipv6 ZeroTrustGatewayPolicy#ipv6}
        /// </remarks>
        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsEgress), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsEgress")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsEgress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specify the IPv4 address to use for egress.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#ipv4 ZeroTrustGatewayPolicy#ipv4}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv4
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the fallback IPv4 address to use for egress when the primary IPv4 fails.</summary>
            /// <remarks>
            /// Set '0.0.0.0' to indicate local egress via WARP IPs.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#ipv4_fallback ZeroTrustGatewayPolicy#ipv4_fallback}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4Fallback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv4Fallback
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the IPv6 range to use for egress.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#ipv6 ZeroTrustGatewayPolicy#ipv6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
