using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseExadataInfrastructures
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresOutputReference), fullyQualifiedName: "oci.dataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseExadataInfrastructuresExadataInfrastructuresOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseExadataInfrastructuresExadataInfrastructuresOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseExadataInfrastructuresExadataInfrastructuresOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseExadataInfrastructuresExadataInfrastructuresOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activatedStorageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActivatedStorageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "activationFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivationFile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "additionalComputeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdditionalComputeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "additionalComputeSystemModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdditionalComputeSystemModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "additionalStorageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdditionalStorageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "adminNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminNetworkCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudControlPlaneServer1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudControlPlaneServer1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudControlPlaneServer2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudControlPlaneServer2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
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

        [JsiiProperty(name: "contacts", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresContactsList\"}")]
        public virtual oci.DataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresContactsList Contacts
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresContactsList>()!;
        }

        [JsiiProperty(name: "corporateProxy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CorporateProxy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpusEnabled", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpusEnabled
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createAsync", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CreateAsync
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "csiNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsiNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseServerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseServerType
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "dbServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbServerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedFileSystemConfigurations", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresDefinedFileSystemConfigurationsList\"}")]
        public virtual oci.DataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresDefinedFileSystemConfigurationsList DefinedFileSystemConfigurations
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresDefinedFileSystemConfigurationsList>()!;
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

        [JsiiProperty(name: "dnsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsServer
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "exascaleConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresExascaleConfigList\"}")]
        public virtual oci.DataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresExascaleConfigList ExascaleConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresExascaleConfigList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Gateway
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infiniBandNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfiniBandNetworkCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isCpsOfflineReportEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCpsOfflineReportEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMultiRackDeployment", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMultiRackDeployment
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSchedulingPolicyAssociated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSchedulingPolicyAssociated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceSloStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceSloStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresMaintenanceWindowList\"}")]
        public virtual oci.DataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "maxCpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxDataStorageInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDataStorageInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxDbNodeStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDbNodeStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxMemoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxMemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "monthlyDbServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonthlyDbServerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "multiRackConfigurationFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MultiRackConfigurationFile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Netmask
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkBondingModeDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresNetworkBondingModeDetailsList\"}")]
        public virtual oci.DataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresNetworkBondingModeDetailsList NetworkBondingModeDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructuresNetworkBondingModeDetailsList>()!;
        }

        [JsiiProperty(name: "ntpServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NtpServer
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "rackSerialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RackSerialNumber
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

        [JsiiProperty(name: "storageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "storageServerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageServerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageServerVersion
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

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructures.DataOciDatabaseExadataInfrastructuresExadataInfrastructures\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseExadataInfrastructures.IDataOciDatabaseExadataInfrastructuresExadataInfrastructures? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadataInfrastructures.IDataOciDatabaseExadataInfrastructuresExadataInfrastructures?>();
            set => SetInstanceProperty(value);
        }
    }
}
