using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMaintenanceWindow
{
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowScheduleOutputReference), fullyQualifiedName: "oci.dataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciStackMonitoringMaintenanceWindowScheduleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciStackMonitoringMaintenanceWindowScheduleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMaintenanceWindowScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMaintenanceWindowScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "maintenanceWindowDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceWindowDuration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindowRecurrences", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceWindowRecurrences
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduleType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduleType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMaintenanceWindowEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaintenanceWindowEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMaintenanceWindowStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMaintenanceWindowStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowSchedule\"}", isOptional: true)]
        public virtual oci.DataOciStackMonitoringMaintenanceWindow.IDataOciStackMonitoringMaintenanceWindowSchedule? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMaintenanceWindow.IDataOciStackMonitoringMaintenanceWindowSchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
