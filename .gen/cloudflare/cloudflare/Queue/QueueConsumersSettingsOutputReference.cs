using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Queue
{
    [JsiiClass(nativeType: typeof(cloudflare.Queue.QueueConsumersSettingsOutputReference), fullyQualifiedName: "cloudflare.queue.QueueConsumersSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QueueConsumersSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QueueConsumersSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QueueConsumersSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QueueConsumersSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.queue.QueueConsumersSettingsEmailList\"}")]
        public virtual cloudflare.Queue.QueueConsumersSettingsEmailList Email
        {
            get => GetInstanceProperty<cloudflare.Queue.QueueConsumersSettingsEmailList>()!;
        }

        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConcurrency
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRetries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxWaitTimeMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxWaitTimeMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "pagerduty", typeJson: "{\"fqn\":\"cloudflare.queue.QueueConsumersSettingsPagerdutyList\"}")]
        public virtual cloudflare.Queue.QueueConsumersSettingsPagerdutyList Pagerduty
        {
            get => GetInstanceProperty<cloudflare.Queue.QueueConsumersSettingsPagerdutyList>()!;
        }

        [JsiiProperty(name: "retryDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryDelay
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "visibilityTimeoutMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VisibilityTimeoutMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "webhooks", typeJson: "{\"fqn\":\"cloudflare.queue.QueueConsumersSettingsWebhooksList\"}")]
        public virtual cloudflare.Queue.QueueConsumersSettingsWebhooksList Webhooks
        {
            get => GetInstanceProperty<cloudflare.Queue.QueueConsumersSettingsWebhooksList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.queue.QueueConsumersSettings\"}", isOptional: true)]
        public virtual cloudflare.Queue.IQueueConsumersSettings? InternalValue
        {
            get => GetInstanceProperty<cloudflare.Queue.IQueueConsumersSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
