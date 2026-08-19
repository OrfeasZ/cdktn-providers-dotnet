using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusQueryLoggingConfiguration
{
    [JsiiInterface(nativeType: typeof(IPrometheusQueryLoggingConfigurationDestination), fullyQualifiedName: "aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestination")]
    public interface IPrometheusQueryLoggingConfigurationDestination
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_query_logging_configuration#cloudwatch_logs PrometheusQueryLoggingConfiguration#cloudwatch_logs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestinationCloudwatchLogs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationCloudwatchLogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>filters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_query_logging_configuration#filters PrometheusQueryLoggingConfiguration#filters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestinationFilters" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusQueryLoggingConfigurationDestination), fullyQualifiedName: "aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestination")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_query_logging_configuration#cloudwatch_logs PrometheusQueryLoggingConfiguration#cloudwatch_logs}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestinationCloudwatchLogs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationCloudwatchLogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CloudwatchLogs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>filters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_query_logging_configuration#filters PrometheusQueryLoggingConfiguration#filters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestinationFilters" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filters
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
