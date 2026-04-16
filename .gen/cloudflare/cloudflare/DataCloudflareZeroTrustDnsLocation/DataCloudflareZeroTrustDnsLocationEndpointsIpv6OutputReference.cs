using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDnsLocation
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv6OutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv6OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustDnsLocationEndpointsIpv6OutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustDnsLocationEndpointsIpv6OutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustDnsLocationEndpointsIpv6OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDnsLocationEndpointsIpv6OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv6NetworksList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv6NetworksList Networks
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv6NetworksList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv6\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocation.IDataCloudflareZeroTrustDnsLocationEndpointsIpv6? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocation.IDataCloudflareZeroTrustDnsLocationEndpointsIpv6?>();
            set => SetInstanceProperty(value);
        }
    }
}
