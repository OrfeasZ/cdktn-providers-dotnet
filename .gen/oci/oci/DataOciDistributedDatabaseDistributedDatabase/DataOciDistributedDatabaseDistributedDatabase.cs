using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedDatabase
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_database oci_distributed_database_distributed_database}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabase), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabase", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseConfig\"}}]")]
    public class DataOciDistributedDatabaseDistributedDatabase : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_database oci_distributed_database_distributed_database} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDistributedDatabaseDistributedDatabase(Constructs.Construct scope, string id, oci.DataOciDistributedDatabaseDistributedDatabase.IDataOciDistributedDatabaseDistributedDatabaseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDistributedDatabaseDistributedDatabase.IDataOciDistributedDatabaseDistributedDatabaseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedDatabase(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedDatabase(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDistributedDatabaseDistributedDatabase resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDistributedDatabaseDistributedDatabase to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDistributedDatabaseDistributedDatabase that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDistributedDatabaseDistributedDatabase to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDistributedDatabaseDistributedDatabase to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_database#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDistributedDatabaseDistributedDatabase that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDistributedDatabaseDistributedDatabase to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabase), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetMetadataQuery")]
        public virtual void ResetMetadataQuery()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabase))!;

        [JsiiProperty(name: "addGdsControlNodeTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AddGdsControlNodeTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "autoResourceManagementConfig", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseAutoResourceManagementConfigList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseAutoResourceManagementConfigList AutoResourceManagementConfig
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseAutoResourceManagementConfigList>()!;
        }

        [JsiiProperty(name: "catalogDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsList CatalogDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCatalogDetailsList>()!;
        }

        [JsiiProperty(name: "changeDbBackupConfigTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ChangeDbBackupConfigTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "characterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compositeDataGuardShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesList CompositeDataGuardShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCompositeDataGuardShardSpacesList>()!;
        }

        [JsiiProperty(name: "compositeRaftShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesList CompositeRaftShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseCompositeRaftShardSpacesList>()!;
        }

        [JsiiProperty(name: "configureAutoResourceManagementTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfigureAutoResourceManagementTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "configureShardingTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfigureShardingTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseConnectionStringsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseConnectionStringsList ConnectionStrings
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseConnectionStringsList>()!;
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseDbBackupConfigList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseDbBackupConfigList DbBackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseDbBackupConfigList>()!;
        }

        [JsiiProperty(name: "dbDeploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbDeploymentType
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "effectiveSystemRaftReplicationUnitCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EffectiveSystemRaftReplicationUnitCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "gdsControlNodeDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseGdsControlNodeDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseGdsControlNodeDetailsList GdsControlNodeDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseGdsControlNodeDetailsList>()!;
        }

        [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateWalletTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "gsmDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseGsmDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseGsmDetailsList GsmDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseGsmDetailsList>()!;
        }

        [JsiiProperty(name: "gsmSshPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GsmSshPublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestGsmImageDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseLatestGsmImageDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseLatestGsmImageDetailsList LatestGsmImageDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseLatestGsmImageDetailsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ListenerPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "listenerPortTls", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ListenerPortTls
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseMetadataList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseMetadataList>()!;
        }

        [JsiiProperty(name: "moveReplicationUnitTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MoveReplicationUnitTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ncharacterSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NcharacterSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationTopicIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NotificationTopicIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "observedCatalogDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedCatalogDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedCatalogDetailsList ObservedCatalogDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedCatalogDetailsList>()!;
        }

        [JsiiProperty(name: "observedCompositeDataGuardShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedCompositeDataGuardShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedCompositeDataGuardShardSpacesList ObservedCompositeDataGuardShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedCompositeDataGuardShardSpacesList>()!;
        }

        [JsiiProperty(name: "observedCompositeRaftShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedCompositeRaftShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedCompositeRaftShardSpacesList ObservedCompositeRaftShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedCompositeRaftShardSpacesList>()!;
        }

        [JsiiProperty(name: "observedSystemDataGuardDatabases", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedSystemDataGuardDatabasesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedSystemDataGuardDatabasesList ObservedSystemDataGuardDatabases
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedSystemDataGuardDatabasesList>()!;
        }

        [JsiiProperty(name: "observedSystemRaftClusters", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedSystemRaftClustersList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedSystemRaftClustersList ObservedSystemRaftClusters
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedSystemRaftClustersList>()!;
        }

        [JsiiProperty(name: "observedUserShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedUserShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedUserShardSpacesList ObservedUserShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseObservedUserShardSpacesList>()!;
        }

        [JsiiProperty(name: "onsPortLocal", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OnsPortLocal
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "onsPortRemote", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OnsPortRemote
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "operationalState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationalState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabasePatchOperationsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabasePatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabasePatchOperationsList>()!;
        }

        [JsiiProperty(name: "pendingOperationalState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PendingOperationalState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pendingWorkRequestAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PendingWorkRequestAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pendingWorkRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PendingWorkRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pendingWorkRequestOperation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PendingWorkRequestOperation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateEndpointIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PrivateEndpointIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "recreateFailedResourceTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecreateFailedResourceTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "replicationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scaleGsmsTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScaleGsmsTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scanListenerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shardingMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShardingMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartDatabaseTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stopDatabaseTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StopDatabaseTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "systemChunkCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SystemChunkCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "systemDataGuardDatabases", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseSystemDataGuardDatabasesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseSystemDataGuardDatabasesList SystemDataGuardDatabases
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseSystemDataGuardDatabasesList>()!;
        }

        [JsiiProperty(name: "systemRaftClusters", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseSystemRaftClustersList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseSystemRaftClustersList SystemRaftClusters
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseSystemRaftClustersList>()!;
        }

        [JsiiProperty(name: "systemRaftReplicationUnitCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SystemRaftReplicationUnitCount
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseUserShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseUserShardSpacesList UserShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseUserShardSpacesList>()!;
        }

        [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidateNetworkTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "vcnNsgIds", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseVcnNsgIdsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseVcnNsgIdsList VcnNsgIds
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabase.DataOciDistributedDatabaseDistributedDatabaseVcnNsgIdsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "distributedDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DistributedDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataQueryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetadataQueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "distributedDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistributedDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadataQuery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetadataQuery
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
