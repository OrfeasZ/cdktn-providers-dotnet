using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Share
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.share.ShareExcludedRecipients")]
    public class ShareExcludedRecipients : cloudflare.Share.IShareExcludedRecipients
    {
        /// <summary>The account to exclude from the organization-targeted share.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/share#account_id Share#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountId
        {
            get;
            set;
        }
    }
}
