using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Share
{
    [JsiiInterface(nativeType: typeof(IShareExcludedRecipients), fullyQualifiedName: "cloudflare.share.ShareExcludedRecipients")]
    public interface IShareExcludedRecipients
    {
        /// <summary>The account to exclude from the organization-targeted share.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/share#account_id Share#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IShareExcludedRecipients), fullyQualifiedName: "cloudflare.share.ShareExcludedRecipients")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Share.IShareExcludedRecipients
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account to exclude from the organization-targeted share.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/share#account_id Share#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
