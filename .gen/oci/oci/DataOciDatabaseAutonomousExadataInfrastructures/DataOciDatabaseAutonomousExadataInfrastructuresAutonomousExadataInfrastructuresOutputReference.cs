using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousExadataInfrastructures
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseAutonomousExadataInfrastructures.DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresOutputReference), fullyQualifiedName: "oci.dataOciDatabaseAutonomousExadataInfrastructures.DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createAsync", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CreateAsync
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastMaintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastMaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousExadataInfrastructures.DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresMaintenanceWindowList\"}")]
        public virtual oci.DataOciDatabaseAutonomousExadataInfrastructures.DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousExadataInfrastructures.DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "maintenanceWindowDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousExadataInfrastructures.DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresMaintenanceWindowDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousExadataInfrastructures.DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresMaintenanceWindowDetailsList MaintenanceWindowDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousExadataInfrastructures.DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructuresMaintenanceWindowDetailsList>()!;
        }

        [JsiiProperty(name: "nextMaintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextMaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scanDnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScanDnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousExadataInfrastructures.DataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructures\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseAutonomousExadataInfrastructures.IDataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructures? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousExadataInfrastructures.IDataOciDatabaseAutonomousExadataInfrastructuresAutonomousExadataInfrastructures?>();
            set => SetInstanceProperty(value);
        }
    }
}
