using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineVirtualNodePool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool oci_containerengine_virtual_node_pool}.</summary>
    [JsiiClass(nativeType: typeof(oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePool), fullyQualifiedName: "oci.containerengineVirtualNodePool.ContainerengineVirtualNodePool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolConfig\"}}]")]
    public class ContainerengineVirtualNodePool : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool oci_containerengine_virtual_node_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ContainerengineVirtualNodePool(Constructs.Construct scope, string id, oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineVirtualNodePool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineVirtualNodePool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ContainerengineVirtualNodePool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ContainerengineVirtualNodePool to import.</param>
        /// <param name="importFromId">The id of the existing ContainerengineVirtualNodePool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ContainerengineVirtualNodePool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ContainerengineVirtualNodePool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ContainerengineVirtualNodePool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ContainerengineVirtualNodePool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putInitialVirtualNodeLabels", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolInitialVirtualNodeLabels\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInitialVirtualNodeLabels(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolInitialVirtualNodeLabels[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolInitialVirtualNodeLabels).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolInitialVirtualNodeLabels).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacementConfigurations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolPlacementConfigurations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPlacementConfigurations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolPlacementConfigurations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolPlacementConfigurations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolPlacementConfigurations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPodConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolPodConfiguration\"}}]")]
        public virtual void PutPodConfiguration(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolPodConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolPodConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTaints", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolTaints\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTaints(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolTaints[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolTaints).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolTaints).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVirtualNodeTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolVirtualNodeTags\"}}]")]
        public virtual void PutVirtualNodeTags(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolVirtualNodeTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolVirtualNodeTags)}, new object[]{@value});
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

        [JsiiMethod(name: "resetInitialVirtualNodeLabels")]
        public virtual void ResetInitialVirtualNodeLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNsgIds")]
        public virtual void ResetNsgIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaints")]
        public virtual void ResetTaints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualNodeTags")]
        public virtual void ResetVirtualNodeTags()
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
        = GetStaticProperty<string>(typeof(oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePool))!;

        [JsiiProperty(name: "initialVirtualNodeLabels", typeJson: "{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolInitialVirtualNodeLabelsList\"}")]
        public virtual oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolInitialVirtualNodeLabelsList InitialVirtualNodeLabels
        {
            get => GetInstanceProperty<oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolInitialVirtualNodeLabelsList>()!;
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

        [JsiiProperty(name: "placementConfigurations", typeJson: "{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolPlacementConfigurationsList\"}")]
        public virtual oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolPlacementConfigurationsList PlacementConfigurations
        {
            get => GetInstanceProperty<oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolPlacementConfigurationsList>()!;
        }

        [JsiiProperty(name: "podConfiguration", typeJson: "{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolPodConfigurationOutputReference\"}")]
        public virtual oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolPodConfigurationOutputReference PodConfiguration
        {
            get => GetInstanceProperty<oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolPodConfigurationOutputReference>()!;
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

        [JsiiProperty(name: "taints", typeJson: "{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolTaintsList\"}")]
        public virtual oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolTaintsList Taints
        {
            get => GetInstanceProperty<oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolTaintsList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolTimeoutsOutputReference\"}")]
        public virtual oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualNodeTags", typeJson: "{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolVirtualNodeTagsOutputReference\"}")]
        public virtual oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolVirtualNodeTagsOutputReference VirtualNodeTags
        {
            get => GetInstanceProperty<oci.ContainerengineVirtualNodePool.ContainerengineVirtualNodePoolVirtualNodeTagsOutputReference>()!;
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
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "initialVirtualNodeLabelsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolInitialVirtualNodeLabels\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InitialVirtualNodeLabelsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nsgIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NsgIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementConfigurationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolPlacementConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PlacementConfigurationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "podConfigurationInput", typeJson: "{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolPodConfiguration\"}", isOptional: true)]
        public virtual oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolPodConfiguration? PodConfigurationInput
        {
            get => GetInstanceProperty<oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolPodConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taintsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolTaints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TaintsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualNodeTagsInput", typeJson: "{\"fqn\":\"oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolVirtualNodeTags\"}", isOptional: true)]
        public virtual oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolVirtualNodeTags? VirtualNodeTagsInput
        {
            get => GetInstanceProperty<oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolVirtualNodeTags?>();
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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
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
