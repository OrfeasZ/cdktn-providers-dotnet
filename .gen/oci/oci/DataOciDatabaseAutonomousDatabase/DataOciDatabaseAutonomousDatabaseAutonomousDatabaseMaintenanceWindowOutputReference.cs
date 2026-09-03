using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousDatabase
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference), fullyQualifiedName: "oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeekList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeekList DayOfWeek
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindowDayOfWeekList>()!;
        }

        [JsiiProperty(name: "isMaintenanceWindowChangeScheduled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMaintenanceWindowChangeScheduled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maintenanceEndTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceEndTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceStartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabase.DataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseAutonomousDatabase.IDataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabase.IDataOciDatabaseAutonomousDatabaseAutonomousDatabaseMaintenanceWindow?>();
            set => SetInstanceProperty(value);
        }
    }
}
