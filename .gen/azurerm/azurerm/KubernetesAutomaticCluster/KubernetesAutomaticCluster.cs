using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesAutomaticCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster azurerm_kubernetes_automatic_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.KubernetesAutomaticCluster.KubernetesAutomaticCluster), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterConfig\"}}]")]
    public class KubernetesAutomaticCluster : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster azurerm_kubernetes_automatic_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KubernetesAutomaticCluster(Constructs.Construct scope, string id, azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesAutomaticCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesAutomaticCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a KubernetesAutomaticCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KubernetesAutomaticCluster to import.</param>
        /// <param name="importFromId">The id of the existing KubernetesAutomaticCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KubernetesAutomaticCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KubernetesAutomaticCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KubernetesAutomaticCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KubernetesAutomaticCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.KubernetesAutomaticCluster.KubernetesAutomaticCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApiServerAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterApiServerAccess\"}}]")]
        public virtual void PutApiServerAccess(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterApiServerAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterApiServerAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHostedSystem", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterHostedSystem\"}}]")]
        public virtual void PutHostedSystem(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterHostedSystem @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterHostedSystem)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterPrivateCluster\"}}]")]
        public virtual void PutPrivateCluster(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterPrivateCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterPrivateCluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceMesh", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMesh\"}}]")]
        public virtual void PutServiceMesh(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMesh @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMesh)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebAppRoutingIngress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterWebAppRoutingIngress\"}}]")]
        public virtual void PutWebAppRoutingIngress(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterWebAppRoutingIngress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterWebAppRoutingIngress)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiServerAccess")]
        public virtual void ResetApiServerAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostedSystem")]
        public virtual void ResetHostedSystem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateCluster")]
        public virtual void ResetPrivateCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceMesh")]
        public virtual void ResetServiceMesh()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebAppRoutingIngress")]
        public virtual void ResetWebAppRoutingIngress()
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
        = GetStaticProperty<string>(typeof(azurerm.KubernetesAutomaticCluster.KubernetesAutomaticCluster))!;

        [JsiiProperty(name: "apiServerAccess", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterApiServerAccessOutputReference\"}")]
        public virtual azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterApiServerAccessOutputReference ApiServerAccess
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterApiServerAccessOutputReference>()!;
        }

        [JsiiProperty(name: "currentKubernetesVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentKubernetesVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fullyQualifiedDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FullyQualifiedDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostedSystem", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterHostedSystemOutputReference\"}")]
        public virtual azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterHostedSystemOutputReference HostedSystem
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterHostedSystemOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterIdentityOutputReference\"}")]
        public virtual azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "kubeConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterKubeConfigList\"}")]
        public virtual azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterKubeConfigList KubeConfig
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterKubeConfigList>()!;
        }

        [JsiiProperty(name: "kubeConfigRaw", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubeConfigRaw
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeResourceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeResourceGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oidcIssuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OidcIssuerUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portalFullyQualifiedDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortalFullyQualifiedDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateCluster", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterPrivateClusterOutputReference\"}")]
        public virtual azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterPrivateClusterOutputReference PrivateCluster
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterPrivateClusterOutputReference>()!;
        }

        [JsiiProperty(name: "privateFullyQualifiedDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateFullyQualifiedDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceMesh", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMeshOutputReference\"}")]
        public virtual azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMeshOutputReference ServiceMesh
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMeshOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "webAppRoutingIngress", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterWebAppRoutingIngressOutputReference\"}")]
        public virtual azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterWebAppRoutingIngressOutputReference WebAppRoutingIngress
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.KubernetesAutomaticClusterWebAppRoutingIngressOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiServerAccessInput", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterApiServerAccess\"}", isOptional: true)]
        public virtual azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterApiServerAccess? ApiServerAccessInput
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterApiServerAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostedSystemInput", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterHostedSystem\"}", isOptional: true)]
        public virtual azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterHostedSystem? HostedSystemInput
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterHostedSystem?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterIdentity\"}", isOptional: true)]
        public virtual azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
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
        [JsiiProperty(name: "privateClusterInput", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterPrivateCluster\"}", isOptional: true)]
        public virtual azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterPrivateCluster? PrivateClusterInput
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterPrivateCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceMeshInput", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMesh\"}", isOptional: true)]
        public virtual azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMesh? ServiceMeshInput
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMesh?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webAppRoutingIngressInput", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterWebAppRoutingIngress\"}", isOptional: true)]
        public virtual azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterWebAppRoutingIngress? WebAppRoutingIngressInput
        {
            get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterWebAppRoutingIngress?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
