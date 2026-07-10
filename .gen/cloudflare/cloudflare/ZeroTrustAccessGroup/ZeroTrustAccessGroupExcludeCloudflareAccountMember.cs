using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessGroup
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessGroup.ZeroTrustAccessGroupExcludeCloudflareAccountMember")]
    public class ZeroTrustAccessGroupExcludeCloudflareAccountMember : cloudflare.ZeroTrustAccessGroup.IZeroTrustAccessGroupExcludeCloudflareAccountMember
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.22.0/docs/resources/zero_trust_access_group#account_id ZeroTrustAccessGroup#account_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountId
        {
            get;
            set;
        }
    }
}
