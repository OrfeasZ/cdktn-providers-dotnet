using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcKubernetesProvisionedCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/arc_kubernetes_provisioned_cluster azurerm_arc_kubernetes_provisioned_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ArcKubernetesProvisionedCluster.ArcKubernetesProvisionedCluster), fullyQualifiedName: "azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterConfig\"}}]")]
    public class ArcKubernetesProvisionedCluster : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/arc_kubernetes_provisioned_cluster azurerm_arc_kubernetes_provisioned_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ArcKubernetesProvisionedCluster(Constructs.Construct scope, string id, azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ArcKubernetesProvisionedCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ArcKubernetesProvisionedCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ArcKubernetesProvisionedCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ArcKubernetesProvisionedCluster to import.</param>
        /// <param name="importFromId">The id of the existing ArcKubernetesProvisionedCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ArcKubernetesProvisionedCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ArcKubernetesProvisionedCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/arc_kubernetes_provisioned_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ArcKubernetesProvisionedCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ArcKubernetesProvisionedCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.ArcKubernetesProvisionedCluster.ArcKubernetesProvisionedCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAzureActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterAzureActiveDirectory\"}}]")]
        public virtual void PutAzureActiveDirectory(azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterAzureActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterAzureActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArcAgentAutoUpgradeEnabled")]
        public virtual void ResetArcAgentAutoUpgradeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetArcAgentDesiredVersion")]
        public virtual void ResetArcAgentDesiredVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureActiveDirectory")]
        public virtual void ResetAzureActiveDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.ArcKubernetesProvisionedCluster.ArcKubernetesProvisionedCluster))!;

        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "azureActiveDirectory", typeJson: "{\"fqn\":\"azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterAzureActiveDirectoryOutputReference\"}")]
        public virtual azurerm.ArcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterAzureActiveDirectoryOutputReference AzureActiveDirectory
        {
            get => GetInstanceProperty<azurerm.ArcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterAzureActiveDirectoryOutputReference>()!;
        }

        [JsiiProperty(name: "distribution", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Distribution
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterIdentityOutputReference\"}")]
        public virtual azurerm.ArcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.ArcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "infrastructure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Infrastructure
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kubernetesVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubernetesVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "offering", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Offering
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.ArcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ArcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "totalCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalNodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "arcAgentAutoUpgradeEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ArcAgentAutoUpgradeEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "arcAgentDesiredVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArcAgentDesiredVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureActiveDirectoryInput", typeJson: "{\"fqn\":\"azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterAzureActiveDirectory\"}", isOptional: true)]
        public virtual azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterAzureActiveDirectory? AzureActiveDirectoryInput
        {
            get => GetInstanceProperty<azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterAzureActiveDirectory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterIdentity\"}", isOptional: true)]
        public virtual azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterIdentity?>();
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
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "arcAgentAutoUpgradeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ArcAgentAutoUpgradeEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "arcAgentDesiredVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArcAgentDesiredVersion
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
