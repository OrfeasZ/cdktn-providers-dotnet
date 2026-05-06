using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentKnowledgeBase
{
    [JsiiByValue(fqn: "oci.generativeAiAgentKnowledgeBase.GenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema")]
    public class GenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema : oci.GenerativeAiAgentKnowledgeBase.IGenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#body_key GenerativeAiAgentKnowledgeBase#body_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BodyKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#embedding_body_key GenerativeAiAgentKnowledgeBase#embedding_body_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "embeddingBodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmbeddingBodyKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#title_key GenerativeAiAgentKnowledgeBase#title_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "titleKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TitleKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#url_key GenerativeAiAgentKnowledgeBase#url_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "urlKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UrlKey
        {
            get;
            set;
        }
    }
}
