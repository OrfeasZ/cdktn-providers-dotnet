using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfig")]
    public class BedrockEvaluationJobInferenceConfigRagConfig : aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfig
    {
        private object? _knowledgeBaseConfig;

        /// <summary>knowledge_base_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#knowledge_base_config BedrockEvaluationJob#knowledge_base_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "knowledgeBaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KnowledgeBaseConfig
        {
            get => _knowledgeBaseConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _knowledgeBaseConfig = value;
            }
        }

        private object? _precomputedRagSourceConfig;

        /// <summary>precomputed_rag_source_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrock_evaluation_job#precomputed_rag_source_config BedrockEvaluationJob#precomputed_rag_source_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "precomputedRagSourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PrecomputedRagSourceConfig
        {
            get => _precomputedRagSourceConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _precomputedRagSourceConfig = value;
            }
        }
    }
}
