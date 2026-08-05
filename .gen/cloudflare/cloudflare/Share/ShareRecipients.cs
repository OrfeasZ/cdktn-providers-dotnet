using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Share
{
    [JsiiByValue(fqn: "cloudflare.share.ShareRecipients")]
    public class ShareRecipients : cloudflare.Share.IShareRecipients
    {
        /// <summary>Organization identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/share#organization_id Share#organization_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrganizationId
        {
            get;
            set;
        }

        /// <summary>The account that will receive the share.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.23.0/docs/resources/share#recipient_account_id Share#recipient_account_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recipientAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecipientAccountId
        {
            get;
            set;
        }
    }
}
