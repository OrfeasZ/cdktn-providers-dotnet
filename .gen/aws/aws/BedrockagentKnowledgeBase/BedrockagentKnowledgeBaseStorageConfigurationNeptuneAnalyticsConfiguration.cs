using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfiguration")]
    public class BedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfiguration : aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#graph_arn BedrockagentKnowledgeBase#graph_arn}.</summary>
        [JsiiProperty(name: "graphArn", typeJson: "{\"primitive\":\"string\"}")]
        public string GraphArn
        {
            get;
            set;
        }

        private object? _fieldMapping;

        /// <summary>field_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#field_mapping BedrockagentKnowledgeBase#field_mapping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fieldMapping = value;
            }
        }
    }
}
