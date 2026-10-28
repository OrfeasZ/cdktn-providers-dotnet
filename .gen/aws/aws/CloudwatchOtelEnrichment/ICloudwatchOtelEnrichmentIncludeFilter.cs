using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchOtelEnrichment
{
    [JsiiInterface(nativeType: typeof(ICloudwatchOtelEnrichmentIncludeFilter), fullyQualifiedName: "aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentIncludeFilter")]
    public interface ICloudwatchOtelEnrichmentIncludeFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatch_otel_enrichment#namespace CloudwatchOtelEnrichment#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatch_otel_enrichment#metric_names CloudwatchOtelEnrichment#metric_names}.</summary>
        [JsiiProperty(name: "metricNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MetricNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchOtelEnrichmentIncludeFilter), fullyQualifiedName: "aws.cloudwatchOtelEnrichment.CloudwatchOtelEnrichmentIncludeFilter")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchOtelEnrichment.ICloudwatchOtelEnrichmentIncludeFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatch_otel_enrichment#namespace CloudwatchOtelEnrichment#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/cloudwatch_otel_enrichment#metric_names CloudwatchOtelEnrichment#metric_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MetricNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
