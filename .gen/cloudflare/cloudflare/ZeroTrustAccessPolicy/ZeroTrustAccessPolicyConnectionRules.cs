using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyConnectionRules")]
    public class ZeroTrustAccessPolicyConnectionRules : cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyConnectionRules
    {
        /// <summary>The RDP-specific rules that define clipboard behavior for RDP connections.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#rdp ZeroTrustAccessPolicy#rdp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rdp", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyConnectionRulesRdp\"}", isOptional: true)]
        public cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyConnectionRulesRdp? Rdp
        {
            get;
            set;
        }
    }
}
