using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousVmClusters
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseAutonomousVmClusters.DataOciDatabaseAutonomousVmClustersAutonomousVmClustersOutputReference), fullyQualifiedName: "oci.dataOciDatabaseAutonomousVmClusters.DataOciDatabaseAutonomousVmClustersAutonomousVmClustersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseAutonomousVmClustersAutonomousVmClustersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseAutonomousVmClustersAutonomousVmClustersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseAutonomousVmClustersAutonomousVmClustersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousVmClustersAutonomousVmClustersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autonomousDataStoragePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutonomousDataStoragePercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "autonomousDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutonomousDataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableAutonomousDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableAutonomousDataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableContainerDatabases
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableDataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuCoreCountPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCountPerNode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpuPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuPercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpusEnabled", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpusEnabled
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpusLowestScaledValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpusLowestScaledValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbNodeStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DbNodeStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DbServers
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "exadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataStorageInTbsLowestScaledValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExadataStorageInTbsLowestScaledValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isLocalBackupEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLocalBackupEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMtlsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMtlsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousVmClusters.DataOciDatabaseAutonomousVmClustersAutonomousVmClustersMaintenanceWindowList\"}")]
        public virtual oci.DataOciDatabaseAutonomousVmClusters.DataOciDatabaseAutonomousVmClustersAutonomousVmClustersMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousVmClusters.DataOciDatabaseAutonomousVmClustersAutonomousVmClustersMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "maintenanceWindowDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousVmClusters.DataOciDatabaseAutonomousVmClustersAutonomousVmClustersMaintenanceWindowDetailsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousVmClusters.DataOciDatabaseAutonomousVmClustersAutonomousVmClustersMaintenanceWindowDetailsList MaintenanceWindowDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousVmClusters.DataOciDatabaseAutonomousVmClustersAutonomousVmClustersMaintenanceWindowDetailsList>()!;
        }

        [JsiiProperty(name: "maxAcdsLowestScaledValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAcdsLowestScaledValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryPerComputeUnitInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryPerComputeUnitInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryPerOracleComputeUnitInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryPerOracleComputeUnitInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nextMaintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextMaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nonProvisionableAutonomousContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NonProvisionableAutonomousContainerDatabases
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocpusEnabled", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpusEnabled
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "provisionableAutonomousContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionableAutonomousContainerDatabases
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "provisionedAutonomousContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedAutonomousContainerDatabases
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "provisionedCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "reclaimableCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReclaimableCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "reservedCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReservedCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scanListenerPortNonTls", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPortNonTls
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scanListenerPortTls", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPortTls
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

        [JsiiProperty(name: "timeDatabaseSslCertificateExpires", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeDatabaseSslCertificateExpires
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOrdsCertificateExpires", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOrdsCertificateExpires
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalAutonomousDataStorageInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalAutonomousDataStorageInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalContainerDatabases
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "vmClusterNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterNetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousVmClusters.DataOciDatabaseAutonomousVmClustersAutonomousVmClusters\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseAutonomousVmClusters.IDataOciDatabaseAutonomousVmClustersAutonomousVmClusters? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousVmClusters.IDataOciDatabaseAutonomousVmClustersAutonomousVmClusters?>();
            set => SetInstanceProperty(value);
        }
    }
}
