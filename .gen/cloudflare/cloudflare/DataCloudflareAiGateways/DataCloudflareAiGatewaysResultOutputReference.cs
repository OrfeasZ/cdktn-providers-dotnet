using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiGateways
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareAiGatewaysResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareAiGatewaysResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiGatewaysResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiGatewaysResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Authentication
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "cacheInvalidateOnUpdate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CacheInvalidateOnUpdate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "cacheTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CacheTtl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "collectLogs", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CollectLogs
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dlp", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResultDlpOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultDlpOutputReference Dlp
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultDlpOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDefault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDefault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logManagement", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LogManagement
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "logManagementStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogManagementStrategy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logpush", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Logpush
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logpushPublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogpushPublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "otel", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResultOtelList\"}")]
        public virtual cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultOtelList Otel
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultOtelList>()!;
        }

        [JsiiProperty(name: "rateLimitingInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RateLimitingInterval
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rateLimitingLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RateLimitingLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rateLimitingTechnique", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RateLimitingTechnique
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retryBackoff", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetryBackoff
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retryDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryDelay
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "retryMaxAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryMaxAttempts
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "storeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stripe", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResultStripeOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultStripeOutputReference Stripe
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateways.DataCloudflareAiGatewaysResultStripeOutputReference>()!;
        }

        [JsiiProperty(name: "workersAiBillingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkersAiBillingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zdr", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Zdr
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiGateways.DataCloudflareAiGatewaysResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiGateways.IDataCloudflareAiGatewaysResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiGateways.IDataCloudflareAiGatewaysResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
