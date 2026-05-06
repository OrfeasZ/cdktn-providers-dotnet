using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudVmCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster oci_database_cloud_vm_cluster}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseCloudVmCluster.DatabaseCloudVmCluster), fullyQualifiedName: "oci.databaseCloudVmCluster.DatabaseCloudVmCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterConfig\"}}]")]
    public class DatabaseCloudVmCluster : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster oci_database_cloud_vm_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseCloudVmCluster(Constructs.Construct scope, string id, oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseCloudVmCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseCloudVmCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseCloudVmCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseCloudVmCluster to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseCloudVmCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseCloudVmCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseCloudVmCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseCloudVmCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseCloudVmCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseCloudVmCluster.DatabaseCloudVmCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCloudAutomationUpdateDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetails\"}}]")]
        public virtual void PutCloudAutomationUpdateDetails(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataCollectionOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterDataCollectionOptions\"}}]")]
        public virtual void PutDataCollectionOptions(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterDataCollectionOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterDataCollectionOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileSystemConfigurationDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterFileSystemConfigurationDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFileSystemConfigurationDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterFileSystemConfigurationDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterFileSystemConfigurationDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterFileSystemConfigurationDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackupNetworkNsgIds")]
        public virtual void ResetBackupNetworkNsgIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudAutomationUpdateDetails")]
        public virtual void ResetCloudAutomationUpdateDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterName")]
        public virtual void ResetClusterName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateAsync")]
        public virtual void ResetCreateAsync()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataCollectionOptions")]
        public virtual void ResetDataCollectionOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataStoragePercentage")]
        public virtual void ResetDataStoragePercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataStorageSizeInTbs")]
        public virtual void ResetDataStorageSizeInTbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbNodeStorageSizeInGbs")]
        public virtual void ResetDbNodeStorageSizeInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbServers")]
        public virtual void ResetDbServers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomain")]
        public virtual void ResetDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExascaleDbStorageVaultId")]
        public virtual void ResetExascaleDbStorageVaultId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileSystemConfigurationDetails")]
        public virtual void ResetFileSystemConfigurationDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsLocalBackupEnabled")]
        public virtual void ResetIsLocalBackupEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsSparseDiskgroupEnabled")]
        public virtual void ResetIsSparseDiskgroupEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenseModel")]
        public virtual void ResetLicenseModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemorySizeInGbs")]
        public virtual void ResetMemorySizeInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNsgIds")]
        public virtual void ResetNsgIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcpuCount")]
        public virtual void ResetOcpuCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateZoneId")]
        public virtual void ResetPrivateZoneId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScanListenerPortTcp")]
        public virtual void ResetScanListenerPortTcp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScanListenerPortTcpSsl")]
        public virtual void ResetScanListenerPortTcpSsl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityAttributes")]
        public virtual void ResetSecurityAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscriptionId")]
        public virtual void ResetSubscriptionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemVersion")]
        public virtual void ResetSystemVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTdeKeyStoreType")]
        public virtual void ResetTdeKeyStoreType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeZone")]
        public virtual void ResetTimeZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmClusterType")]
        public virtual void ResetVmClusterType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.DatabaseCloudVmCluster.DatabaseCloudVmCluster))!;

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudAutomationUpdateDetails", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsOutputReference\"}")]
        public virtual oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsOutputReference CloudAutomationUpdateDetails
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataCollectionOptions", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterDataCollectionOptionsOutputReference\"}")]
        public virtual oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterDataCollectionOptionsOutputReference DataCollectionOptions
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterDataCollectionOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "diskRedundancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskRedundancy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSystemConfigurationDetails", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterFileSystemConfigurationDetailsList\"}")]
        public virtual oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterFileSystemConfigurationDetailsList FileSystemConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterFileSystemConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "iormConfigCache", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterIormConfigCacheList\"}")]
        public virtual oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterIormConfigCacheList IormConfigCache
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterIormConfigCacheList>()!;
        }

        [JsiiProperty(name: "lastUpdateHistoryEntryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdateHistoryEntryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListenerPort
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "multiCloudIdentityConnectorConfigs", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterMultiCloudIdentityConnectorConfigsList\"}")]
        public virtual oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterMultiCloudIdentityConnectorConfigsList MultiCloudIdentityConnectorConfigs
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterMultiCloudIdentityConnectorConfigsList>()!;
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scanDnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScanDnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scanDnsRecordId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScanDnsRecordId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scanIpIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ScanIpIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scanIpv6Ids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ScanIpv6Ids
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "storageManagementType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageManagementType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vipIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VipIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "vipv6Ids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Vipv6Ids
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupNetworkNsgIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? BackupNetworkNsgIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupSubnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupSubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudAutomationUpdateDetailsInput", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetails\"}", isOptional: true)]
        public virtual oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetails? CloudAutomationUpdateDetailsInput
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudExadataInfrastructureIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudExadataInfrastructureIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuCoreCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CpuCoreCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createAsyncInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CreateAsyncInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataCollectionOptionsInput", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterDataCollectionOptions\"}", isOptional: true)]
        public virtual oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterDataCollectionOptions? DataCollectionOptionsInput
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterDataCollectionOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataStoragePercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataStoragePercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataStorageSizeInTbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataStorageSizeInTbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbNodeStorageSizeInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DbNodeStorageSizeInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbServersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DbServersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exascaleDbStorageVaultIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExascaleDbStorageVaultIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfigurationDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterFileSystemConfigurationDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FileSystemConfigurationDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "giVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GiVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isLocalBackupEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsLocalBackupEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isSparseDiskgroupEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsSparseDiskgroupEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LicenseModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memorySizeInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemorySizeInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nsgIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NsgIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocpuCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OcpuCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateZoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scanListenerPortTcpInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ScanListenerPortTcpInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scanListenerPortTcpSslInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ScanListenerPortTcpSslInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SecurityAttributesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshPublicKeysInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SshPublicKeysInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SystemVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tdeKeyStoreTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TdeKeyStoreTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmClusterTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmClusterTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backupNetworkNsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BackupNetworkNsgIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupSubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createAsync", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object CreateAsync
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "dataStoragePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStoragePercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbNodeStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DbNodeStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DbServers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exascaleDbStorageVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExascaleDbStorageVaultId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "giVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GiVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isLocalBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsLocalBackupEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isSparseDiskgroupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsSparseDiskgroupEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ocpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpuCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scanListenerPortTcp", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPortTcp
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scanListenerPortTcpSsl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPortTcpSsl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SecurityAttributes
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sshPublicKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SshPublicKeys
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "systemVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tdeKeyStoreType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TdeKeyStoreType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmClusterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
