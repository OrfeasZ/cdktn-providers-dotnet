using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiClass(nativeType: typeof(oci.CoreInstancePool.CoreInstancePoolLifecycleManagementOutputReference), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolLifecycleManagementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreInstancePoolLifecycleManagementOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreInstancePoolLifecycleManagementOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreInstancePoolLifecycleManagementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstancePoolLifecycleManagementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLifecycleActions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActions\"}}]")]
        public virtual void PutLifecycleActions(oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions)}, new object[]{@value});
        }

        [JsiiProperty(name: "lifecycleActions", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsOutputReference\"}")]
        public virtual oci.CoreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsOutputReference LifecycleActions
        {
            get => GetInstanceProperty<oci.CoreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleActionsInput", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagementLifecycleActions\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions? LifecycleActionsInput
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolLifecycleManagementLifecycleActions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolLifecycleManagement\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolLifecycleManagement? InternalValue
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolLifecycleManagement?>();
            set => SetInstanceProperty(value);
        }
    }
}
