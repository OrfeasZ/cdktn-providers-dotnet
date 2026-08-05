using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusScraperLoggingConfiguration
{
    [JsiiInterface(nativeType: typeof(IPrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs), fullyQualifiedName: "aws.prometheusScraperLoggingConfiguration.PrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs")]
    public interface IPrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/prometheus_scraper_logging_configuration#log_group_arn PrometheusScraperLoggingConfiguration#log_group_arn}.</summary>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs), fullyQualifiedName: "aws.prometheusScraperLoggingConfiguration.PrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusScraperLoggingConfiguration.IPrometheusScraperLoggingConfigurationLoggingDestinationCloudwatchLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/prometheus_scraper_logging_configuration#log_group_arn PrometheusScraperLoggingConfiguration#log_group_arn}.</summary>
            [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
