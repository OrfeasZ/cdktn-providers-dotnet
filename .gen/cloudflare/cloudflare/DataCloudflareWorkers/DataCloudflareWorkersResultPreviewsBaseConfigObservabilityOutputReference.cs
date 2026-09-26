using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkersResultPreviewsBaseConfigObservabilityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkersResultPreviewsBaseConfigObservabilityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkersResultPreviewsBaseConfigObservabilityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersResultPreviewsBaseConfigObservabilityOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "issues", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityIssuesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityIssuesOutputReference Issues
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityIssuesOutputReference>()!;
        }

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityLogsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityLogsOutputReference Logs
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityLogsOutputReference>()!;
        }

        [JsiiProperty(name: "redactQueryString", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RedactQueryString
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "traces", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityTracesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityTracesOutputReference Traces
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservabilityTracesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigObservability\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResultPreviewsBaseConfigObservability? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResultPreviewsBaseConfigObservability?>();
            set => SetInstanceProperty(value);
        }
    }
}
