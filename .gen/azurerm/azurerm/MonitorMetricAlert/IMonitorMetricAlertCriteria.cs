using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorMetricAlert
{
    [JsiiInterface(nativeType: typeof(IMonitorMetricAlertCriteria), fullyQualifiedName: "azurerm.monitorMetricAlert.MonitorMetricAlertCriteria")]
    public interface IMonitorMetricAlertCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#aggregation MonitorMetricAlert#aggregation}.</summary>
        [JsiiProperty(name: "aggregation", typeJson: "{\"primitive\":\"string\"}")]
        string Aggregation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#metric_name MonitorMetricAlert#metric_name}.</summary>
        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        string MetricName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#metric_namespace MonitorMetricAlert#metric_namespace}.</summary>
        [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string MetricNamespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#operator MonitorMetricAlert#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#threshold MonitorMetricAlert#threshold}.</summary>
        [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
        double Threshold
        {
            get;
        }

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#dimension MonitorMetricAlert#dimension}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorMetricAlert.IMonitorMetricAlertCriteriaDimension" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorMetricAlert.MonitorMetricAlertCriteriaDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Dimension
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#skip_metric_validation MonitorMetricAlert#skip_metric_validation}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "skipMetricValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipMetricValidation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorMetricAlertCriteria), fullyQualifiedName: "azurerm.monitorMetricAlert.MonitorMetricAlertCriteria")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorMetricAlert.IMonitorMetricAlertCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#aggregation MonitorMetricAlert#aggregation}.</summary>
            [JsiiProperty(name: "aggregation", typeJson: "{\"primitive\":\"string\"}")]
            public string Aggregation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#metric_name MonitorMetricAlert#metric_name}.</summary>
            [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#metric_namespace MonitorMetricAlert#metric_namespace}.</summary>
            [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricNamespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#operator MonitorMetricAlert#operator}.</summary>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#threshold MonitorMetricAlert#threshold}.</summary>
            [JsiiProperty(name: "threshold", typeJson: "{\"primitive\":\"number\"}")]
            public double Threshold
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#dimension MonitorMetricAlert#dimension}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.MonitorMetricAlert.IMonitorMetricAlertCriteriaDimension" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorMetricAlert.MonitorMetricAlertCriteriaDimension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Dimension
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/monitor_metric_alert#skip_metric_validation MonitorMetricAlert#skip_metric_validation}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipMetricValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SkipMetricValidation
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
