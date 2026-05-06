using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentKnowledgeBase
{
    [JsiiByValue(fqn: "oci.generativeAiAgentKnowledgeBase.GenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctions")]
    public class GenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctions : oci.GenerativeAiAgentKnowledgeBase.IGenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#name GenerativeAiAgentKnowledgeBase#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
