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

        [JsiiProperty(name: "chunks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Chunks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configureShardingIsRebalanceRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ConfigureShardingIsRebalanceRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "downloadGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DownloadGsmCertificateSigningRequestTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "effectiveReplicationUnit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EffectiveReplicationUnit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "generateGsmCertificateSigningRequestTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateGsmCertificateSigningRequestTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "generateWalletDownloadedWalletContentLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateWalletDownloadedWalletContentLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "generateWalletDownloadedWalletEtag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerateWalletDownloadedWalletEtag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "generateWalletDownloadedWalletLastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerateWalletDownloadedWalletLastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "generateWalletDownloadedWalletZipBase64", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerateWalletDownloadedWalletZipBase64
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "generateWalletPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenerateWalletPassword
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsPatchOperationsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsPatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsPatchOperationsList>()!;
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

        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicationFactor
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "replicationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationUnit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicationUnit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scanListenerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shardDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsShardDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsShardDetailsList ShardDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsShardDetailsList>()!;
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

        [JsiiProperty(name: "uploadSignedCertificateAndGenerateWalletTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UploadSignedCertificateAndGenerateWalletTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "validateNetworkDetails", typeJson: "{\"fqn\":\"oci.dataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsValidateNetworkDetailsList\"}")]
        public virtual oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsValidateNetworkDetailsList ValidateNetworkDetails
        {
            get => GetInstanceProperty<oci.DataOciDistributedDatabaseDistributedDatabases.DataOciDistributedDatabaseDistributedDatabasesDistributedDatabaseCollectionItemsValidateNetworkDetailsList>()!;
        }

        [JsiiProperty(name: "validateNetworkTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidateNetworkTrigger
        {
            get => GetInstanceProperty<double>()!;
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
