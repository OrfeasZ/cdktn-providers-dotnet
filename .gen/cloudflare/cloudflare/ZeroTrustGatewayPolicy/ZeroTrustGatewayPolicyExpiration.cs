using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyExpiration")]
    public class ZeroTrustGatewayPolicyExpiration : cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyExpiration
    {
        /// <summary>Show the timestamp when the policy expires and stops applying.</summary>
        /// <remarks>
        /// The value must follow RFC 3339 and include a UTC offset.  The system accepts non-zero offsets but converts them to the equivalent UTC+00:00  value and returns timestamps with a trailing Z. Expiration policies ignore client  timezones and expire globally at the specified expires_at time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#expires_at ZeroTrustGatewayPolicy#expires_at}
        /// </remarks>
        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"string\"}")]
        public string ExpiresAt
        {
            get;
            set;
        }

        /// <summary>Defines the default duration a policy active in minutes.</summary>
        /// <remarks>
        /// Must set in order to use the <c>reset_expiration</c> endpoint on this rule.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#duration ZeroTrustGatewayPolicy#duration}
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
