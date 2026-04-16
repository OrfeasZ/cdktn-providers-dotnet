using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeExternalEvaluation")]
    public class ZeroTrustAccessApplicationPoliciesExcludeExternalEvaluation : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeExternalEvaluation
    {
        /// <summary>The API endpoint containing your business logic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#evaluate_url ZeroTrustAccessApplication#evaluate_url}
        /// </remarks>
        [JsiiProperty(name: "evaluateUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string EvaluateUrl
        {
            get;
            set;
        }

        /// <summary>The API endpoint containing the key that Access uses to verify that the response came from your API.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_application#keys_url ZeroTrustAccessApplication#keys_url}
        /// </remarks>
        [JsiiProperty(name: "keysUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string KeysUrl
        {
            get;
            set;
        }
    }
}
