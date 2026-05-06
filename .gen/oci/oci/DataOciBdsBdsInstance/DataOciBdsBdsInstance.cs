using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBdsBdsInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/bds_bds_instance oci_bds_bds_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciBdsBdsInstance.DataOciBdsBdsInstance), fullyQualifiedName: "oci.dataOciBdsBdsInstance.DataOciBdsBdsInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceConfig\"}}]")]
    public class DataOciBdsBdsInstance : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/bds_bds_instance oci_bds_bds_instance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciBdsBdsInstance(Constructs.Construct scope, string id, oci.DataOciBdsBdsInstance.IDataOciBdsBdsInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciBdsBdsInstance.IDataOciBdsBdsInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsBdsInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciBdsBdsInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciBdsBdsInstance to import.</param>
        /// <param name="importFromId">The id of the existing DataOciBdsBdsInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciBdsBdsInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciBdsBdsInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/bds_bds_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciBdsBdsInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciBdsBdsInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciBdsBdsInstance.DataOciBdsBdsInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciBdsBdsInstance.DataOciBdsBdsInstance))!;

        [JsiiProperty(name: "bdsClusterVersionSummary", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceBdsClusterVersionSummaryList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceBdsClusterVersionSummaryList BdsClusterVersionSummary
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceBdsClusterVersionSummaryList>()!;
        }

        [JsiiProperty(name: "bootstrapScriptUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapScriptUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudSqlDetails", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceCloudSqlDetailsList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceCloudSqlDetailsList CloudSqlDetails
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceCloudSqlDetailsList>()!;
        }

        [JsiiProperty(name: "clusterAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterAdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterDetails", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceClusterDetailsList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceClusterDetailsList ClusterDetails
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceClusterDetailsList>()!;
        }

        [JsiiProperty(name: "clusterProfile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterProfile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeOnlyWorkerNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceComputeOnlyWorkerNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceComputeOnlyWorkerNodeList ComputeOnlyWorkerNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceComputeOnlyWorkerNodeList>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
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

        [JsiiProperty(name: "edgeNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceEdgeNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceEdgeNodeList EdgeNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceEdgeNodeList>()!;
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

        [JsiiProperty(name: "ignoreExistingNodesShape", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IgnoreExistingNodesShape
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "isCloudSqlConfigured", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCloudSqlConfigured
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isForceRemoveEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsForceRemoveEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isForceStopJobs", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsForceStopJobs
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHighAvailability", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHighAvailability
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isKafkaConfigured", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsKafkaConfigured
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSecure", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSecure
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kafkaBrokerNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceKafkaBrokerNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceKafkaBrokerNodeList KafkaBrokerNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceKafkaBrokerNodeList>()!;
        }

        [JsiiProperty(name: "kerberosRealmName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KerberosRealmName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceMasterNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceMasterNodeList MasterNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceMasterNodeList>()!;
        }

        [JsiiProperty(name: "networkConfig", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceNetworkConfigList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceNetworkConfigList NetworkConfig
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceNetworkConfigList>()!;
        }

        [JsiiProperty(name: "nodes", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceNodesList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceNodesList Nodes
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceNodesList>()!;
        }

        [JsiiProperty(name: "numberOfNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfNodes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numberOfNodesRequiringMaintenanceReboot", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfNodesRequiringMaintenanceReboot
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "osPatchVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsPatchVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "removeNode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoveNode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startClusterShapeConfigs", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceStartClusterShapeConfigsList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceStartClusterShapeConfigsList StartClusterShapeConfigs
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceStartClusterShapeConfigsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "utilNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceUtilNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceUtilNodeList UtilNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceUtilNodeList>()!;
        }

        [JsiiProperty(name: "workerNode", typeJson: "{\"fqn\":\"oci.dataOciBdsBdsInstance.DataOciBdsBdsInstanceWorkerNodeList\"}")]
        public virtual oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceWorkerNodeList WorkerNode
        {
            get => GetInstanceProperty<oci.DataOciBdsBdsInstance.DataOciBdsBdsInstanceWorkerNodeList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bdsInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BdsInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bdsInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BdsInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
