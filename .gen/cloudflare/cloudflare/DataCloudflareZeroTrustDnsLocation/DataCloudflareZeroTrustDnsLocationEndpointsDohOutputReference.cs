using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDnsLocation
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDohOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDohOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustDnsLocationEndpointsDohOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustDnsLocationEndpointsDohOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustDnsLocationEndpointsDohOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDnsLocationEndpointsDohOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDohNetworksList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDohNetworksList Networks
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDohNetworksList>()!;
        }

        [JsiiProperty(name: "requireToken", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RequireToken
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDoh\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocation.IDataCloudflareZeroTrustDnsLocationEndpointsDoh? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocation.IDataCloudflareZeroTrustDnsLocationEndpointsDoh?>();
            set => SetInstanceProperty(value);
        }
    }
}
