using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Container
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.container.ContainerConfig")]
    public class ContainerConfig : scaleway.Container.IContainerConfig
    {
        /// <summary>The container namespace associated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#namespace_id Container#namespace_id}
        /// </remarks>
        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string NamespaceId
        {
            get;
            set;
        }

        /// <summary>Arguments passed to the command from the command "field". Overrides the arguments from the container image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#args Container#args}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Args
        {
            get;
            set;
        }

        /// <summary>Command executed when the container starts. Overrides the command from the container image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#command Container#command}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Command
        {
            get;
            set;
        }

        /// <summary>The amount of vCPU computing resources to allocate to each container. Defaults to 70.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#cpu_limit Container#cpu_limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpuLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuLimit
        {
            get;
            set;
        }

        private object? _deploy;

        /// <summary>This allows you to control your production environment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#deploy Container#deploy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deploy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Deploy
        {
            get => _deploy;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _deploy = value;
            }
        }

        /// <summary>The container description.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#description Container#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>The environment variables to be injected into your container at runtime.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#environment_variables Container#environment_variables}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get;
            set;
        }

        private object? _healthCheck;

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#health_check Container#health_check}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheck", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.container.ContainerHealthCheck\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HealthCheck
        {
            get => _healthCheck;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case scaleway.Container.IContainerHealthCheck[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.Container.IContainerHealthCheck).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _healthCheck = value;
            }
        }

        /// <summary>HTTP traffic configuration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#http_option Container#http_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpOption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#id Container#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Local storage limit of the container (in MB).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#local_storage_limit Container#local_storage_limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localStorageLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LocalStorageLimit
        {
            get;
            set;
        }

        /// <summary>The maximum the number of simultaneous requests your container can handle at the same time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#max_concurrency Container#max_concurrency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrency
        {
            get;
            set;
        }

        /// <summary>The maximum of number of instances this container can scale to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#max_scale Container#max_scale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxScale", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxScale
        {
            get;
            set;
        }

        /// <summary>The memory computing resources in MB to allocate to each container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#memory_limit Container#memory_limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryLimit
        {
            get;
            set;
        }

        /// <summary>The minimum of running container instances continuously.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#min_scale Container#min_scale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minScale", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinScale
        {
            get;
            set;
        }

        /// <summary>The container name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#name Container#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>The port to expose the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#port Container#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>The privacy type define the way to authenticate to your container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#privacy Container#privacy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privacy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Privacy
        {
            get;
            set;
        }

        /// <summary>ID of the Private Network the container is connected to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#private_network_id Container#private_network_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateNetworkId
        {
            get;
            set;
        }

        /// <summary>The communication protocol http1 or h2c. Defaults to http1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#protocol Container#protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#region Container#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>The scaleway registry image address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#registry_image Container#registry_image}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registryImage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistryImage
        {
            get;
            set;
        }

        /// <summary>The sha256 of your source registry image, changing it will re-apply the deployment. Can be any string.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#registry_sha256 Container#registry_sha256}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registrySha256", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegistrySha256
        {
            get;
            set;
        }

        /// <summary>Execution environment of the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#sandbox Container#sandbox}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sandbox", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sandbox
        {
            get;
            set;
        }

        private object? _scalingOption;

        /// <summary>scaling_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#scaling_option Container#scaling_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scalingOption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.container.ContainerScalingOption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ScalingOption
        {
            get => _scalingOption;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case scaleway.Container.IContainerScalingOption[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.Container.IContainerScalingOption).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scalingOption = value;
            }
        }

        /// <summary>The secret environment variables to be injected into your container at runtime.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#secret_environment_variables Container#secret_environment_variables}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? SecretEnvironmentVariables
        {
            get;
            set;
        }

        /// <summary>The container status.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#status Container#status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>List of tags ["tag1", "tag2", ...] attached to the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#tags Container#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Tags
        {
            get;
            set;
        }

        /// <summary>The maximum amount of time in seconds during which your container can process a request before we stop it.</summary>
        /// <remarks>
        /// Defaults to 300s.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#timeout Container#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timeout
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/container#timeouts Container#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.container.ContainerTimeouts\"}", isOptional: true)]
        public scaleway.Container.IContainerTimeouts? Timeouts
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
