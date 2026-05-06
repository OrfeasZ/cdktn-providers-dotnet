using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster oci_containerengine_cluster}.</summary>
    [JsiiClass(nativeType: typeof(oci.ContainerengineCluster.ContainerengineCluster), fullyQualifiedName: "oci.containerengineCluster.ContainerengineCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterConfig\"}}]")]
    public class ContainerengineCluster : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster oci_containerengine_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ContainerengineCluster(Constructs.Construct scope, string id, oci.ContainerengineCluster.IContainerengineClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.ContainerengineCluster.IContainerengineClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ContainerengineCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ContainerengineCluster to import.</param>
        /// <param name="importFromId">The id of the existing ContainerengineCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ContainerengineCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ContainerengineCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ContainerengineCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ContainerengineCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.ContainerengineCluster.ContainerengineCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putClusterPodNetworkOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterClusterPodNetworkOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClusterPodNetworkOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerengineCluster.IContainerengineClusterClusterPodNetworkOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineCluster.IContainerengineClusterClusterPodNetworkOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineCluster.IContainerengineClusterClusterPodNetworkOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEndpointConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterEndpointConfig\"}}]")]
        public virtual void PutEndpointConfig(oci.ContainerengineCluster.IContainerengineClusterEndpointConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineCluster.IContainerengineClusterEndpointConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImagePolicyConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterImagePolicyConfig\"}}]")]
        public virtual void PutImagePolicyConfig(oci.ContainerengineCluster.IContainerengineClusterImagePolicyConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineCluster.IContainerengineClusterImagePolicyConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptions\"}}]")]
        public virtual void PutOptions(oci.ContainerengineCluster.IContainerengineClusterOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineCluster.IContainerengineClusterOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.ContainerengineCluster.IContainerengineClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineCluster.IContainerengineClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClusterPodNetworkOptions")]
        public virtual void ResetClusterPodNetworkOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpointConfig")]
        public virtual void ResetEndpointConfig()
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

        [JsiiMethod(name: "resetImagePolicyConfig")]
        public virtual void ResetImagePolicyConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOptions")]
        public virtual void ResetOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(oci.ContainerengineCluster.ContainerengineCluster))!;

        [JsiiProperty(name: "availableKubernetesUpgrades", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailableKubernetesUpgrades
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clusterPodNetworkOptions", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterClusterPodNetworkOptionsList\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterClusterPodNetworkOptionsList ClusterPodNetworkOptions
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterClusterPodNetworkOptionsList>()!;
        }

        [JsiiProperty(name: "endpointConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterEndpointConfigOutputReference\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterEndpointConfigOutputReference EndpointConfig
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterEndpointConfigOutputReference>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterEndpointsList\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterEndpointsList Endpoints
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterEndpointsList>()!;
        }

        [JsiiProperty(name: "imagePolicyConfig", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterImagePolicyConfigOutputReference\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterImagePolicyConfigOutputReference ImagePolicyConfig
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterImagePolicyConfigOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterMetadataList\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterMetadataList Metadata
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterMetadataList>()!;
        }

        [JsiiProperty(name: "openIdConnectDiscoveryEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpenIdConnectDiscoveryEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "openIdConnectDiscoveryKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpenIdConnectDiscoveryKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOutputReference\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterOptionsOutputReference Options
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterTimeoutsOutputReference\"}")]
        public virtual oci.ContainerengineCluster.ContainerengineClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.ContainerengineClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterPodNetworkOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterClusterPodNetworkOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClusterPodNetworkOptionsInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "endpointConfigInput", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterEndpointConfig\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterEndpointConfig? EndpointConfigInput
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterEndpointConfig?>();
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
        [JsiiProperty(name: "imagePolicyConfigInput", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterImagePolicyConfig\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterImagePolicyConfig? ImagePolicyConfigInput
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterImagePolicyConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "optionsInput", typeJson: "{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptions\"}", isOptional: true)]
        public virtual oci.ContainerengineCluster.IContainerengineClusterOptions? OptionsInput
        {
            get => GetInstanceProperty<oci.ContainerengineCluster.IContainerengineClusterOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcnIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcnIdInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
