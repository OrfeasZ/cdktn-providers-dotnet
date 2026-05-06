using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctions), fullyQualifiedName: "oci.generativeAiAgentKnowledgeBase.GenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctions")]
    public interface IGenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#name GenerativeAiAgentKnowledgeBase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctions), fullyQualifiedName: "oci.generativeAiAgentKnowledgeBase.GenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctions")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentKnowledgeBase.IGenerativeAiAgentKnowledgeBaseIndexConfigDatabaseFunctions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#name GenerativeAiAgentKnowledgeBase#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
