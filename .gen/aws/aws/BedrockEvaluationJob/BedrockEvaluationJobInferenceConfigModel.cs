using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModel")]
    public class BedrockEvaluationJobInferenceConfigModel : aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModel
    {
        private object? _bedrockModel;

        /// <summary>bedrock_model block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#bedrock_model BedrockEvaluationJob#bedrock_model}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelBedrockModel" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bedrockModel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelBedrockModel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BedrockModel
        {
            get => _bedrockModel;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelBedrockModel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelBedrockModel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bedrockModel = value;
            }
        }

        private object? _precomputedInferenceSource;

        /// <summary>precomputed_inference_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#precomputed_inference_source BedrockEvaluationJob#precomputed_inference_source}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "precomputedInferenceSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PrecomputedInferenceSource
        {
            get => _precomputedInferenceSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigModelPrecomputedInferenceSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _precomputedInferenceSource = value;
            }
        }
    }
}
