using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DatabaseKafkaTopic
{
    [JsiiByValue(fqn: "digitalocean.databaseKafkaTopic.DatabaseKafkaTopicConfigA")]
    public class DatabaseKafkaTopicConfigA : digitalocean.DatabaseKafkaTopic.IDatabaseKafkaTopicConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#cleanup_policy DatabaseKafkaTopic#cleanup_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CleanupPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#compression_type DatabaseKafkaTopic#compression_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompressionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#delete_retention_ms DatabaseKafkaTopic#delete_retention_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteRetentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeleteRetentionMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#file_delete_delay_ms DatabaseKafkaTopic#file_delete_delay_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileDeleteDelayMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileDeleteDelayMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#flush_messages DatabaseKafkaTopic#flush_messages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "flushMessages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FlushMessages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#flush_ms DatabaseKafkaTopic#flush_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "flushMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FlushMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#index_interval_bytes DatabaseKafkaTopic#index_interval_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indexIntervalBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndexIntervalBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#max_compaction_lag_ms DatabaseKafkaTopic#max_compaction_lag_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCompactionLagMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxCompactionLagMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#max_message_bytes DatabaseKafkaTopic#max_message_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxMessageBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxMessageBytes
        {
            get;
            set;
        }

        private object? _messageDownConversionEnable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#message_down_conversion_enable DatabaseKafkaTopic#message_down_conversion_enable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageDownConversionEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? MessageDownConversionEnable
        {
            get => _messageDownConversionEnable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _messageDownConversionEnable = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#message_format_version DatabaseKafkaTopic#message_format_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageFormatVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageFormatVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#message_timestamp_difference_max_ms DatabaseKafkaTopic#message_timestamp_difference_max_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageTimestampDifferenceMaxMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageTimestampDifferenceMaxMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#message_timestamp_type DatabaseKafkaTopic#message_timestamp_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageTimestampType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageTimestampType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#min_cleanable_dirty_ratio DatabaseKafkaTopic#min_cleanable_dirty_ratio}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minCleanableDirtyRatio", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinCleanableDirtyRatio
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#min_compaction_lag_ms DatabaseKafkaTopic#min_compaction_lag_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minCompactionLagMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinCompactionLagMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#min_insync_replicas DatabaseKafkaTopic#min_insync_replicas}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minInsyncReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinInsyncReplicas
        {
            get;
            set;
        }

        private object? _preallocate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#preallocate DatabaseKafkaTopic#preallocate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preallocate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Preallocate
        {
            get => _preallocate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _preallocate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#retention_bytes DatabaseKafkaTopic#retention_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RetentionBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#retention_ms DatabaseKafkaTopic#retention_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RetentionMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#segment_bytes DatabaseKafkaTopic#segment_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SegmentBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#segment_index_bytes DatabaseKafkaTopic#segment_index_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentIndexBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SegmentIndexBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#segment_jitter_ms DatabaseKafkaTopic#segment_jitter_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentJitterMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SegmentJitterMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.85.0/docs/resources/database_kafka_topic#segment_ms DatabaseKafkaTopic#segment_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SegmentMs
        {
            get;
            set;
        }
    }
}
