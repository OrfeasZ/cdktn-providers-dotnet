using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Queue
{
    [JsiiByValue(fqn: "cloudflare.queue.QueueSettings")]
    public class QueueSettings : cloudflare.Queue.IQueueSettings
    {
        /// <summary>Number of seconds to delay delivery of all messages to consumers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue#delivery_delay Queue#delivery_delay}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deliveryDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeliveryDelay
        {
            get;
            set;
        }

        private object? _deliveryPaused;

        /// <summary>Indicates if message delivery to consumers is currently paused.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue#delivery_paused Queue#delivery_paused}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deliveryPaused", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DeliveryPaused
        {
            get => _deliveryPaused;
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
                _deliveryPaused = value;
            }
        }

        /// <summary>Number of seconds after which an unconsumed message will be delayed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue#message_retention_period Queue#message_retention_period}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "messageRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MessageRetentionPeriod
        {
            get;
            set;
        }
    }
}
