using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfig")]
    public class BedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfig : aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#knowledge_base_id BedrockEvaluationJob#knowledge_base_id}.</summary>
        [JsiiProperty(name: "knowledgeBaseId", typeJson: "{\"primitive\":\"string\"}")]
        public string KnowledgeBaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#model_arn BedrockEvaluationJob#model_arn}.</summary>
        [JsiiProperty(name: "modelArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelArn
        {
            get;
            set;
        }

        private object? _retrievalConfiguration;

        /// <summary>retrieval_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrock_evaluation_job#retrieval_configuration BedrockEvaluationJob#retrieval_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retrievalConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RetrievalConfiguration
        {
            get => _retrievalConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveAndGenerateConfigRetrievalConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _retrievalConfiguration = value;
            }
        }
    }
}
