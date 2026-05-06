using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema), fullyQualifiedName: "oci.generativeAiAgentKnowledgeBase.GenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema")]
    public interface IGenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#body_key GenerativeAiAgentKnowledgeBase#body_key}.</summary>
        [JsiiProperty(name: "bodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BodyKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#embedding_body_key GenerativeAiAgentKnowledgeBase#embedding_body_key}.</summary>
        [JsiiProperty(name: "embeddingBodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmbeddingBodyKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#title_key GenerativeAiAgentKnowledgeBase#title_key}.</summary>
        [JsiiProperty(name: "titleKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TitleKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#url_key GenerativeAiAgentKnowledgeBase#url_key}.</summary>
        [JsiiProperty(name: "urlKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UrlKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema), fullyQualifiedName: "oci.generativeAiAgentKnowledgeBase.GenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentKnowledgeBase.IGenerativeAiAgentKnowledgeBaseIndexConfigIndexesSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#body_key GenerativeAiAgentKnowledgeBase#body_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BodyKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#embedding_body_key GenerativeAiAgentKnowledgeBase#embedding_body_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "embeddingBodyKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmbeddingBodyKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#title_key GenerativeAiAgentKnowledgeBase#title_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "titleKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TitleKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#url_key GenerativeAiAgentKnowledgeBase#url_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "urlKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UrlKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
