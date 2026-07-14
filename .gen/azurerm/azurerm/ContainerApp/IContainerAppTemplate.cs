using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppTemplate), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplate")]
    public interface IContainerAppTemplate
    {
        /// <summary>container block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#container ContainerApp#container}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateContainer" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainer\"},\"kind\":\"array\"}}]}}")]
        object Container
        {
            get;
        }

        /// <summary>azure_queue_scale_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#azure_queue_scale_rule ContainerApp#azure_queue_scale_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateAzureQueueScaleRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "azureQueueScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateAzureQueueScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AzureQueueScaleRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of seconds to wait before scaling down the number of instances again.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#cooldown_period_in_seconds ContainerApp#cooldown_period_in_seconds}
        /// </remarks>
        [JsiiProperty(name: "cooldownPeriodInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CooldownPeriodInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_scale_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#custom_scale_rule ContainerApp#custom_scale_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateCustomScaleRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateCustomScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomScaleRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_scale_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#http_scale_rule ContainerApp#http_scale_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateHttpScaleRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "httpScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateHttpScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpScaleRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>init_container block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#init_container ContainerApp#init_container}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateInitContainer" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "initContainer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateInitContainer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InitContainer
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum number of replicas for this container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#max_replicas ContainerApp#max_replicas}
        /// </remarks>
        [JsiiProperty(name: "maxReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxReplicas
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum number of replicas for this container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#min_replicas ContainerApp#min_replicas}
        /// </remarks>
        [JsiiProperty(name: "minReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinReplicas
        {
            get
            {
                return null;
            }
        }

        /// <summary>The interval in seconds used for polling KEDA.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#polling_interval_in_seconds ContainerApp#polling_interval_in_seconds}
        /// </remarks>
        [JsiiProperty(name: "pollingIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PollingIntervalInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The suffix for the revision.</summary>
        /// <remarks>
        /// This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#revision_suffix ContainerApp#revision_suffix}
        /// </remarks>
        [JsiiProperty(name: "revisionSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RevisionSuffix
        {
            get
            {
                return null;
            }
        }

        /// <summary>tcp_scale_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#tcp_scale_rule ContainerApp#tcp_scale_rule}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateTcpScaleRule" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tcpScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateTcpScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TcpScaleRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>The time in seconds after the container is sent the termination signal before the process if forcibly killed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#termination_grace_period_seconds ContainerApp#termination_grace_period_seconds}
        /// </remarks>
        [JsiiProperty(name: "terminationGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TerminationGracePeriodSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>volume block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#volume ContainerApp#volume}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateVolume" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "volume", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateVolume\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Volume
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppTemplate), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplate")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>container block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#container ContainerApp#container}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateContainer" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainer\"},\"kind\":\"array\"}}]}}")]
            public object Container
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>azure_queue_scale_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#azure_queue_scale_rule ContainerApp#azure_queue_scale_rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateAzureQueueScaleRule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureQueueScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateAzureQueueScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AzureQueueScaleRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The number of seconds to wait before scaling down the number of instances again.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#cooldown_period_in_seconds ContainerApp#cooldown_period_in_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cooldownPeriodInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CooldownPeriodInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>custom_scale_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#custom_scale_rule ContainerApp#custom_scale_rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateCustomScaleRule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateCustomScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomScaleRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_scale_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#http_scale_rule ContainerApp#http_scale_rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateHttpScaleRule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateHttpScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HttpScaleRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>init_container block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#init_container ContainerApp#init_container}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateInitContainer" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initContainer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateInitContainer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InitContainer
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The maximum number of replicas for this container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#max_replicas ContainerApp#max_replicas}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxReplicas
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The minimum number of replicas for this container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#min_replicas ContainerApp#min_replicas}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinReplicas
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The interval in seconds used for polling KEDA.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#polling_interval_in_seconds ContainerApp#polling_interval_in_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pollingIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PollingIntervalInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The suffix for the revision.</summary>
            /// <remarks>
            /// This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#revision_suffix ContainerApp#revision_suffix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "revisionSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RevisionSuffix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tcp_scale_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#tcp_scale_rule ContainerApp#tcp_scale_rule}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateTcpScaleRule" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpScaleRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateTcpScaleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TcpScaleRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The time in seconds after the container is sent the termination signal before the process if forcibly killed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#termination_grace_period_seconds ContainerApp#termination_grace_period_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "terminationGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TerminationGracePeriodSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>volume block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/container_app#volume ContainerApp#volume}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ContainerApp.IContainerAppTemplateVolume" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volume", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateVolume\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Volume
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
