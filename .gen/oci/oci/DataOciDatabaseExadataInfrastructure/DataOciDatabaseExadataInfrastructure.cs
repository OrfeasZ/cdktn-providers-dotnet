using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseExadataInfrastructure
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exadata_infrastructure oci_database_exadata_infrastructure}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructure), fullyQualifiedName: "oci.dataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructure", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureConfig\"}}]")]
    public class DataOciDatabaseExadataInfrastructure : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exadata_infrastructure oci_database_exadata_infrastructure} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseExadataInfrastructure(Constructs.Construct scope, string id, oci.DataOciDatabaseExadataInfrastructure.IDataOciDatabaseExadataInfrastructureConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseExadataInfrastructure.IDataOciDatabaseExadataInfrastructureConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseExadataInfrastructure(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseExadataInfrastructure(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseExadataInfrastructure resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseExadataInfrastructure to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseExadataInfrastructure that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseExadataInfrastructure to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseExadataInfrastructure to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_exadata_infrastructure#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseExadataInfrastructure that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseExadataInfrastructure to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructure), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructure))!;

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

        [JsiiProperty(name: "contacts", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureContactsList\"}")]
        public virtual oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureContactsList Contacts
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureContactsList>()!;
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

        [JsiiProperty(name: "definedFileSystemConfigurations", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureDefinedFileSystemConfigurationsList\"}")]
        public virtual oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureDefinedFileSystemConfigurationsList DefinedFileSystemConfigurations
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureDefinedFileSystemConfigurationsList>()!;
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

        [JsiiProperty(name: "exascaleConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureExascaleConfigList\"}")]
        public virtual oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureExascaleConfigList ExascaleConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureExascaleConfigList>()!;
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

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureMaintenanceWindowList\"}")]
        public virtual oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureMaintenanceWindowList>()!;
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

        [JsiiProperty(name: "networkBondingModeDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureNetworkBondingModeDetailsList\"}")]
        public virtual oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureNetworkBondingModeDetailsList NetworkBondingModeDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadataInfrastructure.DataOciDatabaseExadataInfrastructureNetworkBondingModeDetailsList>()!;
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
        [JsiiProperty(name: "exadataInfrastructureIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExadataInfrastructureIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "exadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
