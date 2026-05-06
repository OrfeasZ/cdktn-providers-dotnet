using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepository
{
    [JsiiClass(nativeType: typeof(oci.DevopsRepository.DevopsRepositoryMirrorRepositoryConfigOutputReference), fullyQualifiedName: "oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevopsRepositoryMirrorRepositoryConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevopsRepositoryMirrorRepositoryConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevopsRepositoryMirrorRepositoryConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsRepositoryMirrorRepositoryConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTriggerSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerSchedule\"}}]")]
        public virtual void PutTriggerSchedule(oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectorId")]
        public virtual void ResetConnectorId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryUrl")]
        public virtual void ResetRepositoryUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggerSchedule")]
        public virtual void ResetTriggerSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "triggerSchedule", typeJson: "{\"fqn\":\"oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerScheduleOutputReference\"}")]
        public virtual oci.DevopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerScheduleOutputReference TriggerSchedule
        {
            get => GetInstanceProperty<oci.DevopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerScheduleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerScheduleInput", typeJson: "{\"fqn\":\"oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerSchedule\"}", isOptional: true)]
        public virtual oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule? TriggerScheduleInput
        {
            get => GetInstanceProperty<oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule?>();
        }

        [JsiiProperty(name: "connectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfig\"}", isOptional: true)]
        public virtual oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
