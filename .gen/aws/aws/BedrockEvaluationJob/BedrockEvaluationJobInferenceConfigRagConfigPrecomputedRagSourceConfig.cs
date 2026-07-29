using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfig")]
    public class BedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfig : aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfig
    {
        private object? _retrieveAndGenerateSourceConfig;

        /// <summary>retrieve_and_generate_source_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#retrieve_and_generate_source_config BedrockEvaluationJob#retrieve_and_generate_source_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveAndGenerateSourceConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retrieveAndGenerateSourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveAndGenerateSourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RetrieveAndGenerateSourceConfig
        {
            get => _retrieveAndGenerateSourceConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveAndGenerateSourceConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveAndGenerateSourceConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _retrieveAndGenerateSourceConfig = value;
            }
        }

        private object? _retrieveSourceConfig;

        /// <summary>retrieve_source_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#retrieve_source_config BedrockEvaluationJob#retrieve_source_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retrieveSourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RetrieveSourceConfig
        {
            get => _retrieveSourceConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfigRetrieveSourceConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _retrieveSourceConfig = value;
            }
        }
    }
}
