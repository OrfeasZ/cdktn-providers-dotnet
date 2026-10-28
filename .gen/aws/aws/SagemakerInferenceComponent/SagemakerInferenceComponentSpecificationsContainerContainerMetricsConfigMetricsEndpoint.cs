using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationsContainerContainerMetricsConfigMetricsEndpoint")]
    public class SagemakerInferenceComponentSpecificationsContainerContainerMetricsConfigMetricsEndpoint : aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationsContainerContainerMetricsConfigMetricsEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#metrics_endpoint_path SagemakerInferenceComponent#metrics_endpoint_path}.</summary>
        [JsiiProperty(name: "metricsEndpointPath", typeJson: "{\"primitive\":\"string\"}")]
        public string MetricsEndpointPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#metric_publish_frequency_in_seconds SagemakerInferenceComponent#metric_publish_frequency_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricPublishFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MetricPublishFrequencyInSeconds
        {
            get;
            set;
        }
    }
}
