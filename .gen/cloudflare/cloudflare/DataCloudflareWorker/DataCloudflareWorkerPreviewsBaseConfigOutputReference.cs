using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorker
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkerPreviewsBaseConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkerPreviewsBaseConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkerPreviewsBaseConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerPreviewsBaseConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cacheOptions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigCacheOptionsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigCacheOptionsOutputReference CacheOptions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigCacheOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigEnvMap\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigEnvMap Env
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigEnvMap>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigLimitsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigLimitsOutputReference Limits
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "logpush", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Logpush
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityOutputReference Observability
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityOutputReference>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigPlacementOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigPlacementOutputReference>()!;
        }

        [JsiiProperty(name: "tailConsumers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigTailConsumersList\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigTailConsumersList TailConsumers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigTailConsumersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorker.IDataCloudflareWorkerPreviewsBaseConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.IDataCloudflareWorkerPreviewsBaseConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
