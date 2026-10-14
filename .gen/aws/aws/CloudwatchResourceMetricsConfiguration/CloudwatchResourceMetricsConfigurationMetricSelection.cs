using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchResourceMetricsConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfigurationMetricSelection")]
    public class CloudwatchResourceMetricsConfigurationMetricSelection : aws.CloudwatchResourceMetricsConfiguration.ICloudwatchResourceMetricsConfigurationMetricSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/cloudwatch_resource_metrics_configuration#include_metrics CloudwatchResourceMetricsConfiguration#include_metrics}.</summary>
        [JsiiProperty(name: "includeMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] IncludeMetrics
        {
            get;
            set;
        }
    }
}
