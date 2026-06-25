using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseDatabase
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseDatabase.DataOciDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseDatabase.DataOciDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "timeOfLastReadinessCheck", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfLastReadinessCheck
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOfStatusUpdate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOfStatusUpdate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeScheduled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updateReadinessStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateReadinessStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updateReadinessStatusDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateReadinessStatusDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseDatabase.DataOciDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseDatabase.IDataOciDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseDatabase.IDataOciDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
