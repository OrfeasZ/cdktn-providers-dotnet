using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelBedrockModel")]
    public class BedrockEvaluationJobInferenceConfigModelBedrockModel : aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelBedrockModel
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_evaluation_job#model_identifier BedrockEvaluationJob#model_identifier}.</summary>
        [JsiiProperty(name: "modelIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_evaluation_job#inference_params BedrockEvaluationJob#inference_params}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceParams", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InferenceParams
        {
            get;
            set;
        }

        private object? _performanceConfig;

        /// <summary>performance_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_evaluation_job#performance_config BedrockEvaluationJob#performance_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelBedrockModelPerformanceConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "performanceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelBedrockModelPerformanceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PerformanceConfig
        {
            get => _performanceConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelBedrockModelPerformanceConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelBedrockModelPerformanceConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _performanceConfig = value;
            }
        }
    }
}
