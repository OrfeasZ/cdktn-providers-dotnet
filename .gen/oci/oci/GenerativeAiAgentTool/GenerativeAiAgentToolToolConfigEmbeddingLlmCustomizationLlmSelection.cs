using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelection")]
    public class GenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelection : oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigEmbeddingLlmCustomizationLlmSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_agent_tool#llm_selection_type GenerativeAiAgentTool#llm_selection_type}.</summary>
        [JsiiProperty(name: "llmSelectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string LlmSelectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_agent_tool#endpoint_id GenerativeAiAgentTool#endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_agent_tool#model_id GenerativeAiAgentTool#model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelId
        {
            get;
            set;
        }
    }
}
