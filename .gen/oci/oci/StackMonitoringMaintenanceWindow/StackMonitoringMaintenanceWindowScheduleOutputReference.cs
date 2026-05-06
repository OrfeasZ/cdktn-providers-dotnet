using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMaintenanceWindow
{
    [JsiiClass(nativeType: typeof(oci.StackMonitoringMaintenanceWindow.StackMonitoringMaintenanceWindowScheduleOutputReference), fullyQualifiedName: "oci.stackMonitoringMaintenanceWindow.StackMonitoringMaintenanceWindowScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StackMonitoringMaintenanceWindowScheduleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StackMonitoringMaintenanceWindowScheduleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StackMonitoringMaintenanceWindowScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMaintenanceWindowScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaintenanceWindowDuration")]
        public virtual void ResetMaintenanceWindowDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceWindowRecurrences")]
        public virtual void ResetMaintenanceWindowRecurrences()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeMaintenanceWindowEnd")]
        public virtual void ResetTimeMaintenanceWindowEnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeMaintenanceWindowStart")]
        public virtual void ResetTimeMaintenanceWindowStart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceWindowDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowRecurrencesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceWindowRecurrencesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduleTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeMaintenanceWindowEndInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeMaintenanceWindowEndInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeMaintenanceWindowStartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeMaintenanceWindowStartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maintenanceWindowDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceWindowDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maintenanceWindowRecurrences", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceWindowRecurrences
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

        [JsiiProperty(name: "timeMaintenanceWindowEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaintenanceWindowEnd
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeMaintenanceWindowStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaintenanceWindowStart
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.stackMonitoringMaintenanceWindow.StackMonitoringMaintenanceWindowSchedule\"}", isOptional: true)]
        public virtual oci.StackMonitoringMaintenanceWindow.IStackMonitoringMaintenanceWindowSchedule? InternalValue
        {
            get => GetInstanceProperty<oci.StackMonitoringMaintenanceWindow.IStackMonitoringMaintenanceWindowSchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
