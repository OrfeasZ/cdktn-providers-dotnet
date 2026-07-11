using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiClass(nativeType: typeof(azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreatedOutputReference), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreatedOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServicehookWebhookTfsGitPullRequestCreatedOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServicehookWebhookTfsGitPullRequestCreatedOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServicehookWebhookTfsGitPullRequestCreatedOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicehookWebhookTfsGitPullRequestCreatedOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBranch")]
        public virtual void ResetBranch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPullRequestCreatedBy")]
        public virtual void ResetPullRequestCreatedBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPullRequestReviewersContains")]
        public virtual void ResetPullRequestReviewersContains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryId")]
        public virtual void ResetRepositoryId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "branchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BranchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pullRequestCreatedByInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PullRequestCreatedByInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pullRequestReviewersContainsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PullRequestReviewersContainsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Branch
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pullRequestCreatedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PullRequestCreatedBy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pullRequestReviewersContains", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PullRequestReviewersContains
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreated\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCreated? InternalValue
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCreated?>();
            set => SetInstanceProperty(value);
        }
    }
}
