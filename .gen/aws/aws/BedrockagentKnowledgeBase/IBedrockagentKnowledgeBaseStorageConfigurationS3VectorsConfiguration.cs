using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IBedrockagentKnowledgeBaseStorageConfigurationS3VectorsConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationS3VectorsConfiguration")]
    public interface IBedrockagentKnowledgeBaseStorageConfigurationS3VectorsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#index_arn BedrockagentKnowledgeBase#index_arn}.</summary>
        [JsiiProperty(name: "indexArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndexArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#index_name BedrockagentKnowledgeBase#index_name}.</summary>
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndexName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#vector_bucket_arn BedrockagentKnowledgeBase#vector_bucket_arn}.</summary>
        [JsiiProperty(name: "vectorBucketArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VectorBucketArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentKnowledgeBaseStorageConfigurationS3VectorsConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationS3VectorsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationS3VectorsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#index_arn BedrockagentKnowledgeBase#index_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indexArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndexArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#index_name BedrockagentKnowledgeBase#index_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndexName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagent_knowledge_base#vector_bucket_arn BedrockagentKnowledgeBase#vector_bucket_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vectorBucketArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VectorBucketArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
