using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.QueueConsumer
{
    [JsiiInterface(nativeType: typeof(IQueueConsumerSettings), fullyQualifiedName: "cloudflare.queueConsumer.QueueConsumerSettings")]
    public interface IQueueConsumerSettings
    {
        /// <summary>The maximum number of messages to include in a batch.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#batch_size QueueConsumer#batch_size}
        /// </remarks>
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#email QueueConsumer#email}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.QueueConsumer.IQueueConsumerSettingsEmail" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.queueConsumer.QueueConsumerSettingsEmail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum number of concurrent consumers that may consume from this Queue.</summary>
        /// <remarks>
        /// Set to <c>null</c> to automatically opt in to the platform's maximum (recommended).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#max_concurrency QueueConsumer#max_concurrency}
        /// </remarks>
        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrency
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum number of retries.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#max_retries QueueConsumer#max_retries}
        /// </remarks>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of milliseconds to wait for a batch to fill up before attempting to deliver it.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#max_wait_time_ms QueueConsumer#max_wait_time_ms}
        /// </remarks>
        [JsiiProperty(name: "maxWaitTimeMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxWaitTimeMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>PagerDuty notification destinations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#pagerduty QueueConsumer#pagerduty}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.QueueConsumer.IQueueConsumerSettingsPagerduty" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "pagerduty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.queueConsumer.QueueConsumerSettingsPagerduty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Pagerduty
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of seconds to delay before making the message available for another attempt.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#retry_delay QueueConsumer#retry_delay}
        /// </remarks>
        [JsiiProperty(name: "retryDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryDelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of milliseconds that a message is exclusively leased.</summary>
        /// <remarks>
        /// After the timeout, the message becomes available for another attempt.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#visibility_timeout_ms QueueConsumer#visibility_timeout_ms}
        /// </remarks>
        [JsiiProperty(name: "visibilityTimeoutMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VisibilityTimeoutMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Webhook notification destinations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#webhooks QueueConsumer#webhooks}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.QueueConsumer.IQueueConsumerSettingsWebhooks" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "webhooks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.queueConsumer.QueueConsumerSettingsWebhooks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Webhooks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQueueConsumerSettings), fullyQualifiedName: "cloudflare.queueConsumer.QueueConsumerSettings")]
        internal sealed class _Proxy : DeputyBase, cloudflare.QueueConsumer.IQueueConsumerSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum number of messages to include in a batch.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#batch_size QueueConsumer#batch_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#email QueueConsumer#email}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.QueueConsumer.IQueueConsumerSettingsEmail" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.queueConsumer.QueueConsumerSettingsEmail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Email
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Maximum number of concurrent consumers that may consume from this Queue.</summary>
            /// <remarks>
            /// Set to <c>null</c> to automatically opt in to the platform's maximum (recommended).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#max_concurrency QueueConsumer#max_concurrency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrency
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The maximum number of retries.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#max_retries QueueConsumer#max_retries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRetries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The number of milliseconds to wait for a batch to fill up before attempting to deliver it.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#max_wait_time_ms QueueConsumer#max_wait_time_ms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxWaitTimeMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxWaitTimeMs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>PagerDuty notification destinations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#pagerduty QueueConsumer#pagerduty}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.QueueConsumer.IQueueConsumerSettingsPagerduty" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pagerduty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.queueConsumer.QueueConsumerSettingsPagerduty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Pagerduty
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The number of seconds to delay before making the message available for another attempt.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#retry_delay QueueConsumer#retry_delay}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetryDelay
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The number of milliseconds that a message is exclusively leased.</summary>
            /// <remarks>
            /// After the timeout, the message becomes available for another attempt.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#visibility_timeout_ms QueueConsumer#visibility_timeout_ms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "visibilityTimeoutMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VisibilityTimeoutMs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Webhook notification destinations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#webhooks QueueConsumer#webhooks}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.QueueConsumer.IQueueConsumerSettingsWebhooks" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webhooks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.queueConsumer.QueueConsumerSettingsWebhooks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Webhooks
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
