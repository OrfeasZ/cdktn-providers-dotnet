using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayK8SPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/k8s_pool scaleway_k8s_pool}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayK8SPool.DataScalewayK8SPool), fullyQualifiedName: "scaleway.dataScalewayK8SPool.DataScalewayK8SPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.dataScalewayK8SPool.DataScalewayK8SPoolConfig\"}}]")]
    public class DataScalewayK8SPool : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/k8s_pool scaleway_k8s_pool} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayK8SPool(Constructs.Construct scope, string id, scaleway.DataScalewayK8SPool.IDataScalewayK8SPoolConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayK8SPool.IDataScalewayK8SPoolConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayK8SPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayK8SPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayK8SPool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayK8SPool to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayK8SPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayK8SPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayK8SPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/k8s_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayK8SPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayK8SPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayK8SPool.DataScalewayK8SPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetClusterId")]
        public virtual void ResetClusterId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPoolId")]
        public virtual void ResetPoolId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSize")]
        public virtual void ResetSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayK8SPool.DataScalewayK8SPool))!;

        [JsiiProperty(name: "autohealing", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Autohealing
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Autoscaling
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "containerRuntime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerRuntime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CurrentSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "kubeletArgs", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap KubeletArgs
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nodes", typeJson: "{\"fqn\":\"scaleway.dataScalewayK8SPool.DataScalewayK8SPoolNodesList\"}")]
        public virtual scaleway.DataScalewayK8SPool.DataScalewayK8SPoolNodesList Nodes
        {
            get => GetInstanceProperty<scaleway.DataScalewayK8SPool.DataScalewayK8SPoolNodesList>()!;
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIpDisabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PublicIpDisabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "rootVolumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RootVolumeSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rootVolumeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootVolumeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upgradePolicy", typeJson: "{\"fqn\":\"scaleway.dataScalewayK8SPool.DataScalewayK8SPoolUpgradePolicyList\"}")]
        public virtual scaleway.DataScalewayK8SPool.DataScalewayK8SPoolUpgradePolicyList UpgradePolicy
        {
            get => GetInstanceProperty<scaleway.DataScalewayK8SPool.DataScalewayK8SPoolUpgradePolicyList>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "waitForPoolReady", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable WaitForPoolReady
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "poolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
