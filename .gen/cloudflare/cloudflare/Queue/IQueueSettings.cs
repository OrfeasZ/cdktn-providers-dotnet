using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Queue
{
    [JsiiInterface(nativeType: typeof(IQueueSettings), fullyQualifiedName: "cloudflare.queue.QueueSettings")]
    public interface IQueueSettings
    {
        /// <summary>Number of seconds to delay delivery of all messages to consumers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue#delivery_delay Queue#delivery_delay}
        /// </remarks>
        [JsiiProperty(name: "deliveryDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeliveryDelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if message delivery to consumers is currently paused.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue#delivery_paused Queue#delivery_paused}
        /// </remarks>
        [JsiiProperty(name: "deliveryPaused", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeliveryPaused
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of seconds after which an unconsumed message will be delayed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue#message_retention_period Queue#message_retention_period}
        /// </remarks>
        [JsiiProperty(name: "messageRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MessageRetentionPeriod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQueueSettings), fullyQualifiedName: "cloudflare.queue.QueueSettings")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Queue.IQueueSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of seconds to delay delivery of all messages to consumers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue#delivery_delay Queue#delivery_delay}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeliveryDelay
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Indicates if message delivery to consumers is currently paused.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue#delivery_paused Queue#delivery_paused}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryPaused", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DeliveryPaused
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Number of seconds after which an unconsumed message will be delayed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/queue#message_retention_period Queue#message_retention_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "messageRetentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MessageRetentionPeriod
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
