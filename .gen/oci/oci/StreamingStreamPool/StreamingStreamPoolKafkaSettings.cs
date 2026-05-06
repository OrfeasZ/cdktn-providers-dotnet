using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StreamingStreamPool
{
    [JsiiByValue(fqn: "oci.streamingStreamPool.StreamingStreamPoolKafkaSettings")]
    public class StreamingStreamPoolKafkaSettings : oci.StreamingStreamPool.IStreamingStreamPoolKafkaSettings
    {
        private object? _autoCreateTopicsEnable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#auto_create_topics_enable StreamingStreamPool#auto_create_topics_enable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoCreateTopicsEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AutoCreateTopicsEnable
        {
            get => _autoCreateTopicsEnable;
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
                _autoCreateTopicsEnable = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#log_retention_hours StreamingStreamPool#log_retention_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logRetentionHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LogRetentionHours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#num_partitions StreamingStreamPool#num_partitions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numPartitions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumPartitions
        {
            get;
            set;
        }
    }
}
