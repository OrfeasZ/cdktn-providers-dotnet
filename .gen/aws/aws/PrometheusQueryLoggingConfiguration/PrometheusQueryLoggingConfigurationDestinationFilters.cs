using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusQueryLoggingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.prometheusQueryLoggingConfiguration.PrometheusQueryLoggingConfigurationDestinationFilters")]
    public class PrometheusQueryLoggingConfigurationDestinationFilters : aws.PrometheusQueryLoggingConfiguration.IPrometheusQueryLoggingConfigurationDestinationFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/prometheus_query_logging_configuration#qsp_threshold PrometheusQueryLoggingConfiguration#qsp_threshold}.</summary>
        [JsiiProperty(name: "qspThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public double QspThreshold
        {
            get;
            set;
        }
    }
}
