using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping")]
    public class BedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping : aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfigurationFieldMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#metadata_field BedrockagentKnowledgeBase#metadata_field}.</summary>
        [JsiiProperty(name: "metadataField", typeJson: "{\"primitive\":\"string\"}")]
        public string MetadataField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#text_field BedrockagentKnowledgeBase#text_field}.</summary>
        [JsiiProperty(name: "textField", typeJson: "{\"primitive\":\"string\"}")]
        public string TextField
        {
            get;
            set;
        }
    }
}
