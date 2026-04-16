using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    [JsiiInterface(nativeType: typeof(IBedrockagentKnowledgeBaseStorageConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfiguration")]
    public interface IBedrockagentKnowledgeBaseStorageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#type BedrockagentKnowledgeBase#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>mongo_db_atlas_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#mongo_db_atlas_configuration BedrockagentKnowledgeBase#mongo_db_atlas_configuration}
        /// </remarks>
        [JsiiProperty(name: "mongoDbAtlasConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationMongoDbAtlasConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MongoDbAtlasConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>neptune_analytics_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#neptune_analytics_configuration BedrockagentKnowledgeBase#neptune_analytics_configuration}
        /// </remarks>
        [JsiiProperty(name: "neptuneAnalyticsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NeptuneAnalyticsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>opensearch_managed_cluster_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#opensearch_managed_cluster_configuration BedrockagentKnowledgeBase#opensearch_managed_cluster_configuration}
        /// </remarks>
        [JsiiProperty(name: "opensearchManagedClusterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpensearchManagedClusterConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>opensearch_serverless_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#opensearch_serverless_configuration BedrockagentKnowledgeBase#opensearch_serverless_configuration}
        /// </remarks>
        [JsiiProperty(name: "opensearchServerlessConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchServerlessConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpensearchServerlessConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>pinecone_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#pinecone_configuration BedrockagentKnowledgeBase#pinecone_configuration}
        /// </remarks>
        [JsiiProperty(name: "pineconeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationPineconeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PineconeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>rds_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#rds_configuration BedrockagentKnowledgeBase#rds_configuration}
        /// </remarks>
        [JsiiProperty(name: "rdsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationRdsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RdsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>redis_enterprise_cloud_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#redis_enterprise_cloud_configuration BedrockagentKnowledgeBase#redis_enterprise_cloud_configuration}
        /// </remarks>
        [JsiiProperty(name: "redisEnterpriseCloudConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationRedisEnterpriseCloudConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RedisEnterpriseCloudConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_vectors_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#s3_vectors_configuration BedrockagentKnowledgeBase#s3_vectors_configuration}
        /// </remarks>
        [JsiiProperty(name: "s3VectorsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationS3VectorsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3VectorsConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentKnowledgeBaseStorageConfiguration), fullyQualifiedName: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#type BedrockagentKnowledgeBase#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>mongo_db_atlas_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#mongo_db_atlas_configuration BedrockagentKnowledgeBase#mongo_db_atlas_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mongoDbAtlasConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationMongoDbAtlasConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MongoDbAtlasConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>neptune_analytics_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#neptune_analytics_configuration BedrockagentKnowledgeBase#neptune_analytics_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "neptuneAnalyticsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NeptuneAnalyticsConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>opensearch_managed_cluster_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#opensearch_managed_cluster_configuration BedrockagentKnowledgeBase#opensearch_managed_cluster_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "opensearchManagedClusterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OpensearchManagedClusterConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>opensearch_serverless_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#opensearch_serverless_configuration BedrockagentKnowledgeBase#opensearch_serverless_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "opensearchServerlessConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchServerlessConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OpensearchServerlessConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>pinecone_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#pinecone_configuration BedrockagentKnowledgeBase#pinecone_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pineconeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationPineconeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PineconeConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>rds_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#rds_configuration BedrockagentKnowledgeBase#rds_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rdsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationRdsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RdsConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>redis_enterprise_cloud_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#redis_enterprise_cloud_configuration BedrockagentKnowledgeBase#redis_enterprise_cloud_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redisEnterpriseCloudConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationRedisEnterpriseCloudConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RedisEnterpriseCloudConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>s3_vectors_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#s3_vectors_configuration BedrockagentKnowledgeBase#s3_vectors_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3VectorsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationS3VectorsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3VectorsConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
