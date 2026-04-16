using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IBedrockagentKnowledgeBaseStorageConfigurationPineconeConfigurationFieldMapping), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationPineconeConfigurationFieldMapping")]
    public interface IBedrockagentKnowledgeBaseStorageConfigurationPineconeConfigurationFieldMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#metadata_field BedrockagentKnowledgeBase#metadata_field}.</summary>
        [JsiiProperty(name: "metadataField", typeJson: "{\"primitive\":\"string\"}")]
        string MetadataField
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#text_field BedrockagentKnowledgeBase#text_field}.</summary>
        [JsiiProperty(name: "textField", typeJson: "{\"primitive\":\"string\"}")]
        string TextField
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentKnowledgeBaseStorageConfigurationPineconeConfigurationFieldMapping), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationPineconeConfigurationFieldMapping")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationPineconeConfigurationFieldMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#metadata_field BedrockagentKnowledgeBase#metadata_field}.</summary>
            [JsiiProperty(name: "metadataField", typeJson: "{\"primitive\":\"string\"}")]
            public string MetadataField
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#text_field BedrockagentKnowledgeBase#text_field}.</summary>
            [JsiiProperty(name: "textField", typeJson: "{\"primitive\":\"string\"}")]
            public string TextField
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
