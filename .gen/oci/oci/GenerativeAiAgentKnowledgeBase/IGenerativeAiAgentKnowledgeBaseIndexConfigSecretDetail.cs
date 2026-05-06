using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentKnowledgeBaseIndexConfigSecretDetail), fullyQualifiedName: "oci.generativeAiAgentKnowledgeBase.GenerativeAiAgentKnowledgeBaseIndexConfigSecretDetail")]
    public interface IGenerativeAiAgentKnowledgeBaseIndexConfigSecretDetail
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#type GenerativeAiAgentKnowledgeBase#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#vault_secret_id GenerativeAiAgentKnowledgeBase#vault_secret_id}.</summary>
        [JsiiProperty(name: "vaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string VaultSecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#client_id GenerativeAiAgentKnowledgeBase#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#idcs_url GenerativeAiAgentKnowledgeBase#idcs_url}.</summary>
        [JsiiProperty(name: "idcsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdcsUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#scope_url GenerativeAiAgentKnowledgeBase#scope_url}.</summary>
        [JsiiProperty(name: "scopeUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScopeUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentKnowledgeBaseIndexConfigSecretDetail), fullyQualifiedName: "oci.generativeAiAgentKnowledgeBase.GenerativeAiAgentKnowledgeBaseIndexConfigSecretDetail")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentKnowledgeBase.IGenerativeAiAgentKnowledgeBaseIndexConfigSecretDetail
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#type GenerativeAiAgentKnowledgeBase#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#vault_secret_id GenerativeAiAgentKnowledgeBase#vault_secret_id}.</summary>
            [JsiiProperty(name: "vaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string VaultSecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#client_id GenerativeAiAgentKnowledgeBase#client_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#idcs_url GenerativeAiAgentKnowledgeBase#idcs_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idcsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdcsUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_knowledge_base#scope_url GenerativeAiAgentKnowledgeBase#scope_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scopeUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScopeUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
