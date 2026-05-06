using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciManagedKafkaKafkaClusters
{
    [JsiiClass(nativeType: typeof(oci.DataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessSubnets", typeJson: "{\"fqn\":\"oci.dataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsAccessSubnetsList\"}")]
        public virtual oci.DataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsAccessSubnetsList AccessSubnets
        {
            get => GetInstanceProperty<oci.DataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsAccessSubnetsList>()!;
        }

        [JsiiProperty(name: "brokerShape", typeJson: "{\"fqn\":\"oci.dataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsBrokerShapeList\"}")]
        public virtual oci.DataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsBrokerShapeList BrokerShape
        {
            get => GetInstanceProperty<oci.DataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsBrokerShapeList>()!;
        }

        [JsiiProperty(name: "clientCertificateBundle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCertificateBundle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterConfigId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterConfigVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClusterConfigVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "clusterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "coordinationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CoordinationType
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

        [JsiiProperty(name: "kafkaBootstrapUrls", typeJson: "{\"fqn\":\"oci.dataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsKafkaBootstrapUrlsList\"}")]
        public virtual oci.DataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsKafkaBootstrapUrlsList KafkaBootstrapUrls
        {
            get => GetInstanceProperty<oci.DataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItemsKafkaBootstrapUrlsList>()!;
        }

        [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KafkaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciManagedKafkaKafkaClusters.DataOciManagedKafkaKafkaClustersKafkaClusterCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciManagedKafkaKafkaClusters.IDataOciManagedKafkaKafkaClustersKafkaClusterCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciManagedKafkaKafkaClusters.IDataOciManagedKafkaKafkaClustersKafkaClusterCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
