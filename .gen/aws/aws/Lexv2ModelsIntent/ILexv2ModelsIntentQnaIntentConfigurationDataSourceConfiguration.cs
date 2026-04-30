using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiInterface(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration")]
    public interface ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration
    {
        /// <summary>bedrock_knowledge_store_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#bedrock_knowledge_store_configuration Lexv2ModelsIntent#bedrock_knowledge_store_configuration}
        /// </remarks>
        [JsiiProperty(name: "bedrockKnowledgeStoreConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BedrockKnowledgeStoreConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>kendra_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#kendra_configuration Lexv2ModelsIntent#kendra_configuration}
        /// </remarks>
        [JsiiProperty(name: "kendraConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationKendraConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KendraConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>opensearch_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#opensearch_configuration Lexv2ModelsIntent#opensearch_configuration}
        /// </remarks>
        [JsiiProperty(name: "opensearchConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpensearchConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration), fullyQualifiedName: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bedrock_knowledge_store_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#bedrock_knowledge_store_configuration Lexv2ModelsIntent#bedrock_knowledge_store_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bedrockKnowledgeStoreConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BedrockKnowledgeStoreConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>kendra_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#kendra_configuration Lexv2ModelsIntent#kendra_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kendraConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationKendraConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KendraConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>opensearch_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lexv2models_intent#opensearch_configuration Lexv2ModelsIntent#opensearch_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "opensearchConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OpensearchConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
