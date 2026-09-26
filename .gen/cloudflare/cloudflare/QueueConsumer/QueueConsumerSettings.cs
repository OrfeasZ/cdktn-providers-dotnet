using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.QueueConsumer
{
    [JsiiByValue(fqn: "cloudflare.queueConsumer.QueueConsumerSettings")]
    public class QueueConsumerSettings : cloudflare.QueueConsumer.IQueueConsumerSettings
    {
        /// <summary>The maximum number of messages to include in a batch.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#batch_size QueueConsumer#batch_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchSize
        {
            get;
            set;
        }

        private object? _email;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#email QueueConsumer#email}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.QueueConsumer.IQueueConsumerSettingsEmail" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.queueConsumer.QueueConsumerSettingsEmail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Email
        {
            get => _email;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.QueueConsumer.IQueueConsumerSettingsEmail[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.QueueConsumer.IQueueConsumerSettingsEmail).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _email = value;
            }
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
            get;
            set;
        }

        /// <summary>The maximum number of retries.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#max_retries QueueConsumer#max_retries}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRetries
        {
            get;
            set;
        }

        /// <summary>The number of milliseconds to wait for a batch to fill up before attempting to deliver it.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#max_wait_time_ms QueueConsumer#max_wait_time_ms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxWaitTimeMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxWaitTimeMs
        {
            get;
            set;
        }

        private object? _pagerduty;

        /// <summary>PagerDuty notification destinations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#pagerduty QueueConsumer#pagerduty}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.QueueConsumer.IQueueConsumerSettingsPagerduty" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pagerduty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.queueConsumer.QueueConsumerSettingsPagerduty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Pagerduty
        {
            get => _pagerduty;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.QueueConsumer.IQueueConsumerSettingsPagerduty[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.QueueConsumer.IQueueConsumerSettingsPagerduty).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pagerduty = value;
            }
        }

        /// <summary>The number of seconds to delay before making the message available for another attempt.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#retry_delay QueueConsumer#retry_delay}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetryDelay
        {
            get;
            set;
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
            get;
            set;
        }

        private object? _webhooks;

        /// <summary>Webhook notification destinations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/queue_consumer#webhooks QueueConsumer#webhooks}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.QueueConsumer.IQueueConsumerSettingsWebhooks" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webhooks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.queueConsumer.QueueConsumerSettingsWebhooks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Webhooks
        {
            get => _webhooks;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.QueueConsumer.IQueueConsumerSettingsWebhooks[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.QueueConsumer.IQueueConsumerSettingsWebhooks).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _webhooks = value;
            }
        }
    }
}
