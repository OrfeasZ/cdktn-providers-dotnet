using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance oci_container_instances_container_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstance), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceConfig\"}}]")]
    public class ContainerInstancesContainerInstance : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance oci_container_instances_container_instance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ContainerInstancesContainerInstance(Constructs.Construct scope, string id, oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerInstancesContainerInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerInstancesContainerInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ContainerInstancesContainerInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ContainerInstancesContainerInstance to import.</param>
        /// <param name="importFromId">The id of the existing ContainerInstancesContainerInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ContainerInstancesContainerInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ContainerInstancesContainerInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ContainerInstancesContainerInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ContainerInstancesContainerInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putContainers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainers\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutContainers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainers[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainers).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainers).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDnsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceDnsConfig\"}}]")]
        public virtual void PutDnsConfig(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceDnsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceDnsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImagePullSecrets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceImagePullSecrets\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutImagePullSecrets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceImagePullSecrets[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceImagePullSecrets).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceImagePullSecrets).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceShapeConfig\"}}]")]
        public virtual void PutShapeConfig(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVnics", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVnics\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVnics(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVnics[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVnics).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVnics).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVolumes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVolumes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContainerRestartPolicy")]
        public virtual void ResetContainerRestartPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsConfig")]
        public virtual void ResetDnsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFaultDomain")]
        public virtual void ResetFaultDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGracefulShutdownTimeoutInSeconds")]
        public virtual void ResetGracefulShutdownTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImagePullSecrets")]
        public virtual void ResetImagePullSecrets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumes")]
        public virtual void ResetVolumes()
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
        = GetStaticProperty<string>(typeof(oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstance))!;

        [JsiiProperty(name: "containerCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContainerCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "containers", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersList\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersList Containers
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersList>()!;
        }

        [JsiiProperty(name: "dnsConfig", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceDnsConfigOutputReference\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceDnsConfigOutputReference DnsConfig
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceDnsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "imagePullSecrets", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceImagePullSecretsList\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceImagePullSecretsList ImagePullSecrets
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceImagePullSecretsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceShapeConfigOutputReference\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceShapeConfigOutputReference ShapeConfig
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceShapeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceTimeoutsOutputReference\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vnics", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVnicsList\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVnicsList Vnics
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVnicsList>()!;
        }

        [JsiiProperty(name: "volumeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "volumes", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesList\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesList Volumes
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
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
        [JsiiProperty(name: "containerRestartPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerRestartPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ContainersInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "dnsConfigInput", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceDnsConfig\"}", isOptional: true)]
        public virtual oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceDnsConfig? DnsConfigInput
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceDnsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "faultDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FaultDomainInput
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
        [JsiiProperty(name: "gracefulShutdownTimeoutInSecondsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GracefulShutdownTimeoutInSecondsInput
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
        [JsiiProperty(name: "imagePullSecretsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceImagePullSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ImagePullSecretsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigInput", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceShapeConfig\"}", isOptional: true)]
        public virtual oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceShapeConfig? ShapeConfigInput
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vnicsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVnics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VnicsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VolumesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
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

        [JsiiProperty(name: "containerRestartPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerRestartPolicy
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

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
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

        [JsiiProperty(name: "gracefulShutdownTimeoutInSeconds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GracefulShutdownTimeoutInSeconds
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

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
