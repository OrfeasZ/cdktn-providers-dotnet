using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorReplicationInfoListStruct), fullyQualifiedName: "aws.mskReplicator.MskReplicatorReplicationInfoListStruct")]
    public interface IMskReplicatorReplicationInfoListStruct
    {
        /// <summary>consumer_group_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#consumer_group_replication MskReplicator#consumer_group_replication}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskReplicator.IMskReplicatorReplicationInfoListConsumerGroupReplication" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "consumerGroupReplication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListConsumerGroupReplication\"},\"kind\":\"array\"}}]}}")]
        object ConsumerGroupReplication
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#target_compression_type MskReplicator#target_compression_type}.</summary>
        [JsiiProperty(name: "targetCompressionType", typeJson: "{\"primitive\":\"string\"}")]
        string TargetCompressionType
        {
            get;
        }

        /// <summary>topic_replication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#topic_replication MskReplicator#topic_replication}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "topicReplication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplication\"},\"kind\":\"array\"}}]}}")]
        object TopicReplication
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#source_kafka_cluster_arn MskReplicator#source_kafka_cluster_arn}.</summary>
        [JsiiProperty(name: "sourceKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceKafkaClusterArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#source_kafka_cluster_id MskReplicator#source_kafka_cluster_id}.</summary>
        [JsiiProperty(name: "sourceKafkaClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceKafkaClusterId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#target_kafka_cluster_arn MskReplicator#target_kafka_cluster_arn}.</summary>
        [JsiiProperty(name: "targetKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetKafkaClusterArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#target_kafka_cluster_id MskReplicator#target_kafka_cluster_id}.</summary>
        [JsiiProperty(name: "targetKafkaClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetKafkaClusterId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorReplicationInfoListStruct), fullyQualifiedName: "aws.mskReplicator.MskReplicatorReplicationInfoListStruct")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorReplicationInfoListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>consumer_group_replication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#consumer_group_replication MskReplicator#consumer_group_replication}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskReplicator.IMskReplicatorReplicationInfoListConsumerGroupReplication" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "consumerGroupReplication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListConsumerGroupReplication\"},\"kind\":\"array\"}}]}}")]
            public object ConsumerGroupReplication
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#target_compression_type MskReplicator#target_compression_type}.</summary>
            [JsiiProperty(name: "targetCompressionType", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetCompressionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>topic_replication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#topic_replication MskReplicator#topic_replication}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplication" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "topicReplication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplication\"},\"kind\":\"array\"}}]}}")]
            public object TopicReplication
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#source_kafka_cluster_arn MskReplicator#source_kafka_cluster_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceKafkaClusterArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#source_kafka_cluster_id MskReplicator#source_kafka_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceKafkaClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceKafkaClusterId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#target_kafka_cluster_arn MskReplicator#target_kafka_cluster_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetKafkaClusterArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetKafkaClusterArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#target_kafka_cluster_id MskReplicator#target_kafka_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetKafkaClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetKafkaClusterId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
