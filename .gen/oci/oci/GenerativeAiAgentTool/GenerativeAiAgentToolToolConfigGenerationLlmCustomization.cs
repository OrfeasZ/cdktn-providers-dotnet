using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiByValue(fqn: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigGenerationLlmCustomization")]
    public class GenerativeAiAgentToolToolConfigGenerationLlmCustomization : oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigGenerationLlmCustomization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#instruction GenerativeAiAgentTool#instruction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instruction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Instruction
        {
            get;
            set;
        }
    }
}
