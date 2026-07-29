using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsDaemonTaskDefinition
{
    [JsiiByValue(fqn: "aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLinuxParameters")]
    public class EcsDaemonTaskDefinitionContainerDefinitionLinuxParameters : aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLinuxParameters
    {
        private object? _capabilities;

        /// <summary>capabilities block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/ecs_daemon_task_definition#capabilities EcsDaemonTaskDefinition#capabilities}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLinuxParametersCapabilities" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capabilities", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLinuxParametersCapabilities\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Capabilities
        {
            get => _capabilities;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLinuxParametersCapabilities[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLinuxParametersCapabilities).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _capabilities = value;
            }
        }

        private object? _device;

        /// <summary>device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/ecs_daemon_task_definition#device EcsDaemonTaskDefinition#device}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLinuxParametersDevice" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "device", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLinuxParametersDevice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Device
        {
            get => _device;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLinuxParametersDevice[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLinuxParametersDevice).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _device = value;
            }
        }

        private object? _initProcessEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/ecs_daemon_task_definition#init_process_enabled EcsDaemonTaskDefinition#init_process_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initProcessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? InitProcessEnabled
        {
            get => _initProcessEnabled;
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
                _initProcessEnabled = value;
            }
        }

        private object? _tmpfs;

        /// <summary>tmpfs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/ecs_daemon_task_definition#tmpfs EcsDaemonTaskDefinition#tmpfs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLinuxParametersTmpfs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tmpfs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsDaemonTaskDefinition.EcsDaemonTaskDefinitionContainerDefinitionLinuxParametersTmpfs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tmpfs
        {
            get => _tmpfs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLinuxParametersTmpfs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsDaemonTaskDefinition.IEcsDaemonTaskDefinitionContainerDefinitionLinuxParametersTmpfs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tmpfs = value;
            }
        }
    }
}
