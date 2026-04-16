using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyRequireCommonName")]
    public class ZeroTrustAccessPolicyRequireCommonName : cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyRequireCommonName
    {
        /// <summary>The common name to match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#common_name ZeroTrustAccessPolicy#common_name}
        /// </remarks>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        public string CommonName
        {
            get;
            set;
        }
    }
}
