using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping")]
    public interface IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#metadata_field BedrockagentKnowledgeBase#metadata_field}.</summary>
        [JsiiProperty(name: "metadataField", typeJson: "{\"primitive\":\"string\"}")]
        string MetadataField
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#text_field BedrockagentKnowledgeBase#text_field}.</summary>
        [JsiiProperty(name: "textField", typeJson: "{\"primitive\":\"string\"}")]
        string TextField
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#vector_field BedrockagentKnowledgeBase#vector_field}.</summary>
        [JsiiProperty(name: "vectorField", typeJson: "{\"primitive\":\"string\"}")]
        string VectorField
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#metadata_field BedrockagentKnowledgeBase#metadata_field}.</summary>
            [JsiiProperty(name: "metadataField", typeJson: "{\"primitive\":\"string\"}")]
            public string MetadataField
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#text_field BedrockagentKnowledgeBase#text_field}.</summary>
            [JsiiProperty(name: "textField", typeJson: "{\"primitive\":\"string\"}")]
            public string TextField
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/bedrockagent_knowledge_base#vector_field BedrockagentKnowledgeBase#vector_field}.</summary>
            [JsiiProperty(name: "vectorField", typeJson: "{\"primitive\":\"string\"}")]
            public string VectorField
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
