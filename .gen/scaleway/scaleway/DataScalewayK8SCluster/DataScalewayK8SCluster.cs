using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayK8SCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/k8s_cluster scaleway_k8s_cluster}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayK8SCluster.DataScalewayK8SCluster), fullyQualifiedName: "scaleway.dataScalewayK8SCluster.DataScalewayK8SCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"scaleway.dataScalewayK8SCluster.DataScalewayK8SClusterConfig\"}}]")]
    public class DataScalewayK8SCluster : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/k8s_cluster scaleway_k8s_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataScalewayK8SCluster(Constructs.Construct scope, string id, scaleway.DataScalewayK8SCluster.IDataScalewayK8SClusterConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.DataScalewayK8SCluster.IDataScalewayK8SClusterConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayK8SCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayK8SCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataScalewayK8SCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataScalewayK8SCluster to import.</param>
        /// <param name="importFromId">The id of the existing DataScalewayK8SCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataScalewayK8SCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataScalewayK8SCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/k8s_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataScalewayK8SCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataScalewayK8SCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.DataScalewayK8SCluster.DataScalewayK8SCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(scaleway.DataScalewayK8SCluster.DataScalewayK8SCluster))!;

        [JsiiProperty(name: "admissionPlugins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdmissionPlugins
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "apiserverCertSans", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ApiserverCertSans
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "apiserverUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiserverUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoscalerConfig", typeJson: "{\"fqn\":\"scaleway.dataScalewayK8SCluster.DataScalewayK8SClusterAutoscalerConfigList\"}")]
        public virtual scaleway.DataScalewayK8SCluster.DataScalewayK8SClusterAutoscalerConfigList AutoscalerConfig
        {
            get => GetInstanceProperty<scaleway.DataScalewayK8SCluster.DataScalewayK8SClusterAutoscalerConfigList>()!;
        }

        [JsiiProperty(name: "autoUpgrade", typeJson: "{\"fqn\":\"scaleway.dataScalewayK8SCluster.DataScalewayK8SClusterAutoUpgradeList\"}")]
        public virtual scaleway.DataScalewayK8SCluster.DataScalewayK8SClusterAutoUpgradeList AutoUpgrade
        {
            get => GetInstanceProperty<scaleway.DataScalewayK8SCluster.DataScalewayK8SClusterAutoUpgradeList>()!;
        }

        [JsiiProperty(name: "cni", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cni
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "featureGates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] FeatureGates
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "kubeconfig", typeJson: "{\"fqn\":\"scaleway.dataScalewayK8SCluster.DataScalewayK8SClusterKubeconfigList\"}")]
        public virtual scaleway.DataScalewayK8SCluster.DataScalewayK8SClusterKubeconfigList Kubeconfig
        {
            get => GetInstanceProperty<scaleway.DataScalewayK8SCluster.DataScalewayK8SClusterKubeconfigList>()!;
        }

        [JsiiProperty(name: "openIdConnectConfig", typeJson: "{\"fqn\":\"scaleway.dataScalewayK8SCluster.DataScalewayK8SClusterOpenIdConnectConfigList\"}")]
        public virtual scaleway.DataScalewayK8SCluster.DataScalewayK8SClusterOpenIdConnectConfigList OpenIdConnectConfig
        {
            get => GetInstanceProperty<scaleway.DataScalewayK8SCluster.DataScalewayK8SClusterOpenIdConnectConfigList>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "podCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PodCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateNetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceDnsIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceDnsIp
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upgradeAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UpgradeAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "wildcardDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WildcardDns
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
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
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
    }
}
