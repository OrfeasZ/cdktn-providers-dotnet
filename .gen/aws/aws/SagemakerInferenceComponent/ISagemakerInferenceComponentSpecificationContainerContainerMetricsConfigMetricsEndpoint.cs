using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    [JsiiInterface(nativeType: typeof(ISagemakerInferenceComponentSpecificationContainerContainerMetricsConfigMetricsEndpoint), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationContainerContainerMetricsConfigMetricsEndpoint")]
    public interface ISagemakerInferenceComponentSpecificationContainerContainerMetricsConfigMetricsEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#metrics_endpoint_path SagemakerInferenceComponent#metrics_endpoint_path}.</summary>
        [JsiiProperty(name: "metricsEndpointPath", typeJson: "{\"primitive\":\"string\"}")]
        string MetricsEndpointPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#metric_publish_frequency_in_seconds SagemakerInferenceComponent#metric_publish_frequency_in_seconds}.</summary>
        [JsiiProperty(name: "metricPublishFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MetricPublishFrequencyInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerInferenceComponentSpecificationContainerContainerMetricsConfigMetricsEndpoint), fullyQualifiedName: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationContainerContainerMetricsConfigMetricsEndpoint")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationContainerContainerMetricsConfigMetricsEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#metrics_endpoint_path SagemakerInferenceComponent#metrics_endpoint_path}.</summary>
            [JsiiProperty(name: "metricsEndpointPath", typeJson: "{\"primitive\":\"string\"}")]
            public string MetricsEndpointPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.70.0/docs/resources/sagemaker_inference_component#metric_publish_frequency_in_seconds SagemakerInferenceComponent#metric_publish_frequency_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricPublishFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MetricPublishFrequencyInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
