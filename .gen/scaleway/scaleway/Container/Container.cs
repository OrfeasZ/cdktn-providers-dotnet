using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Container
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container scaleway_container}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.Container.Container), fullyQualifiedName: "scaleway.container.Container", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.container.ContainerConfig\"}}]")]
    public class Container : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container scaleway_container} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Container(Constructs.Construct scope, string id, scaleway.Container.IContainerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.Container.IContainerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Container(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Container(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Container resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Container to import.</param>
        /// <param name="importFromId">The id of the existing Container that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Container to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Container to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.75.0/docs/resources/container#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Container that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Container to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.Container.Container), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putHealthCheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.container.ContainerHealthCheck\"}}]")]
        public virtual void PutHealthCheck(scaleway.Container.IContainerHealthCheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.Container.IContainerHealthCheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLivenessProbe", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.container.ContainerLivenessProbe\"}}]")]
        public virtual void PutLivenessProbe(scaleway.Container.IContainerLivenessProbe @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.Container.IContainerLivenessProbe)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScalingOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.container.ContainerScalingOption\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScalingOption(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case scaleway.Container.IContainerScalingOption[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.Container.IContainerScalingOption).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.Container.IContainerScalingOption).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStartupProbe", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.container.ContainerStartupProbe\"}}]")]
        public virtual void PutStartupProbe(scaleway.Container.IContainerStartupProbe @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.Container.IContainerStartupProbe)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.container.ContainerTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.Container.IContainerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.Container.IContainerTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArgs")]
        public virtual void ResetArgs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommand")]
        public virtual void ResetCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuLimit")]
        public virtual void ResetCpuLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploy")]
        public virtual void ResetDeploy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentVariables")]
        public virtual void ResetEnvironmentVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheck")]
        public virtual void ResetHealthCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpOption")]
        public virtual void ResetHttpOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpsConnectionsOnly")]
        public virtual void ResetHttpsConnectionsOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImage")]
        public virtual void ResetImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLivenessProbe")]
        public virtual void ResetLivenessProbe()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalStorageLimit")]
        public virtual void ResetLocalStorageLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalStorageLimitBytes")]
        public virtual void ResetLocalStorageLimitBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxScale")]
        public virtual void ResetMaxScale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryLimit")]
        public virtual void ResetMemoryLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryLimitBytes")]
        public virtual void ResetMemoryLimitBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinScale")]
        public virtual void ResetMinScale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivacy")]
        public virtual void ResetPrivacy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateNetworkId")]
        public virtual void ResetPrivateNetworkId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistryImage")]
        public virtual void ResetRegistryImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistrySha256")]
        public virtual void ResetRegistrySha256()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSandbox")]
        public virtual void ResetSandbox()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScalingOption")]
        public virtual void ResetScalingOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretEnvironmentVariables")]
        public virtual void ResetSecretEnvironmentVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartupProbe")]
        public virtual void ResetStartupProbe()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
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
        = GetStaticProperty<string>(typeof(scaleway.Container.Container))!;

        [JsiiProperty(name: "cronStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CronStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"scaleway.container.ContainerHealthCheckOutputReference\"}")]
        public virtual scaleway.Container.ContainerHealthCheckOutputReference HealthCheck
        {
            get => GetInstanceProperty<scaleway.Container.ContainerHealthCheckOutputReference>()!;
        }

        [JsiiProperty(name: "livenessProbe", typeJson: "{\"fqn\":\"scaleway.container.ContainerLivenessProbeOutputReference\"}")]
        public virtual scaleway.Container.ContainerLivenessProbeOutputReference LivenessProbe
        {
            get => GetInstanceProperty<scaleway.Container.ContainerLivenessProbeOutputReference>()!;
        }

        [JsiiProperty(name: "publicEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scalingOption", typeJson: "{\"fqn\":\"scaleway.container.ContainerScalingOptionList\"}")]
        public virtual scaleway.Container.ContainerScalingOptionList ScalingOption
        {
            get => GetInstanceProperty<scaleway.Container.ContainerScalingOptionList>()!;
        }

        [JsiiProperty(name: "startupProbe", typeJson: "{\"fqn\":\"scaleway.container.ContainerStartupProbeOutputReference\"}")]
        public virtual scaleway.Container.ContainerStartupProbeOutputReference StartupProbe
        {
            get => GetInstanceProperty<scaleway.Container.ContainerStartupProbeOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.container.ContainerTimeoutsOutputReference\"}")]
        public virtual scaleway.Container.ContainerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.Container.ContainerTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "argsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ArgsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CommandInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CpuLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeployInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentVariablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? EnvironmentVariablesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckInput", typeJson: "{\"fqn\":\"scaleway.container.ContainerHealthCheck\"}", isOptional: true)]
        public virtual scaleway.Container.IContainerHealthCheck? HealthCheckInput
        {
            get => GetInstanceProperty<scaleway.Container.IContainerHealthCheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpOptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpOptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpsConnectionsOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HttpsConnectionsOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "livenessProbeInput", typeJson: "{\"fqn\":\"scaleway.container.ContainerLivenessProbe\"}", isOptional: true)]
        public virtual scaleway.Container.IContainerLivenessProbe? LivenessProbeInput
        {
            get => GetInstanceProperty<scaleway.Container.IContainerLivenessProbe?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localStorageLimitBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LocalStorageLimitBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localStorageLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LocalStorageLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxScaleInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxScaleInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryLimitBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryLimitBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minScaleInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinScaleInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privacyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivacyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateNetworkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateNetworkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
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
        [JsiiProperty(name: "registryImageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegistryImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registrySha256Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegistrySha256Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sandboxInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SandboxInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingOptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.container.ContainerScalingOption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScalingOptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretEnvironmentVariablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SecretEnvironmentVariablesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startupProbeInput", typeJson: "{\"fqn\":\"scaleway.container.ContainerStartupProbe\"}", isOptional: true)]
        public virtual scaleway.Container.IContainerStartupProbe? StartupProbeInput
        {
            get => GetInstanceProperty<scaleway.Container.IContainerStartupProbe?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.container.ContainerTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Args
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Command
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Deploy
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvironmentVariables
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpOption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpOption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpsConnectionsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object HttpsConnectionsOnly
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localStorageLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LocalStorageLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localStorageLimitBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LocalStorageLimitBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxScale", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxScale
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryLimitBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryLimitBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minScale", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinScale
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamespaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privacy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Privacy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateNetworkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
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

        [JsiiProperty(name: "registryImage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistryImage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "registrySha256", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistrySha256
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sandbox", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sandbox
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SecretEnvironmentVariables
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
