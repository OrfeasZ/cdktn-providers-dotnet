using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiClass(nativeType: typeof(oci.DesktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnectOutputReference), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnectOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DesktopsDesktopPoolSessionLifecycleActionsDisconnectOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DesktopsDesktopPoolSessionLifecycleActionsDisconnectOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DesktopsDesktopPoolSessionLifecycleActionsDisconnectOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DesktopsDesktopPoolSessionLifecycleActionsDisconnectOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGracePeriodInMinutes")]
        public virtual void ResetGracePeriodInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gracePeriodInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GracePeriodInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gracePeriodInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GracePeriodInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolSessionLifecycleActionsDisconnect\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect? InternalValue
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolSessionLifecycleActionsDisconnect?>();
            set => SetInstanceProperty(value);
        }
    }
}
