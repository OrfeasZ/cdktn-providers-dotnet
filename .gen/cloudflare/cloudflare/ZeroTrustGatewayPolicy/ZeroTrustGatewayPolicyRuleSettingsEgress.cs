using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsEgress")]
    public class ZeroTrustGatewayPolicyRuleSettingsEgress : cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsEgress
    {
        /// <summary>Specify the IPv4 address to use for egress.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#ipv4 ZeroTrustGatewayPolicy#ipv4}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv4
        {
            get;
            set;
        }

        /// <summary>Specify the fallback IPv4 address to use for egress when the primary IPv4 fails.</summary>
        /// <remarks>
        /// Set '0.0.0.0' to indicate local egress via WARP IPs.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#ipv4_fallback ZeroTrustGatewayPolicy#ipv4_fallback}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv4Fallback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv4Fallback
        {
            get;
            set;
        }

        /// <summary>Specify the IPv6 range to use for egress.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#ipv6 ZeroTrustGatewayPolicy#ipv6}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6
        {
            get;
            set;
        }
    }
}
