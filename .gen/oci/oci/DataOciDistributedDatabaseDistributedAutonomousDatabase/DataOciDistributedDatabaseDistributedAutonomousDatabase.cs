using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedAutonomousDatabase
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_autonomous_database oci_distributed_database_distributed_autonomous_database}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabase), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabase", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseConfig\"}}]")]
    public class DataOciDistributedDatabaseDistributedAutonomousDatabase : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_autonomous_database oci_distributed_database_distributed_autonomous_database} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDistributedDatabaseDistributedAutonomousDatabase(Constructs.Construct scope, string id, oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.IDataOciDistributedDatabaseDistributedAutonomousDatabaseConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.IDataOciDistributedDatabaseDistributedAutonomousDatabaseConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedAutonomousDatabase(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedAutonomousDatabase(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDistributedDatabaseDistributedAutonomousDatabase resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDistributedDatabaseDistributedAutonomousDatabase to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDistributedDatabaseDistributedAutonomousDatabase that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDistributedDatabaseDistributedAutonomousDatabase to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDistributedDatabaseDistributedAutonomousDatabase to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/data-sources/distributed_database_distributed_autonomous_database#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDistributedDatabaseDistributedAutonomousDatabase that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDistributedDatabaseDistributedAutonomousDatabase to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabase), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabase))!;

        [JsiiProperty(name: "addGdsControlNodeTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AddGdsControlNodeTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "autoResourceManagementConfig", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseAutoResourceManagementConfigList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseAutoResourceManagementConfigList AutoResourceManagementConfig
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseAutoResourceManagementConfigList>()!;
        }

        [JsiiProperty(name: "catalogDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsList CatalogDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCatalogDetailsList>()!;
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

        [JsiiProperty(name: "compositeDataGuardShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCompositeDataGuardShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCompositeDataGuardShardSpacesList CompositeDataGuardShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCompositeDataGuardShardSpacesList>()!;
        }

        [JsiiProperty(name: "compositeRaftShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpacesList CompositeRaftShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseCompositeRaftShardSpacesList>()!;
        }

        [JsiiProperty(name: "configureAutoResourceManagementTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfigureAutoResourceManagementTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "configureGsmWalletTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfigureGsmWalletTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "configureShardingTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfigureShardingTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseConnectionStringsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseConnectionStringsList ConnectionStrings
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseConnectionStringsList>()!;
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigList DbBackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseDbBackupConfigList>()!;
        }

        [JsiiProperty(name: "dbDeploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbDeploymentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbWorkloadType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbWorkloadType
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

        [JsiiProperty(name: "gdsControlNodeDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseGdsControlNodeDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseGdsControlNodeDetailsList GdsControlNodeDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseGdsControlNodeDetailsList>()!;
        }

        [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateWalletTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "gsmDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseGsmDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseGsmDetailsList GsmDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseGsmDetailsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestGsmImage", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseLatestGsmImageList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseLatestGsmImageList LatestGsmImage
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseLatestGsmImageList>()!;
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

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseMetadataList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseMetadataList>()!;
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

        [JsiiProperty(name: "observedCatalogDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedCatalogDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedCatalogDetailsList ObservedCatalogDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedCatalogDetailsList>()!;
        }

        [JsiiProperty(name: "observedCompositeDataGuardShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedCompositeDataGuardShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedCompositeDataGuardShardSpacesList ObservedCompositeDataGuardShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedCompositeDataGuardShardSpacesList>()!;
        }

        [JsiiProperty(name: "observedCompositeRaftShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedCompositeRaftShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedCompositeRaftShardSpacesList ObservedCompositeRaftShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedCompositeRaftShardSpacesList>()!;
        }

        [JsiiProperty(name: "observedSystemDataGuardDatabases", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedSystemDataGuardDatabasesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedSystemDataGuardDatabasesList ObservedSystemDataGuardDatabases
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedSystemDataGuardDatabasesList>()!;
        }

        [JsiiProperty(name: "observedSystemRaftClusters", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedSystemRaftClustersList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedSystemRaftClustersList ObservedSystemRaftClusters
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedSystemRaftClustersList>()!;
        }

        [JsiiProperty(name: "observedUserShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedUserShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedUserShardSpacesList ObservedUserShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseObservedUserShardSpacesList>()!;
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

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabasePatchOperationsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabasePatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabasePatchOperationsList>()!;
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

        [JsiiProperty(name: "systemDataGuardDatabases", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesList SystemDataGuardDatabases
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseSystemDataGuardDatabasesList>()!;
        }

        [JsiiProperty(name: "systemRaftClusters", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseSystemRaftClustersList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseSystemRaftClustersList SystemRaftClusters
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseSystemRaftClustersList>()!;
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

        [JsiiProperty(name: "userShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesList UserShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseUserShardSpacesList>()!;
        }

        [JsiiProperty(name: "validateCaBundleTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidateCaBundleTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidateNetworkTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "vcnNsgIds", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseVcnNsgIdsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseVcnNsgIdsList VcnNsgIds
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabase.DataOciDistributedDatabaseDistributedAutonomousDatabaseVcnNsgIdsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "distributedAutonomousDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DistributedAutonomousDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataQueryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetadataQueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "distributedAutonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistributedAutonomousDatabaseId
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
