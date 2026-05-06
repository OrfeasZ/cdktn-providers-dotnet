using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiByValue(fqn: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigKnowledgeBaseConfigs")]
    public class GenerativeAiAgentToolToolConfigKnowledgeBaseConfigs : oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigKnowledgeBaseConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#knowledge_base_id GenerativeAiAgentTool#knowledge_base_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "knowledgeBaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KnowledgeBaseId
        {
            get;
            set;
        }
    }
}
