using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildWebhook
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuildWebhook.CodebuildWebhookPullRequestBuildPolicy")]
    public class CodebuildWebhookPullRequestBuildPolicy : aws.CodebuildWebhook.ICodebuildWebhookPullRequestBuildPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#requires_comment_approval CodebuildWebhook#requires_comment_approval}.</summary>
        [JsiiProperty(name: "requiresCommentApproval", typeJson: "{\"primitive\":\"string\"}")]
        public string RequiresCommentApproval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/codebuild_webhook#approver_roles CodebuildWebhook#approver_roles}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "approverRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ApproverRoles
        {
            get;
            set;
        }
    }
}
