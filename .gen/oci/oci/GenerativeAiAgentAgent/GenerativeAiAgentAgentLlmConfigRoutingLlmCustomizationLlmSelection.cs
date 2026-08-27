using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection")]
    public class GenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection : oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_agent_agent#llm_selection_type GenerativeAiAgentAgent#llm_selection_type}.</summary>
        [JsiiProperty(name: "llmSelectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string LlmSelectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_agent_agent#endpoint_id GenerativeAiAgentAgent#endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/generative_ai_agent_agent#model_id GenerativeAiAgentAgent#model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelId
        {
            get;
            set;
        }
    }
}
