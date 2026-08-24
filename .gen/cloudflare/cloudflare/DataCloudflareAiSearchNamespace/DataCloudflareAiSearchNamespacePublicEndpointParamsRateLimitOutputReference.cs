using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAiSearchNamespace
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsRateLimitOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsRateLimitOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareAiSearchNamespacePublicEndpointParamsRateLimitOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareAiSearchNamespacePublicEndpointParamsRateLimitOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareAiSearchNamespacePublicEndpointParamsRateLimitOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAiSearchNamespacePublicEndpointParamsRateLimitOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "periodMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeriodMs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "requests", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Requests
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "technique", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Technique
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAiSearchNamespace.DataCloudflareAiSearchNamespacePublicEndpointParamsRateLimit\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAiSearchNamespace.IDataCloudflareAiSearchNamespacePublicEndpointParamsRateLimit? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAiSearchNamespace.IDataCloudflareAiSearchNamespacePublicEndpointParamsRateLimit?>();
            set => SetInstanceProperty(value);
        }
    }
}
