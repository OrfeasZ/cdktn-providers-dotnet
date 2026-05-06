using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentTool
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentToolToolConfigKnowledgeBaseConfigs), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigKnowledgeBaseConfigs")]
    public interface IGenerativeAiAgentToolToolConfigKnowledgeBaseConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#knowledge_base_id GenerativeAiAgentTool#knowledge_base_id}.</summary>
        [JsiiProperty(name: "knowledgeBaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KnowledgeBaseId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentToolToolConfigKnowledgeBaseConfigs), fullyQualifiedName: "oci.generativeAiAgentTool.GenerativeAiAgentToolToolConfigKnowledgeBaseConfigs")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentTool.IGenerativeAiAgentToolToolConfigKnowledgeBaseConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_tool#knowledge_base_id GenerativeAiAgentTool#knowledge_base_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "knowledgeBaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KnowledgeBaseId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
