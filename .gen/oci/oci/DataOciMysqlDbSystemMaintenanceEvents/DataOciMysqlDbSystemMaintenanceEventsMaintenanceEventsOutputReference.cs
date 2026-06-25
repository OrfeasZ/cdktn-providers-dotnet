using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlDbSystemMaintenanceEvents
{
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsMaintenanceEventsOutputReference), fullyQualifiedName: "oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsMaintenanceEventsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMysqlDbSystemMaintenanceEventsMaintenanceEventsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMysqlDbSystemMaintenanceEventsMaintenanceEventsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMysqlDbSystemMaintenanceEventsMaintenanceEventsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlDbSystemMaintenanceEventsMaintenanceEventsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceNotes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceNotes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceScope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceScope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mysqlVersionAfterMaintenance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MysqlVersionAfterMaintenance
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mysqlVersionBeforeMaintenance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MysqlVersionBeforeMaintenance
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMysqlSwitchOverEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMysqlSwitchOverEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeMysqlSwitchOverStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeMysqlSwitchOverStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMysqlDbSystemMaintenanceEvents.DataOciMysqlDbSystemMaintenanceEventsMaintenanceEvents\"}", isOptional: true)]
        public virtual oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsMaintenanceEvents? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMysqlDbSystemMaintenanceEvents.IDataOciMysqlDbSystemMaintenanceEventsMaintenanceEvents?>();
            set => SetInstanceProperty(value);
        }
    }
}
