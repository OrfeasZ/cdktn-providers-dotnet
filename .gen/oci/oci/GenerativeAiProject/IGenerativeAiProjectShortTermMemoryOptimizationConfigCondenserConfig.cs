using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig")]
    public interface IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig
    {
        /// <summary>llm_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_project#llm_selection GenerativeAiProject#llm_selection}
        /// </remarks>
        [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfigLlmSelection\"}")]
        oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfigLlmSelection LlmSelection
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig), fullyQualifiedName: "oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>llm_selection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_project#llm_selection GenerativeAiProject#llm_selection}
            /// </remarks>
            [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfigLlmSelection\"}")]
            public oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfigLlmSelection LlmSelection
            {
                get => GetInstanceProperty<oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfigLlmSelection>()!;
            }
        }
    }
}
