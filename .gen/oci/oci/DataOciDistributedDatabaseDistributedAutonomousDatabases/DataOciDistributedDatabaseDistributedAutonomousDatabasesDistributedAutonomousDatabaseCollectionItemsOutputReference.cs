using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedAutonomousDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addGdsControlNodeTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AddGdsControlNodeTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "autoResourceManagementConfig", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsAutoResourceManagementConfigList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsAutoResourceManagementConfigList AutoResourceManagementConfig
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsAutoResourceManagementConfigList>()!;
        }

        [JsiiProperty(name: "catalogDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsCatalogDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsCatalogDetailsList CatalogDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsCatalogDetailsList>()!;
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

        [JsiiProperty(name: "compositeDataGuardShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsCompositeDataGuardShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsCompositeDataGuardShardSpacesList CompositeDataGuardShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsCompositeDataGuardShardSpacesList>()!;
        }

        [JsiiProperty(name: "compositeRaftShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsCompositeRaftShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsCompositeRaftShardSpacesList CompositeRaftShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsCompositeRaftShardSpacesList>()!;
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

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsConnectionStringsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsConnectionStringsList ConnectionStrings
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsConnectionStringsList>()!;
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsDbBackupConfigList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsDbBackupConfigList DbBackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsDbBackupConfigList>()!;
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

        [JsiiProperty(name: "gdsControlNodeDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsGdsControlNodeDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsGdsControlNodeDetailsList GdsControlNodeDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsGdsControlNodeDetailsList>()!;
        }

        [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateWalletTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "gsmDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsGsmDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsGsmDetailsList GsmDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsGsmDetailsList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestGsmImage", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsLatestGsmImageList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsLatestGsmImageList LatestGsmImage
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsLatestGsmImageList>()!;
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

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsMetadataList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsMetadataList>()!;
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

        [JsiiProperty(name: "observedCatalogDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedCatalogDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedCatalogDetailsList ObservedCatalogDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedCatalogDetailsList>()!;
        }

        [JsiiProperty(name: "observedCompositeDataGuardShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedCompositeDataGuardShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedCompositeDataGuardShardSpacesList ObservedCompositeDataGuardShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedCompositeDataGuardShardSpacesList>()!;
        }

        [JsiiProperty(name: "observedCompositeRaftShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedCompositeRaftShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedCompositeRaftShardSpacesList ObservedCompositeRaftShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedCompositeRaftShardSpacesList>()!;
        }

        [JsiiProperty(name: "observedSystemDataGuardDatabases", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedSystemDataGuardDatabasesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedSystemDataGuardDatabasesList ObservedSystemDataGuardDatabases
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedSystemDataGuardDatabasesList>()!;
        }

        [JsiiProperty(name: "observedSystemRaftClusters", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedSystemRaftClustersList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedSystemRaftClustersList ObservedSystemRaftClusters
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedSystemRaftClustersList>()!;
        }

        [JsiiProperty(name: "observedUserShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedUserShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedUserShardSpacesList ObservedUserShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsObservedUserShardSpacesList>()!;
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

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsPatchOperationsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsPatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsPatchOperationsList>()!;
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

        [JsiiProperty(name: "systemDataGuardDatabases", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesList SystemDataGuardDatabases
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemDataGuardDatabasesList>()!;
        }

        [JsiiProperty(name: "systemRaftClusters", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemRaftClustersList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemRaftClustersList SystemRaftClusters
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsSystemRaftClustersList>()!;
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

        [JsiiProperty(name: "userShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsUserShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsUserShardSpacesList UserShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsUserShardSpacesList>()!;
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

        [JsiiProperty(name: "vcnNsgIds", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsVcnNsgIdsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsVcnNsgIdsList VcnNsgIds
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItemsVcnNsgIdsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedAutonomousDatabases.DataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.IDataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedAutonomousDatabases.IDataOciDistributedDatabaseDistributedAutonomousDatabasesDistributedAutonomousDatabaseCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
