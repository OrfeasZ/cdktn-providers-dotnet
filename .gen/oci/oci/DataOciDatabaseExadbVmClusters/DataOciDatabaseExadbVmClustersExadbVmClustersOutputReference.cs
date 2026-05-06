using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseExadbVmClusters
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersOutputReference), fullyQualifiedName: "oci.dataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseExadbVmClustersExadbVmClustersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseExadbVmClustersExadbVmClustersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseExadbVmClustersExadbVmClustersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseExadbVmClustersExadbVmClustersOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataCollectionOptions", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersDataCollectionOptionsList\"}")]
        public virtual oci.DataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersDataCollectionOptionsList DataCollectionOptions
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersDataCollectionOptionsList>()!;
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

        [JsiiProperty(name: "gridImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GridImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gridImageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GridImageType
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

        [JsiiProperty(name: "iormConfigCache", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersIormConfigCacheList\"}")]
        public virtual oci.DataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersIormConfigCacheList IormConfigCache
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersIormConfigCacheList>()!;
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

        [JsiiProperty(name: "nodeConfig", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersNodeConfigList\"}")]
        public virtual oci.DataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersNodeConfigList NodeConfig
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersNodeConfigList>()!;
        }

        [JsiiProperty(name: "nodeResource", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersNodeResourceList\"}")]
        public virtual oci.DataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersNodeResourceList NodeResource
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClustersNodeResourceList>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "shapeAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeAttribute
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

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseExadbVmClusters.DataOciDatabaseExadbVmClustersExadbVmClusters\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseExadbVmClusters.IDataOciDatabaseExadbVmClustersExadbVmClusters? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseExadbVmClusters.IDataOciDatabaseExadbVmClustersExadbVmClusters?>();
            set => SetInstanceProperty(value);
        }
    }
}
