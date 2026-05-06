using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtension
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMetricExtensionMetricListStruct), fullyQualifiedName: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionMetricListStruct")]
    public interface IStackMonitoringMetricExtensionMetricListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#data_type StackMonitoringMetricExtension#data_type}.</summary>
        [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
        string DataType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#name StackMonitoringMetricExtension#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#compute_expression StackMonitoringMetricExtension#compute_expression}.</summary>
        [JsiiProperty(name: "computeExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#display_name StackMonitoringMetricExtension#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#is_dimension StackMonitoringMetricExtension#is_dimension}.</summary>
        [JsiiProperty(name: "isDimension", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDimension
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#is_hidden StackMonitoringMetricExtension#is_hidden}.</summary>
        [JsiiProperty(name: "isHidden", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsHidden
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#metric_category StackMonitoringMetricExtension#metric_category}.</summary>
        [JsiiProperty(name: "metricCategory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricCategory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#unit StackMonitoringMetricExtension#unit}.</summary>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Unit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMetricExtensionMetricListStruct), fullyQualifiedName: "oci.stackMonitoringMetricExtension.StackMonitoringMetricExtensionMetricListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMetricExtension.IStackMonitoringMetricExtensionMetricListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#data_type StackMonitoringMetricExtension#data_type}.</summary>
            [JsiiProperty(name: "dataType", typeJson: "{\"primitive\":\"string\"}")]
            public string DataType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#name StackMonitoringMetricExtension#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#compute_expression StackMonitoringMetricExtension#compute_expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeExpression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#display_name StackMonitoringMetricExtension#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#is_dimension StackMonitoringMetricExtension#is_dimension}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isDimension", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDimension
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#is_hidden StackMonitoringMetricExtension#is_hidden}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isHidden", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsHidden
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#metric_category StackMonitoringMetricExtension#metric_category}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricCategory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricCategory
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extension#unit StackMonitoringMetricExtension#unit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Unit
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
