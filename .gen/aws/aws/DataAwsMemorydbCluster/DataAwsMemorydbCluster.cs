using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsMemorydbCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/memorydb_cluster aws_memorydb_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsMemorydbCluster.DataAwsMemorydbCluster), fullyQualifiedName: "aws.dataAwsMemorydbCluster.DataAwsMemorydbCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsMemorydbCluster.DataAwsMemorydbClusterConfig\"}}]")]
    public class DataAwsMemorydbCluster : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/memorydb_cluster aws_memorydb_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsMemorydbCluster(Constructs.Construct scope, string id, aws.DataAwsMemorydbCluster.IDataAwsMemorydbClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsMemorydbCluster.IDataAwsMemorydbClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMemorydbCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMemorydbCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsMemorydbCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsMemorydbCluster to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsMemorydbCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsMemorydbCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsMemorydbCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/memorydb_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsMemorydbCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsMemorydbCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsMemorydbCluster.DataAwsMemorydbCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsMemorydbCluster.DataAwsMemorydbCluster))!;

        [JsiiProperty(name: "aclName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AclName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AutoMinorVersionUpgrade
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clusterEndpoint", typeJson: "{\"fqn\":\"aws.dataAwsMemorydbCluster.DataAwsMemorydbClusterClusterEndpointList\"}")]
        public virtual aws.DataAwsMemorydbCluster.DataAwsMemorydbClusterClusterEndpointList ClusterEndpoint
        {
            get => GetInstanceProperty<aws.DataAwsMemorydbCluster.DataAwsMemorydbClusterClusterEndpointList>()!;
        }

        [JsiiProperty(name: "dataTiering", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DataTiering
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Engine
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enginePatchVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnginePatchVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "finalSnapshotName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FinalSnapshotName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipDiscovery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpDiscovery
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceWindow
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numReplicasPerShard", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumReplicasPerShard
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numShards", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumShards
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "parameterGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParameterGroupName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "shards", typeJson: "{\"fqn\":\"aws.dataAwsMemorydbCluster.DataAwsMemorydbClusterShardsList\"}")]
        public virtual aws.DataAwsMemorydbCluster.DataAwsMemorydbClusterShardsList Shards
        {
            get => GetInstanceProperty<aws.DataAwsMemorydbCluster.DataAwsMemorydbClusterShardsList>()!;
        }

        [JsiiProperty(name: "snapshotRetentionLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SnapshotRetentionLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "snapshotWindow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotWindow
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnsTopicArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetGroupName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tlsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable TlsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
