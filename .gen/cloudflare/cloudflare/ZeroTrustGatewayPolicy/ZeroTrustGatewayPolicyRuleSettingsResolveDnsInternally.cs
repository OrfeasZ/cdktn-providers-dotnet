using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally")]
    public class ZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally : cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally
    {
        /// <summary>The fallback behavior to apply when the internal DNS response code is different from 'NOERROR' or when the response data only contains CNAME records for 'A' or 'AAAA' queries.</summary>
        /// <remarks>
        /// Available values: "none", "public_dns".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#fallback ZeroTrustGatewayPolicy#fallback}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fallback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fallback
        {
            get;
            set;
        }

        /// <summary>The internal DNS view identifier that's passed to the internal DNS service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#view_id ZeroTrustGatewayPolicy#view_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "viewId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ViewId
        {
            get;
            set;
        }
    }
}
