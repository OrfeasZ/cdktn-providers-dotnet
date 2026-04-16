using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsQuarantine")]
    public class ZeroTrustGatewayPolicyRuleSettingsQuarantine : cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsQuarantine
    {
        /// <summary>Specify the types of files to sandbox.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_gateway_policy#file_types ZeroTrustGatewayPolicy#file_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? FileTypes
        {
            get;
            set;
        }
    }
}
