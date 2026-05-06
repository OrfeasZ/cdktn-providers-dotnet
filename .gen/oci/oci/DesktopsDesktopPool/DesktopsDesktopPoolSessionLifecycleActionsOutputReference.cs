using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiClass(nativeType: typeof(oci.DesktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsOutputReference), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DesktopsDesktopPoolSessionLifecycleActionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DesktopsDesktopPoolSessionLifecycleActionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DesktopsDesktopPoolSessionLifecycleActionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DesktopsDesktopPoolSessionLifecycleActionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDisconnect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnect\"}}]")]
        public virtual void PutDisconnect(oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInactivity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsInactivity\"}}]")]
        public virtual void PutInactivity(oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsInactivity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsInactivity)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisconnect")]
        public virtual void ResetDisconnect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInactivity")]
        public virtual void ResetInactivity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "disconnect", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnectOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnectOutputReference Disconnect
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnectOutputReference>()!;
        }

        [JsiiProperty(name: "inactivity", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsInactivityOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsInactivityOutputReference Inactivity
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsInactivityOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "disconnectInput", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnect\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect? DisconnectInput
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inactivityInput", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsInactivity\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsInactivity? InactivityInput
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsInactivity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActions\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActions? InternalValue
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActions?>();
            set => SetInstanceProperty(value);
        }
    }
}
