using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDnsLocation
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustDnsLocationEndpointsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustDnsLocationEndpointsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustDnsLocationEndpointsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDnsLocationEndpointsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "doh", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDohOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDohOutputReference Doh
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDohOutputReference>()!;
        }

        [JsiiProperty(name: "dot", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDotOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDotOutputReference Dot
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsDotOutputReference>()!;
        }

        [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv4OutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv4OutputReference Ipv4
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv4OutputReference>()!;
        }

        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv6OutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv6OutputReference Ipv6
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpointsIpv6OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocation.DataCloudflareZeroTrustDnsLocationEndpoints\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocation.IDataCloudflareZeroTrustDnsLocationEndpoints? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocation.IDataCloudflareZeroTrustDnsLocationEndpoints?>();
            set => SetInstanceProperty(value);
        }
    }
}
