using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfig")]
    public interface IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfig
    {
        /// <summary>llm_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_project#llm_selection GenerativeAiProject#llm_selection}
        /// </remarks>
        [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection\"}")]
        oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection LlmSelection
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>llm_selection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_project#llm_selection GenerativeAiProject#llm_selection}
            /// </remarks>
            [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection\"}")]
            public oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection LlmSelection
            {
                get => GetInstanceProperty<oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection>()!;
            }
        }
    }
}
