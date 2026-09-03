using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentToolToolConfigGenerationLlmCustomizationLlmSelection), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigGenerationLlmCustomizationLlmSelection")]
    public interface IGenerativeAiAgentToolToolConfigGenerationLlmCustomizationLlmSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_tool#llm_selection_type GenerativeAiAgentTool#llm_selection_type}.</summary>
        [JsiiProperty(name: "llmSelectionType", typeJson: "{\"primitive\":\"string\"}")]
        string LlmSelectionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_tool#endpoint_id GenerativeAiAgentTool#endpoint_id}.</summary>
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_tool#model_id GenerativeAiAgentTool#model_id}.</summary>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentToolToolConfigGenerationLlmCustomizationLlmSelection), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigGenerationLlmCustomizationLlmSelection")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigGenerationLlmCustomizationLlmSelection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_tool#llm_selection_type GenerativeAiAgentTool#llm_selection_type}.</summary>
            [JsiiProperty(name: "llmSelectionType", typeJson: "{\"primitive\":\"string\"}")]
            public string LlmSelectionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_tool#endpoint_id GenerativeAiAgentTool#endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/generative_ai_agent_tool#model_id GenerativeAiAgentTool#model_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
