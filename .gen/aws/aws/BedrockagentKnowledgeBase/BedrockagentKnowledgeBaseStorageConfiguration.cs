using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentKnowledgeBase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfiguration")]
    public class BedrockagentKnowledgeBaseStorageConfiguration : aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#type BedrockagentKnowledgeBase#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _mongoDbAtlasConfiguration;

        /// <summary>mongo_db_atlas_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#mongo_db_atlas_configuration BedrockagentKnowledgeBase#mongo_db_atlas_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mongoDbAtlasConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationMongoDbAtlasConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MongoDbAtlasConfiguration
        {
            get => _mongoDbAtlasConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationMongoDbAtlasConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationMongoDbAtlasConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mongoDbAtlasConfiguration = value;
            }
        }

        private object? _neptuneAnalyticsConfiguration;

        /// <summary>neptune_analytics_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#neptune_analytics_configuration BedrockagentKnowledgeBase#neptune_analytics_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "neptuneAnalyticsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NeptuneAnalyticsConfiguration
        {
            get => _neptuneAnalyticsConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationNeptuneAnalyticsConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _neptuneAnalyticsConfiguration = value;
            }
        }

        private object? _opensearchManagedClusterConfiguration;

        /// <summary>opensearch_managed_cluster_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#opensearch_managed_cluster_configuration BedrockagentKnowledgeBase#opensearch_managed_cluster_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "opensearchManagedClusterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OpensearchManagedClusterConfiguration
        {
            get => _opensearchManagedClusterConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationOpensearchManagedClusterConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _opensearchManagedClusterConfiguration = value;
            }
        }

        private object? _opensearchServerlessConfiguration;

        /// <summary>opensearch_serverless_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#opensearch_serverless_configuration BedrockagentKnowledgeBase#opensearch_serverless_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "opensearchServerlessConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationOpensearchServerlessConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OpensearchServerlessConfiguration
        {
            get => _opensearchServerlessConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationOpensearchServerlessConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationOpensearchServerlessConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _opensearchServerlessConfiguration = value;
            }
        }

        private object? _pineconeConfiguration;

        /// <summary>pinecone_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#pinecone_configuration BedrockagentKnowledgeBase#pinecone_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pineconeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationPineconeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PineconeConfiguration
        {
            get => _pineconeConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationPineconeConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationPineconeConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pineconeConfiguration = value;
            }
        }

        private object? _rdsConfiguration;

        /// <summary>rds_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#rds_configuration BedrockagentKnowledgeBase#rds_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rdsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationRdsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RdsConfiguration
        {
            get => _rdsConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationRdsConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationRdsConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rdsConfiguration = value;
            }
        }

        private object? _redisEnterpriseCloudConfiguration;

        /// <summary>redis_enterprise_cloud_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#redis_enterprise_cloud_configuration BedrockagentKnowledgeBase#redis_enterprise_cloud_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redisEnterpriseCloudConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationRedisEnterpriseCloudConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RedisEnterpriseCloudConfiguration
        {
            get => _redisEnterpriseCloudConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationRedisEnterpriseCloudConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationRedisEnterpriseCloudConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redisEnterpriseCloudConfiguration = value;
            }
        }

        private object? _s3VectorsConfiguration;

        /// <summary>s3_vectors_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagent_knowledge_base#s3_vectors_configuration BedrockagentKnowledgeBase#s3_vectors_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3VectorsConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentKnowledgeBase.BedrockagentKnowledgeBaseStorageConfigurationS3VectorsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3VectorsConfiguration
        {
            get => _s3VectorsConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationS3VectorsConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentKnowledgeBase.IBedrockagentKnowledgeBaseStorageConfigurationS3VectorsConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3VectorsConfiguration = value;
            }
        }
    }
}
