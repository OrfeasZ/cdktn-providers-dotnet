using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration")]
    public class Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration : aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfiguration
    {
        private object? _bedrockKnowledgeStoreConfiguration;

        /// <summary>bedrock_knowledge_store_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#bedrock_knowledge_store_configuration Lexv2ModelsIntent#bedrock_knowledge_store_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bedrockKnowledgeStoreConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BedrockKnowledgeStoreConfiguration
        {
            get => _bedrockKnowledgeStoreConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationBedrockKnowledgeStoreConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bedrockKnowledgeStoreConfiguration = value;
            }
        }

        private object? _kendraConfiguration;

        /// <summary>kendra_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#kendra_configuration Lexv2ModelsIntent#kendra_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kendraConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationKendraConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KendraConfiguration
        {
            get => _kendraConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationKendraConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationKendraConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _kendraConfiguration = value;
            }
        }

        private object? _opensearchConfiguration;

        /// <summary>opensearch_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/lexv2models_intent#opensearch_configuration Lexv2ModelsIntent#opensearch_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "opensearchConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OpensearchConfiguration
        {
            get => _opensearchConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentQnaIntentConfigurationDataSourceConfigurationOpensearchConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _opensearchConfiguration = value;
            }
        }
    }
}
