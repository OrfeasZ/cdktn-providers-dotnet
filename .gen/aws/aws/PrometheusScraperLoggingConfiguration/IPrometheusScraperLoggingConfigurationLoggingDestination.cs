using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraperLoggingConfiguration
{
    [JsiiInterface(nativeType: typeof(IPrometheusScraperLoggingConfigurationLoggingDestination), fullyQualifiedName: "aws.prometheusScraperLoggingConfiguration.PrometheusScraperLoggingConfigurationLoggingDestination")]
    public interface IPrometheusScraperLoggingConfigurationLoggingDestination
    {
        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_scraper_logging_configuration#cloudwatch_logs PrometheusScraperLoggingConfiguration#cloudwatch_logs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusScraperLoggingConfiguration.IPrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraperLoggingConfiguration.PrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudwatchLogs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusScraperLoggingConfigurationLoggingDestination), fullyQualifiedName: "aws.prometheusScraperLoggingConfiguration.PrometheusScraperLoggingConfigurationLoggingDestination")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusScraperLoggingConfiguration.IPrometheusScraperLoggingConfigurationLoggingDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/prometheus_scraper_logging_configuration#cloudwatch_logs PrometheusScraperLoggingConfiguration#cloudwatch_logs}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusScraperLoggingConfiguration.IPrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraperLoggingConfiguration.PrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CloudwatchLogs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
