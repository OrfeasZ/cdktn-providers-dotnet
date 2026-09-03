using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig")]
    public interface IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#knowledge_base_id BedrockEvaluationJob#knowledge_base_id}.</summary>
        [JsiiProperty(name: "knowledgeBaseId", typeJson: "{\"primitive\":\"string\"}")]
        string KnowledgeBaseId
        {
            get;
        }

        /// <summary>knowledge_base_retrieval_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#knowledge_base_retrieval_configuration BedrockEvaluationJob#knowledge_base_retrieval_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "knowledgeBaseRetrievalConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KnowledgeBaseRetrievalConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#knowledge_base_id BedrockEvaluationJob#knowledge_base_id}.</summary>
            [JsiiProperty(name: "knowledgeBaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string KnowledgeBaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>knowledge_base_retrieval_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrock_evaluation_job#knowledge_base_retrieval_configuration BedrockEvaluationJob#knowledge_base_retrieval_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "knowledgeBaseRetrievalConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfigRetrieveConfigKnowledgeBaseRetrievalConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KnowledgeBaseRetrievalConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
