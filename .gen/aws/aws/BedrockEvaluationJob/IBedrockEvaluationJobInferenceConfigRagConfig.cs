using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockEvaluationJob
{
    [JsiiInterface(nativeType: typeof(IBedrockEvaluationJobInferenceConfigRagConfig), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfig")]
    public interface IBedrockEvaluationJobInferenceConfigRagConfig
    {
        /// <summary>knowledge_base_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_evaluation_job#knowledge_base_config BedrockEvaluationJob#knowledge_base_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "knowledgeBaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KnowledgeBaseConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>precomputed_rag_source_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_evaluation_job#precomputed_rag_source_config BedrockEvaluationJob#precomputed_rag_source_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "precomputedRagSourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrecomputedRagSourceConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockEvaluationJobInferenceConfigRagConfig), fullyQualifiedName: "aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfig")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>knowledge_base_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_evaluation_job#knowledge_base_config BedrockEvaluationJob#knowledge_base_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "knowledgeBaseConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigKnowledgeBaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KnowledgeBaseConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>precomputed_rag_source_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/bedrock_evaluation_job#precomputed_rag_source_config BedrockEvaluationJob#precomputed_rag_source_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockEvaluationJob.IBedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "precomputedRagSourceConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockEvaluationJob.BedrockEvaluationJobInferenceConfigRagConfigPrecomputedRagSourceConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrecomputedRagSourceConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
