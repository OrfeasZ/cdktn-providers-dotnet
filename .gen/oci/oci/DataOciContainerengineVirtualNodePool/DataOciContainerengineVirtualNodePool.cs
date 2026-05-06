using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerengineVirtualNodePool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/containerengine_virtual_node_pool oci_containerengine_virtual_node_pool}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePool), fullyQualifiedName: "oci.dataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolConfig\"}}]")]
    public class DataOciContainerengineVirtualNodePool : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/containerengine_virtual_node_pool oci_containerengine_virtual_node_pool} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciContainerengineVirtualNodePool(Constructs.Construct scope, string id, oci.DataOciContainerengineVirtualNodePool.IDataOciContainerengineVirtualNodePoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciContainerengineVirtualNodePool.IDataOciContainerengineVirtualNodePoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerengineVirtualNodePool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerengineVirtualNodePool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciContainerengineVirtualNodePool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciContainerengineVirtualNodePool to import.</param>
        /// <param name="importFromId">The id of the existing DataOciContainerengineVirtualNodePool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciContainerengineVirtualNodePool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciContainerengineVirtualNodePool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/containerengine_virtual_node_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciContainerengineVirtualNodePool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciContainerengineVirtualNodePool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePool))!;

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

        [JsiiProperty(name: "initialVirtualNodeLabels", typeJson: "{\"fqn\":\"oci.dataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolInitialVirtualNodeLabelsList\"}")]
        public virtual oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolInitialVirtualNodeLabelsList InitialVirtualNodeLabels
        {
            get => GetInstanceProperty<oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolInitialVirtualNodeLabelsList>()!;
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

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "placementConfigurations", typeJson: "{\"fqn\":\"oci.dataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolPlacementConfigurationsList\"}")]
        public virtual oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolPlacementConfigurationsList PlacementConfigurations
        {
            get => GetInstanceProperty<oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolPlacementConfigurationsList>()!;
        }

        [JsiiProperty(name: "podConfiguration", typeJson: "{\"fqn\":\"oci.dataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolPodConfigurationList\"}")]
        public virtual oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolPodConfigurationList PodConfiguration
        {
            get => GetInstanceProperty<oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolPodConfigurationList>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "taints", typeJson: "{\"fqn\":\"oci.dataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolTaintsList\"}")]
        public virtual oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolTaintsList Taints
        {
            get => GetInstanceProperty<oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolTaintsList>()!;
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

        [JsiiProperty(name: "virtualNodeTags", typeJson: "{\"fqn\":\"oci.dataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolVirtualNodeTagsList\"}")]
        public virtual oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolVirtualNodeTagsList VirtualNodeTags
        {
            get => GetInstanceProperty<oci.DataOciContainerengineVirtualNodePool.DataOciContainerengineVirtualNodePoolVirtualNodeTagsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualNodePoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualNodePoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "virtualNodePoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNodePoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
