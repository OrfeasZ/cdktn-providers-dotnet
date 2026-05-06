using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBlockchainBlockchainPlatform
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/blockchain_blockchain_platform oci_blockchain_blockchain_platform}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatform), fullyQualifiedName: "oci.dataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatform", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatformConfig\"}}]")]
    public class DataOciBlockchainBlockchainPlatform : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/blockchain_blockchain_platform oci_blockchain_blockchain_platform} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciBlockchainBlockchainPlatform(Constructs.Construct scope, string id, oci.DataOciBlockchainBlockchainPlatform.IDataOciBlockchainBlockchainPlatformConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciBlockchainBlockchainPlatform.IDataOciBlockchainBlockchainPlatformConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBlockchainBlockchainPlatform(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBlockchainBlockchainPlatform(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciBlockchainBlockchainPlatform resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciBlockchainBlockchainPlatform to import.</param>
        /// <param name="importFromId">The id of the existing DataOciBlockchainBlockchainPlatform that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciBlockchainBlockchainPlatform to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciBlockchainBlockchainPlatform to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/blockchain_blockchain_platform#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciBlockchainBlockchainPlatform that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciBlockchainBlockchainPlatform to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatform), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatform))!;

        [JsiiProperty(name: "caCertArchiveText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaCertArchiveText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "componentDetails", typeJson: "{\"fqn\":\"oci.dataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatformComponentDetailsList\"}")]
        public virtual oci.DataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatformComponentDetailsList ComponentDetails
        {
            get => GetInstanceProperty<oci.DataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatformComponentDetailsList>()!;
        }

        [JsiiProperty(name: "computeShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "federatedUserId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FederatedUserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hostOcpuUtilizationInfo", typeJson: "{\"fqn\":\"oci.dataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatformHostOcpuUtilizationInfoList\"}")]
        public virtual oci.DataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatformHostOcpuUtilizationInfoList HostOcpuUtilizationInfo
        {
            get => GetInstanceProperty<oci.DataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatformHostOcpuUtilizationInfoList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsAccessToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsAccessToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isByol", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsByol
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMultiAd", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMultiAd
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancerShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformShapeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformShapeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicas", typeJson: "{\"fqn\":\"oci.dataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatformReplicasList\"}")]
        public virtual oci.DataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatformReplicasList Replicas
        {
            get => GetInstanceProperty<oci.DataOciBlockchainBlockchainPlatform.DataOciBlockchainBlockchainPlatformReplicasList>()!;
        }

        [JsiiProperty(name: "serviceEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "storageUsedInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageUsedInTbs
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "totalOcpuCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalOcpuCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockchainPlatformIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockchainPlatformIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "blockchainPlatformId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockchainPlatformId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
