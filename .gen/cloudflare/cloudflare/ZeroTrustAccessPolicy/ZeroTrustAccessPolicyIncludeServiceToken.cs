using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyIncludeServiceToken")]
    public class ZeroTrustAccessPolicyIncludeServiceToken : cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyIncludeServiceToken
    {
        /// <summary>The ID of a Service Token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#token_id ZeroTrustAccessPolicy#token_id}
        /// </remarks>
        [JsiiProperty(name: "tokenId", typeJson: "{\"primitive\":\"string\"}")]
        public string TokenId
        {
            get;
            set;
        }
    }
}
