using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.QueueQueue
{
    [JsiiByValue(fqn: "oci.queueQueue.QueueQueueCapabilities")]
    public class QueueQueueCapabilities : oci.QueueQueue.IQueueQueueCapabilities
    {
        private object? _isPrimaryConsumerGroupEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/queue_queue#is_primary_consumer_group_enabled QueueQueue#is_primary_consumer_group_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isPrimaryConsumerGroupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsPrimaryConsumerGroupEnabled
        {
            get => _isPrimaryConsumerGroupEnabled;
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
                _isPrimaryConsumerGroupEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/queue_queue#primary_consumer_group_dead_letter_queue_delivery_count QueueQueue#primary_consumer_group_dead_letter_queue_delivery_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryConsumerGroupDeadLetterQueueDeliveryCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PrimaryConsumerGroupDeadLetterQueueDeliveryCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/queue_queue#primary_consumer_group_display_name QueueQueue#primary_consumer_group_display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryConsumerGroupDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryConsumerGroupDisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/queue_queue#primary_consumer_group_filter QueueQueue#primary_consumer_group_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryConsumerGroupFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryConsumerGroupFilter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/queue_queue#type QueueQueue#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
