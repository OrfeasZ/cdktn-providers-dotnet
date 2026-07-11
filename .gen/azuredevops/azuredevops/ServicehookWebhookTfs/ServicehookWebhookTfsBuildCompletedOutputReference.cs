using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServicehookWebhookTfs
{
    [JsiiClass(nativeType: typeof(azuredevops.ServicehookWebhookTfs.ServicehookWebhookTfsBuildCompletedOutputReference), fullyQualifiedName: "azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsBuildCompletedOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServicehookWebhookTfsBuildCompletedOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServicehookWebhookTfsBuildCompletedOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServicehookWebhookTfsBuildCompletedOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicehookWebhookTfsBuildCompletedOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBuildStatus")]
        public virtual void ResetBuildStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinitionName")]
        public virtual void ResetDefinitionName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definitionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefinitionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "buildStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definitionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefinitionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.servicehookWebhookTfs.ServicehookWebhookTfsBuildCompleted\"}", isOptional: true)]
        public virtual azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted? InternalValue
        {
            get => GetInstanceProperty<azuredevops.ServicehookWebhookTfs.IServicehookWebhookTfsBuildCompleted?>();
            set => SetInstanceProperty(value);
        }
    }
}
