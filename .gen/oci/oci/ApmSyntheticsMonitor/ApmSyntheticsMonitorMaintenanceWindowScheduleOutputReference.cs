using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiClass(nativeType: typeof(oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorMaintenanceWindowScheduleOutputReference), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorMaintenanceWindowScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApmSyntheticsMonitorMaintenanceWindowScheduleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApmSyntheticsMonitorMaintenanceWindowScheduleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApmSyntheticsMonitorMaintenanceWindowScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmSyntheticsMonitorMaintenanceWindowScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTimeEnded")]
        public virtual void ResetTimeEnded()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeStarted")]
        public virtual void ResetTimeStarted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeEndedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeEndedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeStartedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeStartedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnded
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorMaintenanceWindowSchedule\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorMaintenanceWindowSchedule? InternalValue
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorMaintenanceWindowSchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
