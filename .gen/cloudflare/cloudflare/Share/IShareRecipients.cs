using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Share
{
    [JsiiInterface(nativeType: typeof(IShareRecipients), fullyQualifiedName: "cloudflare.share.ShareRecipients")]
    public interface IShareRecipients
    {
        /// <summary>Organization identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/share#organization_id Share#organization_id}
        /// </remarks>
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The account that will receive the share.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/share#recipient_account_id Share#recipient_account_id}
        /// </remarks>
        [JsiiProperty(name: "recipientAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecipientAccountId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IShareRecipients), fullyQualifiedName: "cloudflare.share.ShareRecipients")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Share.IShareRecipients
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Organization identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/share#organization_id Share#organization_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The account that will receive the share.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.20.0/docs/resources/share#recipient_account_id Share#recipient_account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recipientAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecipientAccountId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
