using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerAppJob.ContainerAppJobTemplateContainer")]
    public class ContainerAppJobTemplateContainer : azurerm.ContainerAppJob.IContainerAppJobTemplateContainer
    {
        /// <summary>The amount of vCPU to allocate to the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_job#cpu ContainerAppJob#cpu}
        /// </remarks>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        public double Cpu
        {
            get;
            set;
        }

        /// <summary>The image to use to create the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_job#image ContainerAppJob#image}
        /// </remarks>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public string Image
        {
            get;
            set;
        }

        /// <summary>The amount of memory to allocate to the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_job#memory ContainerAppJob#memory}
        /// </remarks>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}")]
        public string Memory
        {
            get;
            set;
        }

        /// <summary>The name of the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_job#name ContainerAppJob#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>A list of args to pass to the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_job#args ContainerAppJob#args}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Args
        {
            get;
            set;
        }

        /// <summary>A command to pass to the container to override the default.</summary>
        /// <remarks>
        /// This is provided as a list of command line elements without spaces.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_job#command ContainerAppJob#command}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Command
        {
            get;
            set;
        }

        private object? _env;

        /// <summary>env block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_job#env ContainerAppJob#env}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobTemplateContainerEnv" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateContainerEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Env
        {
            get => _env;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerAppJob.IContainerAppJobTemplateContainerEnv[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobTemplateContainerEnv).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _env = value;
            }
        }

        private object? _livenessProbe;

        /// <summary>liveness_probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_job#liveness_probe ContainerAppJob#liveness_probe}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobTemplateContainerLivenessProbe" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "livenessProbe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateContainerLivenessProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LivenessProbe
        {
            get => _livenessProbe;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerAppJob.IContainerAppJobTemplateContainerLivenessProbe[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobTemplateContainerLivenessProbe).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _livenessProbe = value;
            }
        }

        private object? _readinessProbe;

        /// <summary>readiness_probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_job#readiness_probe ContainerAppJob#readiness_probe}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobTemplateContainerReadinessProbe" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readinessProbe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateContainerReadinessProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ReadinessProbe
        {
            get => _readinessProbe;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerAppJob.IContainerAppJobTemplateContainerReadinessProbe[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobTemplateContainerReadinessProbe).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _readinessProbe = value;
            }
        }

        private object? _startupProbe;

        /// <summary>startup_probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_job#startup_probe ContainerAppJob#startup_probe}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobTemplateContainerStartupProbe" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startupProbe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateContainerStartupProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StartupProbe
        {
            get => _startupProbe;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerAppJob.IContainerAppJobTemplateContainerStartupProbe[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobTemplateContainerStartupProbe).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _startupProbe = value;
            }
        }

        private object? _volumeMounts;

        /// <summary>volume_mounts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/container_app_job#volume_mounts ContainerAppJob#volume_mounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerAppJob.IContainerAppJobTemplateContainerVolumeMounts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeMounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobTemplateContainerVolumeMounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VolumeMounts
        {
            get => _volumeMounts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerAppJob.IContainerAppJobTemplateContainerVolumeMounts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerAppJob.IContainerAppJobTemplateContainerVolumeMounts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _volumeMounts = value;
            }
        }
    }
}
