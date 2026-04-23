using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IBedrockagentKnowledgeBaseKnowledgeBaseConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfiguration")]
    public interface IBedrockagentKnowledgeBaseKnowledgeBaseConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#type BedrockagentKnowledgeBase#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>kendra_knowledge_base_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#kendra_knowledge_base_configuration BedrockagentKnowledgeBase#kendra_knowledge_base_configuration}
        /// </remarks>
        [JsiiProperty(name: "kendraKnowledgeBaseConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KendraKnowledgeBaseConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>sql_knowledge_base_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#sql_knowledge_base_configuration BedrockagentKnowledgeBase#sql_knowledge_base_configuration}
        /// </remarks>
        [JsiiProperty(name: "sqlKnowledgeBaseConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SqlKnowledgeBaseConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>vector_knowledge_base_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#vector_knowledge_base_configuration BedrockagentKnowledgeBase#vector_knowledge_base_configuration}
        /// </remarks>
        [JsiiProperty(name: "vectorKnowledgeBaseConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VectorKnowledgeBaseConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentKnowledgeBaseKnowledgeBaseConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#type BedrockagentKnowledgeBase#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>kendra_knowledge_base_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#kendra_knowledge_base_configuration BedrockagentKnowledgeBase#kendra_knowledge_base_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kendraKnowledgeBaseConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KendraKnowledgeBaseConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sql_knowledge_base_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#sql_knowledge_base_configuration BedrockagentKnowledgeBase#sql_knowledge_base_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqlKnowledgeBaseConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SqlKnowledgeBaseConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>vector_knowledge_base_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#vector_knowledge_base_configuration BedrockagentKnowledgeBase#vector_knowledge_base_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vectorKnowledgeBaseConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VectorKnowledgeBaseConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
