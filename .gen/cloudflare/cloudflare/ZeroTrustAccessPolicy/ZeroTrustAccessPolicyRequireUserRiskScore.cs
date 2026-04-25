using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireUserRiskScore")]
    public class ZeroTrustAccessPolicyRequireUserRiskScore : cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireUserRiskScore
    {
        /// <summary>A list of risk score levels to match. Values can be low, medium, high, or unscored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_policy#user_risk_score ZeroTrustAccessPolicy#user_risk_score}
        /// </remarks>
        [JsiiProperty(name: "userRiskScore", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] UserRiskScore
        {
            get;
            set;
        }
    }
}
