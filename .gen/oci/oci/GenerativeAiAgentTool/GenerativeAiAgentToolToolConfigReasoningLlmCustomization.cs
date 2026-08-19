using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiByValue(fqn: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomization")]
    public class GenerativeAiAgentToolToolConfigReasoningLlmCustomization : oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_agent_tool#instruction GenerativeAiAgentTool#instruction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Instruction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_agent_tool#llm_hyper_parameters GenerativeAiAgentTool#llm_hyper_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "llmHyperParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? LlmHyperParameters
        {
            get;
            set;
        }

        /// <summary>llm_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_agent_tool#llm_selection GenerativeAiAgentTool#llm_selection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "llmSelection", typeJson: "{\"fqn\":\"oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection\"}", isOptional: true)]
        public oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigReasoningLlmCustomizationLlmSelection? LlmSelection
        {
            get;
            set;
        }
    }
}
