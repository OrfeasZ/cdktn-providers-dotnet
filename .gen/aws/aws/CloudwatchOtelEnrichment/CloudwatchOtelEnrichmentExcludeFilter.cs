using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchOtelEnrichment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentExcludeFilter")]
    public class CloudwatchOtelEnrichmentExcludeFilter : aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentExcludeFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/cloudwatch_otel_enrichment#namespace CloudwatchOtelEnrichment#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.69.0/docs/resources/cloudwatch_otel_enrichment#metric_names CloudwatchOtelEnrichment#metric_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? MetricNames
        {
            get;
            set;
        }
    }
}
