using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseKafkaTopic
{
    [JsiiInterface(nativeType: typeof(IDatabaseKafkaTopicConfigA), fullyQualifiedName: "digitalocean.databaseKafkaTopic.DatabaseKafkaTopicConfigA")]
    public interface IDatabaseKafkaTopicConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#cleanup_policy DatabaseKafkaTopic#cleanup_policy}.</summary>
        [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CleanupPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#compression_type DatabaseKafkaTopic#compression_type}.</summary>
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompressionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#delete_retention_ms DatabaseKafkaTopic#delete_retention_ms}.</summary>
        [JsiiProperty(name: "deleteRetentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeleteRetentionMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#file_delete_delay_ms DatabaseKafkaTopic#file_delete_delay_ms}.</summary>
        [JsiiProperty(name: "fileDeleteDelayMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileDeleteDelayMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#flush_messages DatabaseKafkaTopic#flush_messages}.</summary>
        [JsiiProperty(name: "flushMessages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FlushMessages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#flush_ms DatabaseKafkaTopic#flush_ms}.</summary>
        [JsiiProperty(name: "flushMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FlushMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#index_interval_bytes DatabaseKafkaTopic#index_interval_bytes}.</summary>
        [JsiiProperty(name: "indexIntervalBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndexIntervalBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#max_compaction_lag_ms DatabaseKafkaTopic#max_compaction_lag_ms}.</summary>
        [JsiiProperty(name: "maxCompactionLagMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxCompactionLagMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#max_message_bytes DatabaseKafkaTopic#max_message_bytes}.</summary>
        [JsiiProperty(name: "maxMessageBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxMessageBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#message_down_conversion_enable DatabaseKafkaTopic#message_down_conversion_enable}.</summary>
        [JsiiProperty(name: "messageDownConversionEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MessageDownConversionEnable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#message_format_version DatabaseKafkaTopic#message_format_version}.</summary>
        [JsiiProperty(name: "messageFormatVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageFormatVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#message_timestamp_difference_max_ms DatabaseKafkaTopic#message_timestamp_difference_max_ms}.</summary>
        [JsiiProperty(name: "messageTimestampDifferenceMaxMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageTimestampDifferenceMaxMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#message_timestamp_type DatabaseKafkaTopic#message_timestamp_type}.</summary>
        [JsiiProperty(name: "messageTimestampType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageTimestampType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#min_cleanable_dirty_ratio DatabaseKafkaTopic#min_cleanable_dirty_ratio}.</summary>
        [JsiiProperty(name: "minCleanableDirtyRatio", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinCleanableDirtyRatio
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#min_compaction_lag_ms DatabaseKafkaTopic#min_compaction_lag_ms}.</summary>
        [JsiiProperty(name: "minCompactionLagMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinCompactionLagMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#min_insync_replicas DatabaseKafkaTopic#min_insync_replicas}.</summary>
        [JsiiProperty(name: "minInsyncReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinInsyncReplicas
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#preallocate DatabaseKafkaTopic#preallocate}.</summary>
        [JsiiProperty(name: "preallocate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Preallocate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#retention_bytes DatabaseKafkaTopic#retention_bytes}.</summary>
        [JsiiProperty(name: "retentionBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RetentionBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#retention_ms DatabaseKafkaTopic#retention_ms}.</summary>
        [JsiiProperty(name: "retentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RetentionMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#segment_bytes DatabaseKafkaTopic#segment_bytes}.</summary>
        [JsiiProperty(name: "segmentBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SegmentBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#segment_index_bytes DatabaseKafkaTopic#segment_index_bytes}.</summary>
        [JsiiProperty(name: "segmentIndexBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SegmentIndexBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#segment_jitter_ms DatabaseKafkaTopic#segment_jitter_ms}.</summary>
        [JsiiProperty(name: "segmentJitterMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SegmentJitterMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#segment_ms DatabaseKafkaTopic#segment_ms}.</summary>
        [JsiiProperty(name: "segmentMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SegmentMs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseKafkaTopicConfigA), fullyQualifiedName: "digitalocean.databaseKafkaTopic.DatabaseKafkaTopicConfigA")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DatabaseKafkaTopic.IDatabaseKafkaTopicConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#cleanup_policy DatabaseKafkaTopic#cleanup_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CleanupPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#compression_type DatabaseKafkaTopic#compression_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompressionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#delete_retention_ms DatabaseKafkaTopic#delete_retention_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteRetentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeleteRetentionMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#file_delete_delay_ms DatabaseKafkaTopic#file_delete_delay_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileDeleteDelayMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileDeleteDelayMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#flush_messages DatabaseKafkaTopic#flush_messages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "flushMessages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FlushMessages
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#flush_ms DatabaseKafkaTopic#flush_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "flushMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FlushMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#index_interval_bytes DatabaseKafkaTopic#index_interval_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "indexIntervalBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndexIntervalBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#max_compaction_lag_ms DatabaseKafkaTopic#max_compaction_lag_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCompactionLagMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxCompactionLagMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#max_message_bytes DatabaseKafkaTopic#max_message_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxMessageBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxMessageBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#message_down_conversion_enable DatabaseKafkaTopic#message_down_conversion_enable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageDownConversionEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MessageDownConversionEnable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#message_format_version DatabaseKafkaTopic#message_format_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageFormatVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageFormatVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#message_timestamp_difference_max_ms DatabaseKafkaTopic#message_timestamp_difference_max_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageTimestampDifferenceMaxMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageTimestampDifferenceMaxMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#message_timestamp_type DatabaseKafkaTopic#message_timestamp_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageTimestampType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageTimestampType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#min_cleanable_dirty_ratio DatabaseKafkaTopic#min_cleanable_dirty_ratio}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minCleanableDirtyRatio", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinCleanableDirtyRatio
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#min_compaction_lag_ms DatabaseKafkaTopic#min_compaction_lag_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minCompactionLagMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinCompactionLagMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#min_insync_replicas DatabaseKafkaTopic#min_insync_replicas}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minInsyncReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinInsyncReplicas
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#preallocate DatabaseKafkaTopic#preallocate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preallocate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Preallocate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#retention_bytes DatabaseKafkaTopic#retention_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RetentionBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#retention_ms DatabaseKafkaTopic#retention_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RetentionMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#segment_bytes DatabaseKafkaTopic#segment_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "segmentBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SegmentBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#segment_index_bytes DatabaseKafkaTopic#segment_index_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "segmentIndexBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SegmentIndexBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#segment_jitter_ms DatabaseKafkaTopic#segment_jitter_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "segmentJitterMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SegmentJitterMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/database_kafka_topic#segment_ms DatabaseKafkaTopic#segment_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "segmentMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SegmentMs
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
