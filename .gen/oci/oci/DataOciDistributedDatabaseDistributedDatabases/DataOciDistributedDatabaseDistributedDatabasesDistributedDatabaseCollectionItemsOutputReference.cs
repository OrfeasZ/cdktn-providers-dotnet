using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDistributedDatabaseDistributedDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addGdsControlNodeTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AddGdsControlNodeTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "autoResourceManagementConfig", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsAutoResourceManagementConfigList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsAutoResourceManagementConfigList AutoResourceManagementConfig
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsAutoResourceManagementConfigList>()!;
        }

        [JsiiProperty(name: "catalogDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsCatalogDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsCatalogDetailsList CatalogDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsCatalogDetailsList>()!;
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

        [JsiiProperty(name: "compositeDataGuardShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsCompositeDataGuardShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsCompositeDataGuardShardSpacesList CompositeDataGuardShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsCompositeDataGuardShardSpacesList>()!;
        }

        [JsiiProperty(name: "compositeRaftShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsCompositeRaftShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsCompositeRaftShardSpacesList CompositeRaftShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsCompositeRaftShardSpacesList>()!;
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

        [JsiiProperty(name: "connectionStrings", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsConnectionStringsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsConnectionStringsList ConnectionStrings
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsConnectionStringsList>()!;
        }

        [JsiiProperty(name: "databaseVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbBackupConfig", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsDbBackupConfigList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsDbBackupConfigList DbBackupConfig
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsDbBackupConfigList>()!;
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

        [JsiiProperty(name: "gdsControlNodeDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGdsControlNodeDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGdsControlNodeDetailsList GdsControlNodeDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGdsControlNodeDetailsList>()!;
        }

        [JsiiProperty(name: "generateWalletTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateWalletTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "gsmDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsList GsmDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsGsmDetailsList>()!;
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

        [JsiiProperty(name: "latestGsmImageDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsLatestGsmImageDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsLatestGsmImageDetailsList LatestGsmImageDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsLatestGsmImageDetailsList>()!;
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

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsMetadataList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsMetadataList>()!;
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

        [JsiiProperty(name: "observedCatalogDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedCatalogDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedCatalogDetailsList ObservedCatalogDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedCatalogDetailsList>()!;
        }

        [JsiiProperty(name: "observedCompositeDataGuardShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedCompositeDataGuardShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedCompositeDataGuardShardSpacesList ObservedCompositeDataGuardShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedCompositeDataGuardShardSpacesList>()!;
        }

        [JsiiProperty(name: "observedCompositeRaftShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedCompositeRaftShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedCompositeRaftShardSpacesList ObservedCompositeRaftShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedCompositeRaftShardSpacesList>()!;
        }

        [JsiiProperty(name: "observedSystemDataGuardDatabases", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedSystemDataGuardDatabasesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedSystemDataGuardDatabasesList ObservedSystemDataGuardDatabases
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedSystemDataGuardDatabasesList>()!;
        }

        [JsiiProperty(name: "observedSystemRaftClusters", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedSystemRaftClustersList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedSystemRaftClustersList ObservedSystemRaftClusters
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedSystemRaftClustersList>()!;
        }

        [JsiiProperty(name: "observedUserShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedUserShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedUserShardSpacesList ObservedUserShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsObservedUserShardSpacesList>()!;
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

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsPatchOperationsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsPatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsPatchOperationsList>()!;
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

        [JsiiProperty(name: "systemDataGuardDatabases", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsSystemDataGuardDatabasesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsSystemDataGuardDatabasesList SystemDataGuardDatabases
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsSystemDataGuardDatabasesList>()!;
        }

        [JsiiProperty(name: "systemRaftClusters", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsSystemRaftClustersList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsSystemRaftClustersList SystemRaftClusters
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsSystemRaftClustersList>()!;
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

        [JsiiProperty(name: "userShardSpaces", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsUserShardSpacesList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsUserShardSpacesList UserShardSpaces
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsUserShardSpacesList>()!;
        }

        [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidateNetworkTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "vcnNsgIds", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsVcnNsgIdsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsVcnNsgIdsList VcnNsgIds
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsVcnNsgIdsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.IDataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.IDataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
