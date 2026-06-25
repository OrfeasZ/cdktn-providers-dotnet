using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiClass(nativeType: typeof(oci.CoreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsOutputReference), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreInstancePoolLifecycleManagementLifecycleActionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreInstancePoolLifecycleManagementLifecycleActionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreInstancePoolLifecycleManagementLifecycleActionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstancePoolLifecycleManagementLifecycleActionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPreTermination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTermination\"}}]")]
        public virtual void PutPreTermination(oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPreTermination")]
        public virtual void ResetPreTermination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "preTermination", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOutputReference\"}")]
        public virtual oci.CoreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOutputReference PreTermination
        {
            get => GetInstanceProperty<oci.CoreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTerminationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preTerminationInput", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsPreTermination\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination? PreTerminationInput
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActionsPreTermination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActions\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions? InternalValue
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions?>();
            set => SetInstanceProperty(value);
        }
    }
}
