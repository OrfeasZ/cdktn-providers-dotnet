using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring
{
    [JsiiInterface(nativeType: typeof(ISpringCloudAppDynamicsApplicationPerformanceMonitoringConfig), fullyQualifiedName: "azurerm.springCloudAppDynamicsApplicationPerformanceMonitoring.SpringCloudAppDynamicsApplicationPerformanceMonitoringConfig")]
    public interface ISpringCloudAppDynamicsApplicationPerformanceMonitoringConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_account_access_key SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_account_access_key}.</summary>
        [JsiiProperty(name: "agentAccountAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        string AgentAccountAccessKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_account_name SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_account_name}.</summary>
        [JsiiProperty(name: "agentAccountName", typeJson: "{\"primitive\":\"string\"}")]
        string AgentAccountName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#controller_host_name SpringCloudAppDynamicsApplicationPerformanceMonitoring#controller_host_name}.</summary>
        [JsiiProperty(name: "controllerHostName", typeJson: "{\"primitive\":\"string\"}")]
        string ControllerHostName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#name SpringCloudAppDynamicsApplicationPerformanceMonitoring#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#spring_cloud_service_id SpringCloudAppDynamicsApplicationPerformanceMonitoring#spring_cloud_service_id}.</summary>
        [JsiiProperty(name: "springCloudServiceId", typeJson: "{\"primitive\":\"string\"}")]
        string SpringCloudServiceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_application_name SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_application_name}.</summary>
        [JsiiProperty(name: "agentApplicationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentApplicationName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_node_name SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_node_name}.</summary>
        [JsiiProperty(name: "agentNodeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentNodeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_tier_name SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_tier_name}.</summary>
        [JsiiProperty(name: "agentTierName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentTierName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_unique_host_id SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_unique_host_id}.</summary>
        [JsiiProperty(name: "agentUniqueHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentUniqueHostId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#controller_port SpringCloudAppDynamicsApplicationPerformanceMonitoring#controller_port}.</summary>
        [JsiiProperty(name: "controllerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ControllerPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#controller_ssl_enabled SpringCloudAppDynamicsApplicationPerformanceMonitoring#controller_ssl_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "controllerSslEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ControllerSslEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#globally_enabled SpringCloudAppDynamicsApplicationPerformanceMonitoring#globally_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "globallyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GloballyEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#id SpringCloudAppDynamicsApplicationPerformanceMonitoring#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#timeouts SpringCloudAppDynamicsApplicationPerformanceMonitoring#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudAppDynamicsApplicationPerformanceMonitoring.SpringCloudAppDynamicsApplicationPerformanceMonitoringTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring.ISpringCloudAppDynamicsApplicationPerformanceMonitoringTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudAppDynamicsApplicationPerformanceMonitoringConfig), fullyQualifiedName: "azurerm.springCloudAppDynamicsApplicationPerformanceMonitoring.SpringCloudAppDynamicsApplicationPerformanceMonitoringConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring.ISpringCloudAppDynamicsApplicationPerformanceMonitoringConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_account_access_key SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_account_access_key}.</summary>
            [JsiiProperty(name: "agentAccountAccessKey", typeJson: "{\"primitive\":\"string\"}")]
            public string AgentAccountAccessKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_account_name SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_account_name}.</summary>
            [JsiiProperty(name: "agentAccountName", typeJson: "{\"primitive\":\"string\"}")]
            public string AgentAccountName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#controller_host_name SpringCloudAppDynamicsApplicationPerformanceMonitoring#controller_host_name}.</summary>
            [JsiiProperty(name: "controllerHostName", typeJson: "{\"primitive\":\"string\"}")]
            public string ControllerHostName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#name SpringCloudAppDynamicsApplicationPerformanceMonitoring#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#spring_cloud_service_id SpringCloudAppDynamicsApplicationPerformanceMonitoring#spring_cloud_service_id}.</summary>
            [JsiiProperty(name: "springCloudServiceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SpringCloudServiceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_application_name SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_application_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentApplicationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentApplicationName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_node_name SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_node_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentNodeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentNodeName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_tier_name SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_tier_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentTierName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentTierName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#agent_unique_host_id SpringCloudAppDynamicsApplicationPerformanceMonitoring#agent_unique_host_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentUniqueHostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentUniqueHostId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#controller_port SpringCloudAppDynamicsApplicationPerformanceMonitoring#controller_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "controllerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ControllerPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#controller_ssl_enabled SpringCloudAppDynamicsApplicationPerformanceMonitoring#controller_ssl_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "controllerSslEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ControllerSslEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#globally_enabled SpringCloudAppDynamicsApplicationPerformanceMonitoring#globally_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "globallyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? GloballyEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#id SpringCloudAppDynamicsApplicationPerformanceMonitoring#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/spring_cloud_app_dynamics_application_performance_monitoring#timeouts SpringCloudAppDynamicsApplicationPerformanceMonitoring#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudAppDynamicsApplicationPerformanceMonitoring.SpringCloudAppDynamicsApplicationPerformanceMonitoringTimeouts\"}", isOptional: true)]
            public azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring.ISpringCloudAppDynamicsApplicationPerformanceMonitoringTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SpringCloudAppDynamicsApplicationPerformanceMonitoring.ISpringCloudAppDynamicsApplicationPerformanceMonitoringTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
