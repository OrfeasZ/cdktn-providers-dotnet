using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciManagedKafkaKafkaCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/managed_kafka_kafka_cluster oci_managed_kafka_kafka_cluster}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaCluster), fullyQualifiedName: "oci.dataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaClusterConfig\"}}]")]
    public class DataOciManagedKafkaKafkaCluster : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/managed_kafka_kafka_cluster oci_managed_kafka_kafka_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciManagedKafkaKafkaCluster(Constructs.Construct scope, string id, oci.DataOciManagedKafkaKafkaCluster.IDataOciManagedKafkaKafkaClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciManagedKafkaKafkaCluster.IDataOciManagedKafkaKafkaClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagedKafkaKafkaCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagedKafkaKafkaCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciManagedKafkaKafkaCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciManagedKafkaKafkaCluster to import.</param>
        /// <param name="importFromId">The id of the existing DataOciManagedKafkaKafkaCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciManagedKafkaKafkaCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciManagedKafkaKafkaCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/managed_kafka_kafka_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciManagedKafkaKafkaCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciManagedKafkaKafkaCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaCluster))!;

        [JsiiProperty(name: "accessSubnets", typeJson: "{\"fqn\":\"oci.dataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaClusterAccessSubnetsList\"}")]
        public virtual oci.DataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaClusterAccessSubnetsList AccessSubnets
        {
            get => GetInstanceProperty<oci.DataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaClusterAccessSubnetsList>()!;
        }

        [JsiiProperty(name: "brokerShape", typeJson: "{\"fqn\":\"oci.dataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaClusterBrokerShapeList\"}")]
        public virtual oci.DataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaClusterBrokerShapeList BrokerShape
        {
            get => GetInstanceProperty<oci.DataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaClusterBrokerShapeList>()!;
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

        [JsiiProperty(name: "kafkaBootstrapUrls", typeJson: "{\"fqn\":\"oci.dataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaClusterKafkaBootstrapUrlsList\"}")]
        public virtual oci.DataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaClusterKafkaBootstrapUrlsList KafkaBootstrapUrls
        {
            get => GetInstanceProperty<oci.DataOciManagedKafkaKafkaCluster.DataOciManagedKafkaKafkaClusterKafkaBootstrapUrlsList>()!;
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
        [JsiiProperty(name: "kafkaClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KafkaClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "kafkaClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KafkaClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
