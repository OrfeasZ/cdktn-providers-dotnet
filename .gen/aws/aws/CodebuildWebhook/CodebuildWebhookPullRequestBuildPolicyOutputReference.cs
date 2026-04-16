using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildWebhook
{
    [JsiiClass(nativeType: typeof(aws.CodebuildWebhook.CodebuildWebhookPullRequestBuildPolicyOutputReference), fullyQualifiedName: "aws.codebuildWebhook.CodebuildWebhookPullRequestBuildPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodebuildWebhookPullRequestBuildPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodebuildWebhookPullRequestBuildPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildWebhookPullRequestBuildPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildWebhookPullRequestBuildPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetApproverRoles")]
        public virtual void ResetApproverRoles()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "approverRolesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ApproverRolesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requiresCommentApprovalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequiresCommentApprovalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "approverRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ApproverRoles
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requiresCommentApproval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequiresCommentApproval
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuildWebhook.CodebuildWebhookPullRequestBuildPolicy\"}", isOptional: true)]
        public virtual aws.CodebuildWebhook.ICodebuildWebhookPullRequestBuildPolicy? InternalValue
        {
            get => GetInstanceProperty<aws.CodebuildWebhook.ICodebuildWebhookPullRequestBuildPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
