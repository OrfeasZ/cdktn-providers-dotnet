using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudBridgeAssetSources
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudBridgeAssetSources.DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciCloudBridgeAssetSources.DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "areHistoricalMetricsCollected", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreHistoricalMetricsCollected
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "areRealtimeMetricsCollected", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreRealtimeMetricsCollected
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "assetsCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssetsCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "discoveryCredentials", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssetSources.DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsDiscoveryCredentialsList\"}")]
        public virtual oci.DataOciCloudBridgeAssetSources.DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsDiscoveryCredentialsList DiscoveryCredentials
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssetSources.DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsDiscoveryCredentialsList>()!;
        }

        [JsiiProperty(name: "discoveryScheduleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiscoveryScheduleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "environmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inventoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InventoryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationCredentials", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssetSources.DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsReplicationCredentialsList\"}")]
        public virtual oci.DataOciCloudBridgeAssetSources.DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsReplicationCredentialsList ReplicationCredentials
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssetSources.DataOciCloudBridgeAssetSourcesAssetSourceCollectionItemsReplicationCredentialsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcenterEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcenterEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAssetSources.DataOciCloudBridgeAssetSourcesAssetSourceCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciCloudBridgeAssetSources.IDataOciCloudBridgeAssetSourcesAssetSourceCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAssetSources.IDataOciCloudBridgeAssetSourcesAssetSourceCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
