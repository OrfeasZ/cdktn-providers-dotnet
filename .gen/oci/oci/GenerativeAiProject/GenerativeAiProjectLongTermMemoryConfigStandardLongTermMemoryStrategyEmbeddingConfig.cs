using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfig")]
    public class GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfig : oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfig
    {
        /// <summary>llm_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_project#llm_selection GenerativeAiProject#llm_selection}
        /// </remarks>
        [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection\"}")]
        public oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyEmbeddingConfigLlmSelection LlmSelection
        {
            get;
            set;
        }
    }
}
