using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiClass(nativeType: typeof(oci.CoreInstancePool.CoreInstancePoolInstanceMaintenancePolicyOutputReference), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreInstancePoolInstanceMaintenancePolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreInstancePoolInstanceMaintenancePolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreInstancePoolInstanceMaintenancePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstancePoolInstanceMaintenancePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLaunchBeforeTerminating", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating\"}}]")]
        public virtual void PutLaunchBeforeTerminating(oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLaunchBeforeTerminating")]
        public virtual void ResetLaunchBeforeTerminating()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "launchBeforeTerminating", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminatingOutputReference\"}")]
        public virtual oci.CoreInstancePool.CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminatingOutputReference LaunchBeforeTerminating
        {
            get => GetInstanceProperty<oci.CoreInstancePool.CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminatingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchBeforeTerminatingInput", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating? LaunchBeforeTerminatingInput
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicyLaunchBeforeTerminating?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolInstanceMaintenancePolicy\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicy? InternalValue
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolInstanceMaintenancePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
