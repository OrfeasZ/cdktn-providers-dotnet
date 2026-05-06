using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciRedisRedisClusters
{
    [JsiiClass(nativeType: typeof(oci.DataOciRedisRedisClusters.DataOciRedisRedisClustersRedisClusterCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciRedisRedisClusters.DataOciRedisRedisClustersRedisClusterCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciRedisRedisClustersRedisClusterCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciRedisRedisClustersRedisClusterCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciRedisRedisClustersRedisClusterCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciRedisRedisClustersRedisClusterCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clusterMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterMode
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

        [JsiiProperty(name: "discoveryEndpointIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiscoveryEndpointIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "discoveryFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiscoveryFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeCollection", typeJson: "{\"fqn\":\"oci.dataOciRedisRedisClusters.DataOciRedisRedisClustersRedisClusterCollectionItemsNodeCollectionList\"}")]
        public virtual oci.DataOciRedisRedisClusters.DataOciRedisRedisClustersRedisClusterCollectionItemsNodeCollectionList NodeCollection
        {
            get => GetInstanceProperty<oci.DataOciRedisRedisClusters.DataOciRedisRedisClustersRedisClusterCollectionItemsNodeCollectionList>()!;
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nodeMemoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeMemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ociCacheConfigSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciCacheConfigSetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryEndpointIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryEndpointIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicasEndpointIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicasEndpointIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicasFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicasFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "shardCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ShardCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "softwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciRedisRedisClusters.DataOciRedisRedisClustersRedisClusterCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciRedisRedisClusters.IDataOciRedisRedisClustersRedisClusterCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciRedisRedisClusters.IDataOciRedisRedisClustersRedisClusterCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
