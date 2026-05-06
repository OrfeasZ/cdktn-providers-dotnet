using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementConfig), fullyQualifiedName: "oci.stackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementConfig")]
    public interface IStackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#enable_metric_extension_on_given_resources StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#enable_metric_extension_on_given_resources}.</summary>
        [JsiiProperty(name: "enableMetricExtensionOnGivenResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object EnableMetricExtensionOnGivenResources
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#metric_extension_id StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#metric_extension_id}.</summary>
        [JsiiProperty(name: "metricExtensionId", typeJson: "{\"primitive\":\"string\"}")]
        string MetricExtensionId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#resource_ids StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#resource_ids}.</summary>
        [JsiiProperty(name: "resourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ResourceIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#id StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#timeouts StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement.IStackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementConfig), fullyQualifiedName: "oci.stackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement.IStackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#enable_metric_extension_on_given_resources StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#enable_metric_extension_on_given_resources}.</summary>
            [JsiiProperty(name: "enableMetricExtensionOnGivenResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object EnableMetricExtensionOnGivenResources
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#metric_extension_id StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#metric_extension_id}.</summary>
            [JsiiProperty(name: "metricExtensionId", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricExtensionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#resource_ids StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#resource_ids}.</summary>
            [JsiiProperty(name: "resourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ResourceIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#id StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension_metric_extension_on_given_resources_management#timeouts StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementTimeouts\"}", isOptional: true)]
            public oci.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement.IStackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.StackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagement.IStackMonitoringMetricExtensionMetricExtensionOnGivenResourcesManagementTimeouts?>();
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
