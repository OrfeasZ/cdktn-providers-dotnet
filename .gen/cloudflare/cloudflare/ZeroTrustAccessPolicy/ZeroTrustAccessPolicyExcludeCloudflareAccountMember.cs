using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyExcludeCloudflareAccountMember")]
    public class ZeroTrustAccessPolicyExcludeCloudflareAccountMember : cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyExcludeCloudflareAccountMember
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/resources/zero_trust_access_policy#account_id ZeroTrustAccessPolicy#account_id}
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
