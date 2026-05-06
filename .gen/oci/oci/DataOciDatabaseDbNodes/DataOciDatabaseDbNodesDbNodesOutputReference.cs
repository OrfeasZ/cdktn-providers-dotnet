using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseDbNodes
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseDbNodes.DataOciDatabaseDbNodesDbNodesOutputReference), fullyQualifiedName: "oci.dataOciDatabaseDbNodes.DataOciDatabaseDbNodesDbNodesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseDbNodesDbNodesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseDbNodesDbNodesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseDbNodesDbNodesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseDbNodesDbNodesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdditionalDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupIpId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupIpId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupIpv6Id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupIpv6Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupVnic2Id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupVnic2Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupVnicId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupVnicId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbNodeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbNodeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbNodeStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DbNodeStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbServerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbServerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hostIpId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostIpId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostIpv6Id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostIpv6Id
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "softwareStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SoftwareStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
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

        [JsiiProperty(name: "totalCpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalCpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "vnic2Id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Vnic2Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vnicId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VnicId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseDbNodes.DataOciDatabaseDbNodesDbNodes\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseDbNodes.IDataOciDatabaseDbNodesDbNodes? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseDbNodes.IDataOciDatabaseDbNodesDbNodes?>();
            set => SetInstanceProperty(value);
        }
    }
}
