using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection")]
    public interface IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_project#llm_selection_type GenerativeAiProject#llm_selection_type}.</summary>
        [JsiiProperty(name: "llmSelectionType", typeJson: "{\"primitive\":\"string\"}")]
        string LlmSelectionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_project#model_id GenerativeAiProject#model_id}.</summary>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        string ModelId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_project#llm_selection_type GenerativeAiProject#llm_selection_type}.</summary>
            [JsiiProperty(name: "llmSelectionType", typeJson: "{\"primitive\":\"string\"}")]
            public string LlmSelectionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_project#model_id GenerativeAiProject#model_id}.</summary>
            [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
