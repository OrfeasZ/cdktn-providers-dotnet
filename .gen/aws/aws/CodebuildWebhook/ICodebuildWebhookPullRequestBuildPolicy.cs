using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildWebhook
{
    [JsiiInterface(nativeType: typeof(ICodebuildWebhookPullRequestBuildPolicy), fullyQualifiedName: "aws.codebuildWebhook.CodebuildWebhookPullRequestBuildPolicy")]
    public interface ICodebuildWebhookPullRequestBuildPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/codebuild_webhook#requires_comment_approval CodebuildWebhook#requires_comment_approval}.</summary>
        [JsiiProperty(name: "requiresCommentApproval", typeJson: "{\"primitive\":\"string\"}")]
        string RequiresCommentApproval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/codebuild_webhook#approver_roles CodebuildWebhook#approver_roles}.</summary>
        [JsiiProperty(name: "approverRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ApproverRoles
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildWebhookPullRequestBuildPolicy), fullyQualifiedName: "aws.codebuildWebhook.CodebuildWebhookPullRequestBuildPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.CodebuildWebhook.ICodebuildWebhookPullRequestBuildPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/codebuild_webhook#requires_comment_approval CodebuildWebhook#requires_comment_approval}.</summary>
            [JsiiProperty(name: "requiresCommentApproval", typeJson: "{\"primitive\":\"string\"}")]
            public string RequiresCommentApproval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/codebuild_webhook#approver_roles CodebuildWebhook#approver_roles}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "approverRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ApproverRoles
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
