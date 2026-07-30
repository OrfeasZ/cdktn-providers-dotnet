using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerApp.ContainerAppTemplate")]
    public class ContainerAppTemplate : azurerm.ContainerApp.IContainerAppTemplate
    {
        private object _container;

        /// <summary>container block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#container ContainerApp#container}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateContainer" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainer\"},\"kind\":\"array\"}}]}}")]
        public object Container
        {
            get => _container;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppTemplateContainer[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppTemplateContainer).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppTemplateContainer).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _container = value;
            }
        }

        private object? _azureQueueScaleRule;

        /// <summary>azure_queue_scale_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#azure_queue_scale_rule ContainerApp#azure_queue_scale_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateAzureQueueScaleRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureQueueScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateAzureQueueScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AzureQueueScaleRule
        {
            get => _azureQueueScaleRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppTemplateAzureQueueScaleRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppTemplateAzureQueueScaleRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _azureQueueScaleRule = value;
            }
        }

        /// <summary>The number of seconds to wait before scaling down the number of instances again.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#cooldown_period_in_seconds ContainerApp#cooldown_period_in_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cooldownPeriodInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CooldownPeriodInSeconds
        {
            get;
            set;
        }

        private object? _customScaleRule;

        /// <summary>custom_scale_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#custom_scale_rule ContainerApp#custom_scale_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateCustomScaleRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateCustomScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomScaleRule
        {
            get => _customScaleRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppTemplateCustomScaleRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppTemplateCustomScaleRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customScaleRule = value;
            }
        }

        private object? _httpScaleRule;

        /// <summary>http_scale_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#http_scale_rule ContainerApp#http_scale_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateHttpScaleRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateHttpScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HttpScaleRule
        {
            get => _httpScaleRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppTemplateHttpScaleRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppTemplateHttpScaleRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _httpScaleRule = value;
            }
        }

        private object? _initContainer;

        /// <summary>init_container block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#init_container ContainerApp#init_container}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateInitContainer" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initContainer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateInitContainer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InitContainer
        {
            get => _initContainer;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppTemplateInitContainer[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppTemplateInitContainer).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _initContainer = value;
            }
        }

        /// <summary>The maximum number of replicas for this container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#max_replicas ContainerApp#max_replicas}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxReplicas
        {
            get;
            set;
        }

        /// <summary>The minimum number of replicas for this container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#min_replicas ContainerApp#min_replicas}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinReplicas
        {
            get;
            set;
        }

        /// <summary>The interval in seconds used for polling KEDA.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#polling_interval_in_seconds ContainerApp#polling_interval_in_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pollingIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PollingIntervalInSeconds
        {
            get;
            set;
        }

        /// <summary>The suffix for the revision.</summary>
        /// <remarks>
        /// This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#revision_suffix ContainerApp#revision_suffix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revisionSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RevisionSuffix
        {
            get;
            set;
        }

        private object? _tcpScaleRule;

        /// <summary>tcp_scale_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#tcp_scale_rule ContainerApp#tcp_scale_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateTcpScaleRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateTcpScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TcpScaleRule
        {
            get => _tcpScaleRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppTemplateTcpScaleRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppTemplateTcpScaleRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tcpScaleRule = value;
            }
        }

        /// <summary>The time in seconds after the container is sent the termination signal before the process if forcibly killed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#termination_grace_period_seconds ContainerApp#termination_grace_period_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "terminationGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TerminationGracePeriodSeconds
        {
            get;
            set;
        }

        private object? _volume;

        /// <summary>volume block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/container_app#volume ContainerApp#volume}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateVolume" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volume", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateVolume\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Volume
        {
            get => _volume;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerApp.IContainerAppTemplateVolume[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ContainerApp.IContainerAppTemplateVolume).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _volume = value;
            }
        }
    }
}
