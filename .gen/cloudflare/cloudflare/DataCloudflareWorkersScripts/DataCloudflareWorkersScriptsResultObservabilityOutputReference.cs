using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkersScripts
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservabilityOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservabilityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkersScriptsResultObservabilityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkersScriptsResultObservabilityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkersScriptsResultObservabilityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersScriptsResultObservabilityOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservabilityLogsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservabilityLogsOutputReference Logs
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservabilityLogsOutputReference>()!;
        }

        [JsiiProperty(name: "traces", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservabilityTracesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservabilityTracesOutputReference Traces
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservabilityTracesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkersScripts.DataCloudflareWorkersScriptsResultObservability\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkersScripts.IDataCloudflareWorkersScriptsResultObservability? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkersScripts.IDataCloudflareWorkersScriptsResultObservability?>();
            set => SetInstanceProperty(value);
        }
    }
}
