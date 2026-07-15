using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgent
{
    [JsiiByValue(fqn: "oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomization")]
    public class GenerativeAiAgentAgentLlmConfigRoutingLlmCustomization : oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_agent_agent#instruction GenerativeAiAgentAgent#instruction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Instruction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_agent_agent#llm_hyper_parameters GenerativeAiAgentAgent#llm_hyper_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "llmHyperParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? LlmHyperParameters
        {
            get;
            set;
        }

        /// <summary>llm_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/generative_ai_agent_agent#llm_selection GenerativeAiAgentAgent#llm_selection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiAgentAgent.GenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection\"}", isOptional: true)]
        public oci.GenerativeAiAgentAgent.IGenerativeAiAgentAgentLlmConfigRoutingLlmCustomizationLlmSelection? LlmSelection
        {
            get;
            set;
        }
    }
}
