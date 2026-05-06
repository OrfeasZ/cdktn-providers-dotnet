using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StreamingStreamPool
{
    [JsiiInterface(nativeType: typeof(IStreamingStreamPoolKafkaSettings), fullyQualifiedName: "oci.streamingStreamPool.StreamingStreamPoolKafkaSettings")]
    public interface IStreamingStreamPoolKafkaSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#auto_create_topics_enable StreamingStreamPool#auto_create_topics_enable}.</summary>
        [JsiiProperty(name: "autoCreateTopicsEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoCreateTopicsEnable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#log_retention_hours StreamingStreamPool#log_retention_hours}.</summary>
        [JsiiProperty(name: "logRetentionHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LogRetentionHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#num_partitions StreamingStreamPool#num_partitions}.</summary>
        [JsiiProperty(name: "numPartitions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumPartitions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStreamingStreamPoolKafkaSettings), fullyQualifiedName: "oci.streamingStreamPool.StreamingStreamPoolKafkaSettings")]
        internal sealed class _Proxy : DeputyBase, oci.StreamingStreamPool.IStreamingStreamPoolKafkaSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#auto_create_topics_enable StreamingStreamPool#auto_create_topics_enable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoCreateTopicsEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoCreateTopicsEnable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#log_retention_hours StreamingStreamPool#log_retention_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logRetentionHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LogRetentionHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#num_partitions StreamingStreamPool#num_partitions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numPartitions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumPartitions
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
