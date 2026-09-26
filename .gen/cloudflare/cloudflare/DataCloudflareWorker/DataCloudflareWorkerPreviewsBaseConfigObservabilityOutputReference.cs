using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorker
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkerPreviewsBaseConfigObservabilityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkerPreviewsBaseConfigObservabilityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkerPreviewsBaseConfigObservabilityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkerPreviewsBaseConfigObservabilityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "headSamplingRate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HeadSamplingRate
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "issues", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityIssuesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityIssuesOutputReference Issues
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityIssuesOutputReference>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityLogsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityLogsOutputReference Logs
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityLogsOutputReference>()!;
        }

        [JsiiProperty(name: "redactQueryString", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RedactQueryString
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "traces", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityTracesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityTracesOutputReference Traces
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservabilityTracesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorker.DataCloudflareWorkerPreviewsBaseConfigObservability\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorker.IDataCloudflareWorkerPreviewsBaseConfigObservability? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorker.IDataCloudflareWorkerPreviewsBaseConfigObservability?>();
            set => SetInstanceProperty(value);
        }
    }
}
