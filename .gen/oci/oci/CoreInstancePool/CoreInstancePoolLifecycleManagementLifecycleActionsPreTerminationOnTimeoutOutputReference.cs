using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiClass(nativeType: typeof(oci.CoreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeoutOutputReference), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeoutOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeoutOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeoutOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeoutOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeoutOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "preserveBlockVolumeModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreserveBlockVolumeModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preserveBootVolumeModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreserveBootVolumeModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "preserveBlockVolumeMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreserveBlockVolumeMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preserveBootVolumeMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreserveBootVolumeMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout? InternalValue
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOnTimeout?>();
            set => SetInstanceProperty(value);
        }
    }
}
