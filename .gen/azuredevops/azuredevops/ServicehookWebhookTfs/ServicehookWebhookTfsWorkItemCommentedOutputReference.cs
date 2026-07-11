using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiClass(nativeType: typeof(azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommentedOutputReference), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommentedOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServicehookWebhookTfsWorkItemCommentedOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServicehookWebhookTfsWorkItemCommentedOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServicehookWebhookTfsWorkItemCommentedOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicehookWebhookTfsWorkItemCommentedOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAreaPath")]
        public virtual void ResetAreaPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommentPattern")]
        public virtual void ResetCommentPattern()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTag")]
        public virtual void ResetTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkItemType")]
        public virtual void ResetWorkItemType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "areaPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AreaPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commentPatternInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommentPatternInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TagInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workItemTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkItemTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "areaPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AreaPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "commentPattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommentPattern
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tag
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workItemType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkItemType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsWorkItemCommented\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCommented? InternalValue
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsWorkItemCommented?>();
            set => SetInstanceProperty(value);
        }
    }
}
