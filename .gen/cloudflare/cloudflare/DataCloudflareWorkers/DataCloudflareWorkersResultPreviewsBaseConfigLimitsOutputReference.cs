using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWorkers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigLimitsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigLimitsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareWorkersResultPreviewsBaseConfigLimitsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareWorkersResultPreviewsBaseConfigLimitsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareWorkersResultPreviewsBaseConfigLimitsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWorkersResultPreviewsBaseConfigLimitsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cpuMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "subrequests", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Subrequests
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWorkers.DataCloudflareWorkersResultPreviewsBaseConfigLimits\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResultPreviewsBaseConfigLimits? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWorkers.IDataCloudflareWorkersResultPreviewsBaseConfigLimits?>();
            set => SetInstanceProperty(value);
        }
    }
}
