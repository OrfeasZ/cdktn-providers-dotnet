using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusQueryLoggingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationCloudwatchLogs")]
    public class PrometheusQueryLoggingConfigurationDestinationCloudwatchLogs : aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestinationCloudwatchLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/prometheus_query_logging_configuration#log_group_arn PrometheusQueryLoggingConfiguration#log_group_arn}.</summary>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupArn
        {
            get;
            set;
        }
    }
}
