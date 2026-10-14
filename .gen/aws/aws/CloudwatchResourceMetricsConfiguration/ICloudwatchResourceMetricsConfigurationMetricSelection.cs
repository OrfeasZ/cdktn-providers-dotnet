using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchResourceMetricsConfiguration
{
    [JsiiInterface(nativeType: typeof(ICloudwatchResourceMetricsConfigurationMetricSelection), fullyQualifiedName: "aws.cloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfigurationMetricSelection")]
    public interface ICloudwatchResourceMetricsConfigurationMetricSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/cloudwatch_resource_metrics_configuration#include_metrics CloudwatchResourceMetricsConfiguration#include_metrics}.</summary>
        [JsiiProperty(name: "includeMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] IncludeMetrics
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchResourceMetricsConfigurationMetricSelection), fullyQualifiedName: "aws.cloudwatchResourceMetricsConfiguration.CloudwatchResourceMetricsConfigurationMetricSelection")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchResourceMetricsConfiguration.ICloudwatchResourceMetricsConfigurationMetricSelection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/cloudwatch_resource_metrics_configuration#include_metrics CloudwatchResourceMetricsConfiguration#include_metrics}.</summary>
            [JsiiProperty(name: "includeMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] IncludeMetrics
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
