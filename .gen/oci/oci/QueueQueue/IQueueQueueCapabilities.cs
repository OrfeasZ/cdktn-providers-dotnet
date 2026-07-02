using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.QueueQueue
{
    [JsiiInterface(nativeType: typeof(IQueueQueueCapabilities), fullyQualifiedName: "oci.queueQueue.QueueQueueCapabilities")]
    public interface IQueueQueueCapabilities
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/queue_queue#is_primary_consumer_group_enabled QueueQueue#is_primary_consumer_group_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isPrimaryConsumerGroupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsPrimaryConsumerGroupEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/queue_queue#primary_consumer_group_dead_letter_queue_delivery_count QueueQueue#primary_consumer_group_dead_letter_queue_delivery_count}.</summary>
        [JsiiProperty(name: "primaryConsumerGroupDeadLetterQueueDeliveryCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PrimaryConsumerGroupDeadLetterQueueDeliveryCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/queue_queue#primary_consumer_group_display_name QueueQueue#primary_consumer_group_display_name}.</summary>
        [JsiiProperty(name: "primaryConsumerGroupDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryConsumerGroupDisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/queue_queue#primary_consumer_group_filter QueueQueue#primary_consumer_group_filter}.</summary>
        [JsiiProperty(name: "primaryConsumerGroupFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryConsumerGroupFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/queue_queue#type QueueQueue#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQueueQueueCapabilities), fullyQualifiedName: "oci.queueQueue.QueueQueueCapabilities")]
        internal sealed class _Proxy : DeputyBase, oci.QueueQueue.IQueueQueueCapabilities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/queue_queue#is_primary_consumer_group_enabled QueueQueue#is_primary_consumer_group_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isPrimaryConsumerGroupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsPrimaryConsumerGroupEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/queue_queue#primary_consumer_group_dead_letter_queue_delivery_count QueueQueue#primary_consumer_group_dead_letter_queue_delivery_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryConsumerGroupDeadLetterQueueDeliveryCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PrimaryConsumerGroupDeadLetterQueueDeliveryCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/queue_queue#primary_consumer_group_display_name QueueQueue#primary_consumer_group_display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryConsumerGroupDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryConsumerGroupDisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/queue_queue#primary_consumer_group_filter QueueQueue#primary_consumer_group_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryConsumerGroupFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryConsumerGroupFilter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/queue_queue#type QueueQueue#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
