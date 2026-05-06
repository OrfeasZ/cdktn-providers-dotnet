using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagementAgentManagementAgentDataSource
{
    [JsiiInterface(nativeType: typeof(IManagementAgentManagementAgentDataSourceConfig), fullyQualifiedName: "oci.managementAgentManagementAgentDataSource.ManagementAgentManagementAgentDataSourceConfig")]
    public interface IManagementAgentManagementAgentDataSourceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#compartment_id ManagementAgentManagementAgentDataSource#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#management_agent_id ManagementAgentManagementAgentDataSource#management_agent_id}.</summary>
        [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagementAgentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#name ManagementAgentManagementAgentDataSource#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#type ManagementAgentManagementAgentDataSource#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#url ManagementAgentManagementAgentDataSource#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#allow_metrics ManagementAgentManagementAgentDataSource#allow_metrics}.</summary>
        [JsiiProperty(name: "allowMetrics", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllowMetrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#connection_timeout ManagementAgentManagementAgentDataSource#connection_timeout}.</summary>
        [JsiiProperty(name: "connectionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectionTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#id ManagementAgentManagementAgentDataSource#id}.</summary>
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

        /// <summary>metric_dimensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#metric_dimensions ManagementAgentManagementAgentDataSource#metric_dimensions}
        /// </remarks>
        [JsiiProperty(name: "metricDimensions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.managementAgentManagementAgentDataSource.ManagementAgentManagementAgentDataSourceMetricDimensions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MetricDimensions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#namespace ManagementAgentManagementAgentDataSource#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#proxy_url ManagementAgentManagementAgentDataSource#proxy_url}.</summary>
        [JsiiProperty(name: "proxyUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProxyUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#read_data_limit_in_kilobytes ManagementAgentManagementAgentDataSource#read_data_limit_in_kilobytes}.</summary>
        [JsiiProperty(name: "readDataLimitInKilobytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadDataLimitInKilobytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#read_timeout ManagementAgentManagementAgentDataSource#read_timeout}.</summary>
        [JsiiProperty(name: "readTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#resource_group ManagementAgentManagementAgentDataSource#resource_group}.</summary>
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#schedule_mins ManagementAgentManagementAgentDataSource#schedule_mins}.</summary>
        [JsiiProperty(name: "scheduleMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScheduleMins
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#timeouts ManagementAgentManagementAgentDataSource#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.managementAgentManagementAgentDataSource.ManagementAgentManagementAgentDataSourceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ManagementAgentManagementAgentDataSource.IManagementAgentManagementAgentDataSourceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagementAgentManagementAgentDataSourceConfig), fullyQualifiedName: "oci.managementAgentManagementAgentDataSource.ManagementAgentManagementAgentDataSourceConfig")]
        internal sealed class _Proxy : DeputyBase, oci.ManagementAgentManagementAgentDataSource.IManagementAgentManagementAgentDataSourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#compartment_id ManagementAgentManagementAgentDataSource#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#management_agent_id ManagementAgentManagementAgentDataSource#management_agent_id}.</summary>
            [JsiiProperty(name: "managementAgentId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagementAgentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#name ManagementAgentManagementAgentDataSource#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#type ManagementAgentManagementAgentDataSource#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#url ManagementAgentManagementAgentDataSource#url}.</summary>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#allow_metrics ManagementAgentManagementAgentDataSource#allow_metrics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowMetrics", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllowMetrics
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#connection_timeout ManagementAgentManagementAgentDataSource#connection_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectionTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#id ManagementAgentManagementAgentDataSource#id}.</summary>
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

            /// <summary>metric_dimensions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#metric_dimensions ManagementAgentManagementAgentDataSource#metric_dimensions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricDimensions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.managementAgentManagementAgentDataSource.ManagementAgentManagementAgentDataSourceMetricDimensions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MetricDimensions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#namespace ManagementAgentManagementAgentDataSource#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#proxy_url ManagementAgentManagementAgentDataSource#proxy_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proxyUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProxyUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#read_data_limit_in_kilobytes ManagementAgentManagementAgentDataSource#read_data_limit_in_kilobytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readDataLimitInKilobytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadDataLimitInKilobytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#read_timeout ManagementAgentManagementAgentDataSource#read_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#resource_group ManagementAgentManagementAgentDataSource#resource_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#schedule_mins ManagementAgentManagementAgentDataSource#schedule_mins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScheduleMins
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_management_agent_data_source#timeouts ManagementAgentManagementAgentDataSource#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.managementAgentManagementAgentDataSource.ManagementAgentManagementAgentDataSourceTimeouts\"}", isOptional: true)]
            public oci.ManagementAgentManagementAgentDataSource.IManagementAgentManagementAgentDataSourceTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.ManagementAgentManagementAgentDataSource.IManagementAgentManagementAgentDataSourceTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
