using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsUntrustedCert")]
    public class ZeroTrustGatewayPolicyRuleSettingsUntrustedCert : cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsUntrustedCert
    {
        /// <summary>The action performed when an untrusted certificate is seen.</summary>
        /// <remarks>
        /// The default action is an error with HTTP code 526.
        /// Available values: "pass_through", "block", "error".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_gateway_policy#action ZeroTrustGatewayPolicy#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }
    }
}
