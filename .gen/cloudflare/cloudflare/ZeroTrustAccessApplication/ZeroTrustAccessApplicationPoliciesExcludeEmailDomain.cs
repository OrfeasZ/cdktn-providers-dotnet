using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessApplication.ZeroTrustAccessApplicationPoliciesExcludeEmailDomain")]
    public class ZeroTrustAccessApplicationPoliciesExcludeEmailDomain : cloudflare.ZeroTrustAccessApplication.IZeroTrustAccessApplicationPoliciesExcludeEmailDomain
    {
        /// <summary>The email domain to match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_application#domain ZeroTrustAccessApplication#domain}
        /// </remarks>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public string Domain
        {
            get;
            set;
        }
    }
}
