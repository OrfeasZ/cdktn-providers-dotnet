using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyExtractionConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyExtractionConfig")]
    public interface IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyExtractionConfig
    {
        /// <summary>llm_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_project#llm_selection GenerativeAiProject#llm_selection}
        /// </remarks>
        [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyExtractionConfigLlmSelection\"}")]
        oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyExtractionConfigLlmSelection LlmSelection
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyExtractionConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyExtractionConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyExtractionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>llm_selection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/generative_ai_project#llm_selection GenerativeAiProject#llm_selection}
            /// </remarks>
            [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyExtractionConfigLlmSelection\"}")]
            public oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyExtractionConfigLlmSelection LlmSelection
            {
                get => GetInstanceProperty<oci.GenerativeAiProject.IGenerativeAiProjectLongTermMemoryConfigStandardLongTermMemoryStrategyExtractionConfigLlmSelection>()!;
            }
        }
    }
}
