using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiClass(nativeType: typeof(oci.DesktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyOutputReference), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DesktopsDesktopPoolAvailabilityPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DesktopsDesktopPoolAvailabilityPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DesktopsDesktopPoolAvailabilityPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DesktopsDesktopPoolAvailabilityPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStartSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStartSchedule\"}}]")]
        public virtual void PutStartSchedule(oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStartSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStartSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStopSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStopSchedule\"}}]")]
        public virtual void PutStopSchedule(oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStopSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStopSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetStartSchedule")]
        public virtual void ResetStartSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStopSchedule")]
        public virtual void ResetStopSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "startSchedule", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStartScheduleOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStartScheduleOutputReference StartSchedule
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStartScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "stopSchedule", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStopScheduleOutputReference\"}")]
        public virtual oci.DesktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStopScheduleOutputReference StopSchedule
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStopScheduleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "startScheduleInput", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStartSchedule\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStartSchedule? StartScheduleInput
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStartSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stopScheduleInput", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicyStopSchedule\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStopSchedule? StopScheduleInput
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicyStopSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.desktopsDesktopPool.DesktopsDesktopPoolAvailabilityPolicy\"}", isOptional: true)]
        public virtual oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicy? InternalValue
        {
            get => GetInstanceProperty<oci.DesktopsDesktopPool.IDesktopsDesktopPoolAvailabilityPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
