using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKubernetesAutomaticCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/kubernetes_automatic_cluster azurerm_kubernetes_automatic_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticCluster), fullyQualifiedName: "azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterConfig\"}}]")]
    public class DataAzurermKubernetesAutomaticCluster : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/kubernetes_automatic_cluster azurerm_kubernetes_automatic_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermKubernetesAutomaticCluster(Constructs.Construct scope, string id, azurerm.DataAzurermKubernetesAutomaticCluster.IDataAzurermKubernetesAutomaticClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermKubernetesAutomaticCluster.IDataAzurermKubernetesAutomaticClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermKubernetesAutomaticCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermKubernetesAutomaticCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzurermKubernetesAutomaticCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermKubernetesAutomaticCluster to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermKubernetesAutomaticCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermKubernetesAutomaticCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermKubernetesAutomaticCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/kubernetes_automatic_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermKubernetesAutomaticCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermKubernetesAutomaticCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermKubernetesAutomaticCluster.IDataAzurermKubernetesAutomaticClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermKubernetesAutomaticCluster.IDataAzurermKubernetesAutomaticClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticCluster))!;

        [JsiiProperty(name: "apiServerAccess", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterApiServerAccessList\"}")]
        public virtual azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterApiServerAccessList ApiServerAccess
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterApiServerAccessList>()!;
        }

        [JsiiProperty(name: "currentKubernetesVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentKubernetesVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fullyQualifiedDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FullyQualifiedDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostedSystem", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterHostedSystemList\"}")]
        public virtual azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterHostedSystemList HostedSystem
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterHostedSystemList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterIdentityList\"}")]
        public virtual azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterIdentityList>()!;
        }

        [JsiiProperty(name: "kubeConfig", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterKubeConfigList\"}")]
        public virtual azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterKubeConfigList KubeConfig
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterKubeConfigList>()!;
        }

        [JsiiProperty(name: "kubeConfigRaw", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubeConfigRaw
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kubeletIdentity", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterKubeletIdentityList\"}")]
        public virtual azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterKubeletIdentityList KubeletIdentity
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterKubeletIdentityList>()!;
        }

        [JsiiProperty(name: "kubernetesVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubernetesVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeResourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeResourceGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portalFullyQualifiedDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortalFullyQualifiedDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateCluster", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterPrivateClusterList\"}")]
        public virtual azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterPrivateClusterList PrivateCluster
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterPrivateClusterList>()!;
        }

        [JsiiProperty(name: "privateFullyQualifiedDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateFullyQualifiedDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceMesh", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterServiceMeshList\"}")]
        public virtual azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterServiceMeshList ServiceMesh
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterServiceMeshList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "webAppRoutingIngress", typeJson: "{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterWebAppRoutingIngressList\"}")]
        public virtual azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterWebAppRoutingIngressList WebAppRoutingIngress
        {
            get => GetInstanceProperty<azurerm.DataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterWebAppRoutingIngressList>()!;
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
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.DataAzurermKubernetesAutomaticCluster.IDataAzurermKubernetesAutomaticClusterTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermKubernetesAutomaticCluster.DataAzurermKubernetesAutomaticClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
