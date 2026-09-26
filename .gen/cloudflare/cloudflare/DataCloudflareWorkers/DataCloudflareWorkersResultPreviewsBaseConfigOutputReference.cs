using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkersResultPreviewsBaseConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkersResultPreviewsBaseConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkersResultPreviewsBaseConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersResultPreviewsBaseConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cacheOptions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigCacheOptionsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigCacheOptionsOutputReference CacheOptions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigCacheOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigEnvMap\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigEnvMap Env
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigEnvMap>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigLimitsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigLimitsOutputReference Limits
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "logpush", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Logpush
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "observability", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityOutputReference Observability
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityOutputReference>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigPlacementOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigPlacementOutputReference>()!;
        }

        [JsiiProperty(name: "tailConsumers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigTailConsumersList\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigTailConsumersList TailConsumers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigTailConsumersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResultPreviewsBaseConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResultPreviewsBaseConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
