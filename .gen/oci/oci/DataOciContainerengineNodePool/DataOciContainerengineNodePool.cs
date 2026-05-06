using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerengineNodePool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/containerengine_node_pool oci_containerengine_node_pool}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciContainerengineNodePool.DataOciContainerengineNodePool), fullyQualifiedName: "oci.dataOciContainerengineNodePool.DataOciContainerengineNodePool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciContainerengineNodePool.DataOciContainerengineNodePoolConfig\"}}]")]
    public class DataOciContainerengineNodePool : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/containerengine_node_pool oci_containerengine_node_pool} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciContainerengineNodePool(Constructs.Construct scope, string id, oci.DataOciContainerengineNodePool.IDataOciContainerengineNodePoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciContainerengineNodePool.IDataOciContainerengineNodePoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerengineNodePool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerengineNodePool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciContainerengineNodePool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciContainerengineNodePool to import.</param>
        /// <param name="importFromId">The id of the existing DataOciContainerengineNodePool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciContainerengineNodePool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciContainerengineNodePool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/containerengine_node_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciContainerengineNodePool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciContainerengineNodePool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciContainerengineNodePool.DataOciContainerengineNodePool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciContainerengineNodePool.DataOciContainerengineNodePool))!;

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
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

        [JsiiProperty(name: "initialNodeLabels", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePool.DataOciContainerengineNodePoolInitialNodeLabelsList\"}")]
        public virtual oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolInitialNodeLabelsList InitialNodeLabels
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolInitialNodeLabelsList>()!;
        }

        [JsiiProperty(name: "kubernetesVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubernetesVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeConfigDetails", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeConfigDetailsList\"}")]
        public virtual oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeConfigDetailsList NodeConfigDetails
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeConfigDetailsList>()!;
        }

        [JsiiProperty(name: "nodeEvictionNodePoolSettings", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeEvictionNodePoolSettingsList\"}")]
        public virtual oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeEvictionNodePoolSettingsList NodeEvictionNodePoolSettings
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeEvictionNodePoolSettingsList>()!;
        }

        [JsiiProperty(name: "nodeImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeImageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeImageName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeMetadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap NodeMetadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "nodePoolCyclingDetails", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePool.DataOciContainerengineNodePoolNodePoolCyclingDetailsList\"}")]
        public virtual oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodePoolCyclingDetailsList NodePoolCyclingDetails
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodePoolCyclingDetailsList>()!;
        }

        [JsiiProperty(name: "nodes", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePool.DataOciContainerengineNodePoolNodesList\"}")]
        public virtual oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodesList Nodes
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodesList>()!;
        }

        [JsiiProperty(name: "nodeShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeShapeConfig", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeShapeConfigList\"}")]
        public virtual oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeShapeConfigList NodeShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeShapeConfigList>()!;
        }

        [JsiiProperty(name: "nodeSource", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeSourceList\"}")]
        public virtual oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeSourceList NodeSource
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeSourceList>()!;
        }

        [JsiiProperty(name: "nodeSourceDetails", typeJson: "{\"fqn\":\"oci.dataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeSourceDetailsList\"}")]
        public virtual oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeSourceDetailsList NodeSourceDetails
        {
            get => GetInstanceProperty<oci.DataOciContainerengineNodePool.DataOciContainerengineNodePoolNodeSourceDetailsList>()!;
        }

        [JsiiProperty(name: "quantityPerSubnet", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QuantityPerSubnet
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sshPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshPublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodePoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodePoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "nodePoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodePoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
