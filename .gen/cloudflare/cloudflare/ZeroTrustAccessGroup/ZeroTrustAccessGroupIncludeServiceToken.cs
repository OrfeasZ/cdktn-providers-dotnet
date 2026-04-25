using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupIncludeServiceToken")]
    public class ZeroTrustAccessGroupIncludeServiceToken : cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupIncludeServiceToken
    {
        /// <summary>The ID of a Service Token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_access_group#token_id ZeroTrustAccessGroup#token_id}
        /// </remarks>
        [JsiiProperty(name: "tokenId", typeJson: "{\"primitive\":\"string\"}")]
        public string TokenId
        {
            get;
            set;
        }
    }
}
