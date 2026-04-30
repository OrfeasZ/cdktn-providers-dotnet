using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfiguration")]
    public class BedrockagentKnowledgeBaseKnowledgeBaseConfiguration : aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#type BedrockagentKnowledgeBase#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _kendraKnowledgeBaseConfiguration;

        /// <summary>kendra_knowledge_base_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#kendra_knowledge_base_configuration BedrockagentKnowledgeBase#kendra_knowledge_base_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kendraKnowledgeBaseConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KendraKnowledgeBaseConfiguration
        {
            get => _kendraKnowledgeBaseConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _kendraKnowledgeBaseConfiguration = value;
            }
        }

        private object? _sqlKnowledgeBaseConfiguration;

        /// <summary>sql_knowledge_base_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#sql_knowledge_base_configuration BedrockagentKnowledgeBase#sql_knowledge_base_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqlKnowledgeBaseConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SqlKnowledgeBaseConfiguration
        {
            get => _sqlKnowledgeBaseConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sqlKnowledgeBaseConfiguration = value;
            }
        }

        private object? _vectorKnowledgeBaseConfiguration;

        /// <summary>vector_knowledge_base_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#vector_knowledge_base_configuration BedrockagentKnowledgeBase#vector_knowledge_base_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vectorKnowledgeBaseConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VectorKnowledgeBaseConfiguration
        {
            get => _vectorKnowledgeBaseConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vectorKnowledgeBaseConfiguration = value;
            }
        }
    }
}
