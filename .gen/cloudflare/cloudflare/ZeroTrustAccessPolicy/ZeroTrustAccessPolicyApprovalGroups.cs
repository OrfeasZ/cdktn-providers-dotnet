using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustAccessPolicy.ZeroTrustAccessPolicyApprovalGroups")]
    public class ZeroTrustAccessPolicyApprovalGroups : cloudflare.ZeroTrustAccessPolicy.IZeroTrustAccessPolicyApprovalGroups
    {
        /// <summary>The number of approvals needed to obtain access.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#approvals_needed ZeroTrustAccessPolicy#approvals_needed}
        /// </remarks>
        [JsiiProperty(name: "approvalsNeeded", typeJson: "{\"primitive\":\"number\"}")]
        public double ApprovalsNeeded
        {
            get;
            set;
        }

        /// <summary>A list of emails that can approve the access request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#email_addresses ZeroTrustAccessPolicy#email_addresses}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emailAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EmailAddresses
        {
            get;
            set;
        }

        /// <summary>The UUID of an re-usable email list.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_access_policy#email_list_uuid ZeroTrustAccessPolicy#email_list_uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emailListUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailListUuid
        {
            get;
            set;
        }
    }
}
