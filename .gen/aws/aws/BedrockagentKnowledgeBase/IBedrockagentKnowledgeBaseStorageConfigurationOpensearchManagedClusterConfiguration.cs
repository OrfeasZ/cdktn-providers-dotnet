using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration")]
    public interface IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#domain_arn BedrockagentKnowledgeBase#domain_arn}.</summary>
        [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
        string DomainArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#domain_endpoint BedrockagentKnowledgeBase#domain_endpoint}.</summary>
        [JsiiProperty(name: "domainEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string DomainEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#vector_index_name BedrockagentKnowledgeBase#vector_index_name}.</summary>
        [JsiiProperty(name: "vectorIndexName", typeJson: "{\"primitive\":\"string\"}")]
        string VectorIndexName
        {
            get;
        }

        /// <summary>field_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#field_mapping BedrockagentKnowledgeBase#field_mapping}
        /// </remarks>
        [JsiiProperty(name: "fieldMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FieldMapping
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#domain_arn BedrockagentKnowledgeBase#domain_arn}.</summary>
            [JsiiProperty(name: "domainArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#domain_endpoint BedrockagentKnowledgeBase#domain_endpoint}.</summary>
            [JsiiProperty(name: "domainEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#vector_index_name BedrockagentKnowledgeBase#vector_index_name}.</summary>
            [JsiiProperty(name: "vectorIndexName", typeJson: "{\"primitive\":\"string\"}")]
            public string VectorIndexName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>field_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#field_mapping BedrockagentKnowledgeBase#field_mapping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldMapping", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfigurationFieldMapping\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FieldMapping
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
