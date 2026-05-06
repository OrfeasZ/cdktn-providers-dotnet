using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool oci_containerengine_node_pool}.</summary>
    [JsiiClass(nativeType: typeof(oci.ContainerengineNodePool.ContainerengineNodePool), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolConfig\"}}]")]
    public class ContainerengineNodePool : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool oci_containerengine_node_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ContainerengineNodePool(Constructs.Construct scope, string id, oci.ContainerengineNodePool.IContainerengineNodePoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.ContainerengineNodePool.IContainerengineNodePoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineNodePool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineNodePool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ContainerengineNodePool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ContainerengineNodePool to import.</param>
        /// <param name="importFromId">The id of the existing ContainerengineNodePool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ContainerengineNodePool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ContainerengineNodePool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_node_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ContainerengineNodePool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ContainerengineNodePool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.ContainerengineNodePool.ContainerengineNodePool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putInitialNodeLabels", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolInitialNodeLabels\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInitialNodeLabels(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerengineNodePool.IContainerengineNodePoolInitialNodeLabels[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineNodePool.IContainerengineNodePoolInitialNodeLabels).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineNodePool.IContainerengineNodePoolInitialNodeLabels).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeConfigDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetails\"}}]")]
        public virtual void PutNodeConfigDetails(oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeEvictionNodePoolSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeEvictionNodePoolSettings\"}}]")]
        public virtual void PutNodeEvictionNodePoolSettings(oci.ContainerengineNodePool.IContainerengineNodePoolNodeEvictionNodePoolSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineNodePool.IContainerengineNodePoolNodeEvictionNodePoolSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodePoolCyclingDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodePoolCyclingDetails\"}}]")]
        public virtual void PutNodePoolCyclingDetails(oci.ContainerengineNodePool.IContainerengineNodePoolNodePoolCyclingDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineNodePool.IContainerengineNodePoolNodePoolCyclingDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeShapeConfig\"}}]")]
        public virtual void PutNodeShapeConfig(oci.ContainerengineNodePool.IContainerengineNodePoolNodeShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineNodePool.IContainerengineNodePoolNodeShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeSourceDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeSourceDetails\"}}]")]
        public virtual void PutNodeSourceDetails(oci.ContainerengineNodePool.IContainerengineNodePoolNodeSourceDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineNodePool.IContainerengineNodePoolNodeSourceDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.ContainerengineNodePool.IContainerengineNodePoolTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineNodePool.IContainerengineNodePoolTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitialNodeLabels")]
        public virtual void ResetInitialNodeLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKubernetesVersion")]
        public virtual void ResetKubernetesVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeConfigDetails")]
        public virtual void ResetNodeConfigDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeEvictionNodePoolSettings")]
        public virtual void ResetNodeEvictionNodePoolSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeImageId")]
        public virtual void ResetNodeImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeImageName")]
        public virtual void ResetNodeImageName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeMetadata")]
        public virtual void ResetNodeMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodePoolCyclingDetails")]
        public virtual void ResetNodePoolCyclingDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeShapeConfig")]
        public virtual void ResetNodeShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeSourceDetails")]
        public virtual void ResetNodeSourceDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuantityPerSubnet")]
        public virtual void ResetQuantityPerSubnet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSshPublicKey")]
        public virtual void ResetSshPublicKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetIds")]
        public virtual void ResetSubnetIds()
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
        = GetStaticProperty<string>(typeof(oci.ContainerengineNodePool.ContainerengineNodePool))!;

        [JsiiProperty(name: "initialNodeLabels", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolInitialNodeLabelsList\"}")]
        public virtual oci.ContainerengineNodePool.ContainerengineNodePoolInitialNodeLabelsList InitialNodeLabels
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.ContainerengineNodePoolInitialNodeLabelsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeConfigDetails", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsOutputReference\"}")]
        public virtual oci.ContainerengineNodePool.ContainerengineNodePoolNodeConfigDetailsOutputReference NodeConfigDetails
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.ContainerengineNodePoolNodeConfigDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "nodeEvictionNodePoolSettings", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeEvictionNodePoolSettingsOutputReference\"}")]
        public virtual oci.ContainerengineNodePool.ContainerengineNodePoolNodeEvictionNodePoolSettingsOutputReference NodeEvictionNodePoolSettings
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.ContainerengineNodePoolNodeEvictionNodePoolSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "nodePoolCyclingDetails", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodePoolCyclingDetailsOutputReference\"}")]
        public virtual oci.ContainerengineNodePool.ContainerengineNodePoolNodePoolCyclingDetailsOutputReference NodePoolCyclingDetails
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.ContainerengineNodePoolNodePoolCyclingDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "nodes", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodesList\"}")]
        public virtual oci.ContainerengineNodePool.ContainerengineNodePoolNodesList Nodes
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.ContainerengineNodePoolNodesList>()!;
        }

        [JsiiProperty(name: "nodeShapeConfig", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeShapeConfigOutputReference\"}")]
        public virtual oci.ContainerengineNodePool.ContainerengineNodePoolNodeShapeConfigOutputReference NodeShapeConfig
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.ContainerengineNodePoolNodeShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "nodeSource", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeSourceList\"}")]
        public virtual oci.ContainerengineNodePool.ContainerengineNodePoolNodeSourceList NodeSource
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.ContainerengineNodePoolNodeSourceList>()!;
        }

        [JsiiProperty(name: "nodeSourceDetails", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeSourceDetailsOutputReference\"}")]
        public virtual oci.ContainerengineNodePool.ContainerengineNodePoolNodeSourceDetailsOutputReference NodeSourceDetails
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.ContainerengineNodePoolNodeSourceDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolTimeoutsOutputReference\"}")]
        public virtual oci.ContainerengineNodePool.ContainerengineNodePoolTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.ContainerengineNodePoolTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialNodeLabelsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolInitialNodeLabels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InitialNodeLabelsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubernetesVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KubernetesVersionInput
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
        [JsiiProperty(name: "nodeConfigDetailsInput", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetails\"}", isOptional: true)]
        public virtual oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetails? NodeConfigDetailsInput
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeEvictionNodePoolSettingsInput", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeEvictionNodePoolSettings\"}", isOptional: true)]
        public virtual oci.ContainerengineNodePool.IContainerengineNodePoolNodeEvictionNodePoolSettings? NodeEvictionNodePoolSettingsInput
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.IContainerengineNodePoolNodeEvictionNodePoolSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeImageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeImageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeImageNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeImageNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeMetadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? NodeMetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodePoolCyclingDetailsInput", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodePoolCyclingDetails\"}", isOptional: true)]
        public virtual oci.ContainerengineNodePool.IContainerengineNodePoolNodePoolCyclingDetails? NodePoolCyclingDetailsInput
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.IContainerengineNodePoolNodePoolCyclingDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeShapeConfigInput", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeShapeConfig\"}", isOptional: true)]
        public virtual oci.ContainerengineNodePool.IContainerengineNodePoolNodeShapeConfig? NodeShapeConfigInput
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.IContainerengineNodePoolNodeShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeShapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeSourceDetailsInput", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeSourceDetails\"}", isOptional: true)]
        public virtual oci.ContainerengineNodePool.IContainerengineNodePoolNodeSourceDetails? NodeSourceDetailsInput
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.IContainerengineNodePoolNodeSourceDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quantityPerSubnetInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QuantityPerSubnetInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshPublicKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SshPublicKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubnetIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kubernetesVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubernetesVersion
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

        [JsiiProperty(name: "nodeImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeImageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeImageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeImageName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeMetadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> NodeMetadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeShape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "quantityPerSubnet", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QuantityPerSubnet
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sshPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshPublicKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
