using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs azuredevops_servicehook_webhook_tfs}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfs), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfs", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsConfig\"}}]")]
    public class ServicehookWebhookTfs : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs azuredevops_servicehook_webhook_tfs} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServicehookWebhookTfs(Constructs.Construct scope, string id, azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicehookWebhookTfs(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicehookWebhookTfs(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ServicehookWebhookTfs resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServicehookWebhookTfs to import.</param>
        /// <param name="importFromId">The id of the existing ServicehookWebhookTfs that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServicehookWebhookTfs to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServicehookWebhookTfs to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/servicehook_webhook_tfs#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServicehookWebhookTfs that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServicehookWebhookTfs to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfs), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBuildCompleted", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsBuildCompleted\"}}]")]
        public virtual void PutBuildCompleted(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitPullRequestCommented", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCommented\"}}]")]
        public virtual void PutGitPullRequestCommented(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCommented @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCommented)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitPullRequestCreated", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreated\"}}]")]
        public virtual void PutGitPullRequestCreated(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCreated @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCreated)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitPullRequestMergeAttempted", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestMergeAttempted\"}}]")]
        public virtual void PutGitPullRequestMergeAttempted(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestMergeAttempted @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestMergeAttempted)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitPullRequestUpdated", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestUpdated\"}}]")]
        public virtual void PutGitPullRequestUpdated(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestUpdated @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestUpdated)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitPush", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPush\"}}]")]
        public virtual void PutGitPush(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPush @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPush)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRepositoryCreated", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryCreated\"}}]")]
        public virtual void PutRepositoryCreated(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryCreated @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryCreated)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRepositoryDeleted", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryDeleted\"}}]")]
        public virtual void PutRepositoryDeleted(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryDeleted @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryDeleted)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRepositoryForked", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryForked\"}}]")]
        public virtual void PutRepositoryForked(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryForked @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryForked)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRepositoryRenamed", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryRenamed\"}}]")]
        public virtual void PutRepositoryRenamed(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryRenamed @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryRenamed)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRepositoryStatusChanged", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryStatusChanged\"}}]")]
        public virtual void PutRepositoryStatusChanged(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryStatusChanged @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryStatusChanged)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceConnectionCreated", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionCreated\"}}]")]
        public virtual void PutServiceConnectionCreated(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionCreated @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionCreated)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceConnectionUpdated", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionUpdated\"}}]")]
        public virtual void PutServiceConnectionUpdated(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionUpdated @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionUpdated)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTfvcCheckin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTfvcCheckin\"}}]")]
        public virtual void PutTfvcCheckin(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTfvcCheckin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTfvcCheckin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkItemCommented", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommented\"}}]")]
        public virtual void PutWorkItemCommented(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCommented @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCommented)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkItemCreated", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCreated\"}}]")]
        public virtual void PutWorkItemCreated(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCreated @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCreated)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkItemDeleted", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemDeleted\"}}]")]
        public virtual void PutWorkItemDeleted(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemDeleted @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemDeleted)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkItemRestored", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemRestored\"}}]")]
        public virtual void PutWorkItemRestored(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemRestored @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemRestored)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkItemUpdated", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemUpdated\"}}]")]
        public virtual void PutWorkItemUpdated(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemUpdated @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemUpdated)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceptUntrustedCerts")]
        public virtual void ResetAcceptUntrustedCerts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBasicAuthPassword")]
        public virtual void ResetBasicAuthPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBasicAuthUsername")]
        public virtual void ResetBasicAuthUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildCompleted")]
        public virtual void ResetBuildCompleted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDetailedMessagesToSend")]
        public virtual void ResetDetailedMessagesToSend()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitPullRequestCommented")]
        public virtual void ResetGitPullRequestCommented()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitPullRequestCreated")]
        public virtual void ResetGitPullRequestCreated()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitPullRequestMergeAttempted")]
        public virtual void ResetGitPullRequestMergeAttempted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitPullRequestUpdated")]
        public virtual void ResetGitPullRequestUpdated()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitPush")]
        public virtual void ResetGitPush()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpHeaders")]
        public virtual void ResetHttpHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMessagesToSend")]
        public virtual void ResetMessagesToSend()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryCreated")]
        public virtual void ResetRepositoryCreated()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryDeleted")]
        public virtual void ResetRepositoryDeleted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryForked")]
        public virtual void ResetRepositoryForked()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryRenamed")]
        public virtual void ResetRepositoryRenamed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryStatusChanged")]
        public virtual void ResetRepositoryStatusChanged()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceDetailsToSend")]
        public virtual void ResetResourceDetailsToSend()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceVersion")]
        public virtual void ResetResourceVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceConnectionCreated")]
        public virtual void ResetServiceConnectionCreated()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceConnectionUpdated")]
        public virtual void ResetServiceConnectionUpdated()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTfvcCheckin")]
        public virtual void ResetTfvcCheckin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkItemCommented")]
        public virtual void ResetWorkItemCommented()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkItemCreated")]
        public virtual void ResetWorkItemCreated()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkItemDeleted")]
        public virtual void ResetWorkItemDeleted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkItemRestored")]
        public virtual void ResetWorkItemRestored()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkItemUpdated")]
        public virtual void ResetWorkItemUpdated()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfs))!;

        [JsiiProperty(name: "buildCompleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsBuildCompletedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsBuildCompletedOutputReference BuildCompleted
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsBuildCompletedOutputReference>()!;
        }

        [JsiiProperty(name: "gitPullRequestCommented", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCommentedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCommentedOutputReference GitPullRequestCommented
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCommentedOutputReference>()!;
        }

        [JsiiProperty(name: "gitPullRequestCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreatedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreatedOutputReference GitPullRequestCreated
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreatedOutputReference>()!;
        }

        [JsiiProperty(name: "gitPullRequestMergeAttempted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestMergeAttemptedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestMergeAttemptedOutputReference GitPullRequestMergeAttempted
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestMergeAttemptedOutputReference>()!;
        }

        [JsiiProperty(name: "gitPullRequestUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestUpdatedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestUpdatedOutputReference GitPullRequestUpdated
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestUpdatedOutputReference>()!;
        }

        [JsiiProperty(name: "gitPush", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPushOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsGitPushOutputReference GitPush
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsGitPushOutputReference>()!;
        }

        [JsiiProperty(name: "repositoryCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryCreatedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsRepositoryCreatedOutputReference RepositoryCreated
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsRepositoryCreatedOutputReference>()!;
        }

        [JsiiProperty(name: "repositoryDeleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryDeletedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsRepositoryDeletedOutputReference RepositoryDeleted
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsRepositoryDeletedOutputReference>()!;
        }

        [JsiiProperty(name: "repositoryForked", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryForkedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsRepositoryForkedOutputReference RepositoryForked
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsRepositoryForkedOutputReference>()!;
        }

        [JsiiProperty(name: "repositoryRenamed", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryRenamedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsRepositoryRenamedOutputReference RepositoryRenamed
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsRepositoryRenamedOutputReference>()!;
        }

        [JsiiProperty(name: "repositoryStatusChanged", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryStatusChangedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsRepositoryStatusChangedOutputReference RepositoryStatusChanged
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsRepositoryStatusChangedOutputReference>()!;
        }

        [JsiiProperty(name: "serviceConnectionCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionCreatedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionCreatedOutputReference ServiceConnectionCreated
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionCreatedOutputReference>()!;
        }

        [JsiiProperty(name: "serviceConnectionUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionUpdatedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionUpdatedOutputReference ServiceConnectionUpdated
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionUpdatedOutputReference>()!;
        }

        [JsiiProperty(name: "tfvcCheckin", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTfvcCheckinOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsTfvcCheckinOutputReference TfvcCheckin
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsTfvcCheckinOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTimeoutsOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "workItemCommented", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommentedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommentedOutputReference WorkItemCommented
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommentedOutputReference>()!;
        }

        [JsiiProperty(name: "workItemCreated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCreatedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsWorkItemCreatedOutputReference WorkItemCreated
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsWorkItemCreatedOutputReference>()!;
        }

        [JsiiProperty(name: "workItemDeleted", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemDeletedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsWorkItemDeletedOutputReference WorkItemDeleted
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsWorkItemDeletedOutputReference>()!;
        }

        [JsiiProperty(name: "workItemRestored", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemRestoredOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsWorkItemRestoredOutputReference WorkItemRestored
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsWorkItemRestoredOutputReference>()!;
        }

        [JsiiProperty(name: "workItemUpdated", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemUpdatedOutputReference\"}")]
        public virtual azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsWorkItemUpdatedOutputReference WorkItemUpdated
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsWorkItemUpdatedOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceptUntrustedCertsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AcceptUntrustedCertsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "basicAuthPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BasicAuthPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "basicAuthUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BasicAuthUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildCompletedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsBuildCompleted\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted? BuildCompletedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detailedMessagesToSendInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DetailedMessagesToSendInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitPullRequestCommentedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCommented\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCommented? GitPullRequestCommentedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCommented?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitPullRequestCreatedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestCreated\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCreated? GitPullRequestCreatedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestCreated?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitPullRequestMergeAttemptedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestMergeAttempted\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestMergeAttempted? GitPullRequestMergeAttemptedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestMergeAttempted?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitPullRequestUpdatedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPullRequestUpdated\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestUpdated? GitPullRequestUpdatedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPullRequestUpdated?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitPushInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsGitPush\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPush? GitPushInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsGitPush?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpHeadersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? HttpHeadersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "messagesToSendInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MessagesToSendInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryCreatedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryCreated\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryCreated? RepositoryCreatedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryCreated?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryDeletedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryDeleted\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryDeleted? RepositoryDeletedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryDeleted?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryForkedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryForked\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryForked? RepositoryForkedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryForked?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryRenamedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryRenamed\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryRenamed? RepositoryRenamedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryRenamed?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryStatusChangedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsRepositoryStatusChanged\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryStatusChanged? RepositoryStatusChangedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsRepositoryStatusChanged?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceDetailsToSendInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceDetailsToSendInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceConnectionCreatedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionCreated\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionCreated? ServiceConnectionCreatedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionCreated?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceConnectionUpdatedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsServiceConnectionUpdated\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionUpdated? ServiceConnectionUpdatedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsServiceConnectionUpdated?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tfvcCheckinInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTfvcCheckin\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTfvcCheckin? TfvcCheckinInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTfvcCheckin?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workItemCommentedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommented\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCommented? WorkItemCommentedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCommented?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workItemCreatedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCreated\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCreated? WorkItemCreatedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCreated?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workItemDeletedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemDeleted\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemDeleted? WorkItemDeletedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemDeleted?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workItemRestoredInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemRestored\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemRestored? WorkItemRestoredInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemRestored?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workItemUpdatedInput", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemUpdated\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemUpdated? WorkItemUpdatedInput
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemUpdated?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "acceptUntrustedCerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AcceptUntrustedCerts
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "basicAuthPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BasicAuthPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "basicAuthUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BasicAuthUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "detailedMessagesToSend", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetailedMessagesToSend
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> HttpHeaders
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "messagesToSend", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MessagesToSend
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceDetailsToSend", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceDetailsToSend
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
