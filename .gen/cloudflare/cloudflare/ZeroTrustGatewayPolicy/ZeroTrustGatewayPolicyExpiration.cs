using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyExpiration")]
    public class ZeroTrustGatewayPolicyExpiration : cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyExpiration
    {
        /// <summary>The time stamp at which the policy will expire and cease to be applied.</summary>
        /// <remarks>
        /// Must adhere to RFC 3339 and include a UTC offset. Non-zero
        /// offsets are accepted but will be converted to the equivalent
        /// value with offset zero (UTC+00:00) and will be returned as time
        /// stamps with offset zero denoted by a trailing 'Z'.
        ///
        /// Policies with an expiration do not consider the timezone of
        /// clients they are applied to, and expire "globally" at the point
        /// given by their <c>expires_at</c> value.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#expires_at ZeroTrustGatewayPolicy#expires_at}
        /// </remarks>
        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"string\"}")]
        public string ExpiresAt
        {
            get;
            set;
        }

        /// <summary>The default duration a policy will be active in minutes.</summary>
        /// <remarks>
        /// Must be set in order to use the <c>reset_expiration</c> endpoint on this rule.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#duration ZeroTrustGatewayPolicy#duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Duration
        {
            get;
            set;
        }
    }
}
