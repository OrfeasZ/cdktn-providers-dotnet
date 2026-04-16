using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration")]
    public class BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration : aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#domain_arn BedrockagentKnowledgeBase#domain_arn}.</summary>
        [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#domain_endpoint BedrockagentKnowledgeBase#domain_endpoint}.</summary>
        [JsiiProperty(name: "domainEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#vector_index_name BedrockagentKnowledgeBase#vector_index_name}.</summary>
        [JsiiProperty(name: "vectorIndexName", typeJson: "{\"primitive\":\"string\"}")]
        public string VectorIndexName
        {
            get;
            set;
        }

        private object? _fieldMapping;

        /// <summary>field_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#field_mapping BedrockagentKnowledgeBase#field_mapping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FieldMapping
        {
            get => _fieldMapping;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fieldMapping = value;
            }
        }
    }
}
