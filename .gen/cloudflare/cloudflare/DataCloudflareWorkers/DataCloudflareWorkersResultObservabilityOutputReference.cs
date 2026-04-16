using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultObservabilityOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultObservabilityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkersResultObservabilityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkersResultObservabilityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkersResultObservabilityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersResultObservabilityOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "logs", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultObservabilityLogsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultObservabilityLogsOutputReference Logs
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultObservabilityLogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultObservability\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResultObservability? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResultObservability?>();
            set => SetInstanceProperty(value);
        }
    }
}
