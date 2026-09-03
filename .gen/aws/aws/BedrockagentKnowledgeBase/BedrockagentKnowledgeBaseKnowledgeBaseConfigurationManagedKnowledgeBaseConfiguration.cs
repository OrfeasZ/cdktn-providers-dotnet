using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    [JsiiByValue(fqn: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfiguration")]
    public class BedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfiguration : aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#embedding_model_arn BedrockagentKnowledgeBase#embedding_model_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "embeddingModelArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmbeddingModelArn
        {
            get;
            set;
        }

        private object? _embeddingModelConfiguration;

        /// <summary>embedding_model_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#embedding_model_configuration BedrockagentKnowledgeBase#embedding_model_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "embeddingModelConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EmbeddingModelConfiguration
        {
            get => _embeddingModelConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationEmbeddingModelConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _embeddingModelConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#embedding_model_type BedrockagentKnowledgeBase#embedding_model_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "embeddingModelType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmbeddingModelType
        {
            get;
            set;
        }

        private object? _serverSideEncryptionConfiguration;

        /// <summary>server_side_encryption_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagent_knowledge_base#server_side_encryption_configuration BedrockagentKnowledgeBase#server_side_encryption_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ServerSideEncryptionConfiguration
        {
            get => _serverSideEncryptionConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationManagedKnowledgeBaseConfigurationServerSideEncryptionConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serverSideEncryptionConfiguration = value;
            }
        }
    }
}
