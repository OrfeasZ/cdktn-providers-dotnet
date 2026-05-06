using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseCloudVmClusters
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersOutputReference), fullyQualifiedName: "oci.dataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseCloudVmClustersCloudVmClustersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseCloudVmClustersCloudVmClustersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseCloudVmClustersCloudVmClustersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseCloudVmClustersCloudVmClustersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupNetworkNsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BackupNetworkNsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "backupSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupSubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudAutomationUpdateDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersCloudAutomationUpdateDetailsList\"}")]
        public virtual oci.DataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersCloudAutomationUpdateDetailsList CloudAutomationUpdateDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersCloudAutomationUpdateDetailsList>()!;
        }

        [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createAsync", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CreateAsync
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "dataCollectionOptions", typeJson: "{\"fqn\":\"oci.dataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersDataCollectionOptionsList\"}")]
        public virtual oci.DataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersDataCollectionOptionsList DataCollectionOptions
        {
            get => GetInstanceProperty<oci.DataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersDataCollectionOptionsList>()!;
        }

        [JsiiProperty(name: "dataStoragePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStoragePercentage
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

        [JsiiProperty(name: "diskRedundancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskRedundancy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exascaleDbStorageVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExascaleDbStorageVaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSystemConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersFileSystemConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersFileSystemConfigurationDetailsList FileSystemConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersFileSystemConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "giVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GiVersion
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

        [JsiiProperty(name: "iormConfigCache", typeJson: "{\"fqn\":\"oci.dataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersIormConfigCacheList\"}")]
        public virtual oci.DataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersIormConfigCacheList IormConfigCache
        {
            get => GetInstanceProperty<oci.DataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersIormConfigCacheList>()!;
        }

        [JsiiProperty(name: "isLocalBackupEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLocalBackupEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSparseDiskgroupEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSparseDiskgroupEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastUpdateHistoryEntryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdateHistoryEntryId
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

        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListenerPort
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "multiCloudIdentityConnectorConfigs", typeJson: "{\"fqn\":\"oci.dataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersMultiCloudIdentityConnectorConfigsList\"}")]
        public virtual oci.DataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersMultiCloudIdentityConnectorConfigsList MultiCloudIdentityConnectorConfigs
        {
            get => GetInstanceProperty<oci.DataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClustersMultiCloudIdentityConnectorConfigsList>()!;
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ocpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "privateZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateZoneId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "scanListenerPortTcp", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPortTcp
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scanListenerPortTcpSsl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPortTcpSsl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sshPublicKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SshPublicKeys
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "systemVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tdeKeyStoreType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TdeKeyStoreType
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "vmClusterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseCloudVmClusters.DataOciDatabaseCloudVmClustersCloudVmClusters\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseCloudVmClusters.IDataOciDatabaseCloudVmClustersCloudVmClusters? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseCloudVmClusters.IDataOciDatabaseCloudVmClustersCloudVmClusters?>();
            set => SetInstanceProperty(value);
        }
    }
}
