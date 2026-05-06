using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepository
{
    [JsiiClass(nativeType: typeof(oci.DevopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerScheduleOutputReference), fullyQualifiedName: "oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevopsRepositoryMirrorRepositoryConfigTriggerScheduleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevopsRepositoryMirrorRepositoryConfigTriggerScheduleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevopsRepositoryMirrorRepositoryConfigTriggerScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsRepositoryMirrorRepositoryConfigTriggerScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCustomSchedule")]
        public virtual void ResetCustomSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "customScheduleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomScheduleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduleTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "customSchedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomSchedule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scheduleType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduleType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.devopsRepository.DevopsRepositoryMirrorRepositoryConfigTriggerSchedule\"}", isOptional: true)]
        public virtual oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule? InternalValue
        {
            get => GetInstanceProperty<oci.DevopsRepository.IDevopsRepositoryMirrorRepositoryConfigTriggerSchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
