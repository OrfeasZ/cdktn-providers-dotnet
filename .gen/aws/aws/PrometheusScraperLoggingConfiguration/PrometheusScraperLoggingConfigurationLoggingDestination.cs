using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraperLoggingConfiguration
{
    [JsiiByValue(fqn: "aws.prometheusScraperLoggingConfiguration.PrometheusScraperLoggingConfigurationLoggingDestination")]
    public class PrometheusScraperLoggingConfigurationLoggingDestination : aws.PrometheusScraperLoggingConfiguration.IPrometheusScraperLoggingConfigurationLoggingDestination
    {
        private object? _cloudwatchLogs;

        /// <summary>cloudwatch_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/prometheus_scraper_logging_configuration#cloudwatch_logs PrometheusScraperLoggingConfiguration#cloudwatch_logs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.PrometheusScraperLoggingConfiguration.IPrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.prometheusScraperLoggingConfiguration.PrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CloudwatchLogs
        {
            get => _cloudwatchLogs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.PrometheusScraperLoggingConfiguration.IPrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.PrometheusScraperLoggingConfiguration.IPrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cloudwatchLogs = value;
            }
        }
    }
}
