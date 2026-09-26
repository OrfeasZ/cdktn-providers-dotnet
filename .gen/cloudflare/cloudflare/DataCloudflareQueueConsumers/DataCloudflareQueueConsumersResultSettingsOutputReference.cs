using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareQueueConsumers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareQueueConsumersResultSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareQueueConsumersResultSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareQueueConsumersResultSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareQueueConsumersResultSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsEmailList\"}")]
        public virtual cloudflare.DataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsEmailList Email
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsEmailList>()!;
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

        [JsiiProperty(name: "pagerduty", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsPagerdutyList\"}")]
        public virtual cloudflare.DataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsPagerdutyList Pagerduty
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsPagerdutyList>()!;
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

        [JsiiProperty(name: "webhooks", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsWebhooksList\"}")]
        public virtual cloudflare.DataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsWebhooksList Webhooks
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettingsWebhooksList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareQueueConsumers.DataCloudflareQueueConsumersResultSettings\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareQueueConsumers.IDataCloudflareQueueConsumersResultSettings? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareQueueConsumers.IDataCloudflareQueueConsumersResultSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
