using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration")]
    public interface IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration
    {
        /// <summary>query_engine_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#query_engine_configuration BedrockagentKnowledgeBase#query_engine_configuration}
        /// </remarks>
        [JsiiProperty(name: "queryEngineConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryEngineConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_generation_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#query_generation_configuration BedrockagentKnowledgeBase#query_generation_configuration}
        /// </remarks>
        [JsiiProperty(name: "queryGenerationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryGenerationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#storage_configuration BedrockagentKnowledgeBase#storage_configuration}
        /// </remarks>
        [JsiiProperty(name: "storageConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>query_engine_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#query_engine_configuration BedrockagentKnowledgeBase#query_engine_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryEngineConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryEngineConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryEngineConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_generation_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#query_generation_configuration BedrockagentKnowledgeBase#query_generation_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryGenerationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationQueryGenerationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryGenerationConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#storage_configuration BedrockagentKnowledgeBase#storage_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfigurationRedshiftConfigurationStorageConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
