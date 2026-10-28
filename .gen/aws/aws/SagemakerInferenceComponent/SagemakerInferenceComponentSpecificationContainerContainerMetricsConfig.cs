using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerInferenceComponent
{
    [JsiiByValue(fqn: "aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationContainerContainerMetricsConfig")]
    public class SagemakerInferenceComponentSpecificationContainerContainerMetricsConfig : aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationContainerContainerMetricsConfig
    {
        private object? _metricsEndpoint;

        /// <summary>metrics_endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/sagemaker_inference_component#metrics_endpoint SagemakerInferenceComponent#metrics_endpoint}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationContainerContainerMetricsConfigMetricsEndpoint" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metricsEndpoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerInferenceComponent.SagemakerInferenceComponentSpecificationContainerContainerMetricsConfigMetricsEndpoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MetricsEndpoint
        {
            get => _metricsEndpoint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationContainerContainerMetricsConfigMetricsEndpoint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerInferenceComponent.ISagemakerInferenceComponentSpecificationContainerContainerMetricsConfigMetricsEndpoint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _metricsEndpoint = value;
            }
        }
    }
}
