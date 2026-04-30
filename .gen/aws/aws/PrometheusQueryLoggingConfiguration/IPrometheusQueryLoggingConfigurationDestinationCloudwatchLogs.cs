using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusQueryLoggingConfiguration
{
    [JsiiInterface(nativeType: typeof(IPrometheusQueryLoggingConfigurationDestinationCloudwatchLogs), fullyQualifiedName: "aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationCloudwatchLogs")]
    public interface IPrometheusQueryLoggingConfigurationDestinationCloudwatchLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/prometheus_query_logging_configuration#log_group_arn PrometheusQueryLoggingConfiguration#log_group_arn}.</summary>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusQueryLoggingConfigurationDestinationCloudwatchLogs), fullyQualifiedName: "aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationCloudwatchLogs")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestinationCloudwatchLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/prometheus_query_logging_configuration#log_group_arn PrometheusQueryLoggingConfiguration#log_group_arn}.</summary>
            [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
