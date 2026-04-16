using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDnsLocations
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustDnsLocationsResultEndpointsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustDnsLocationsResultEndpointsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustDnsLocationsResultEndpointsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDnsLocationsResultEndpointsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "doh", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsDohOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsDohOutputReference Doh
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsDohOutputReference>()!;
        }

        [JsiiProperty(name: "dot", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsDotOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsDotOutputReference Dot
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsDotOutputReference>()!;
        }

        [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsIpv4OutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsIpv4OutputReference Ipv4
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsIpv4OutputReference>()!;
        }

        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsIpv6OutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsIpv6OutputReference Ipv6
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpointsIpv6OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDnsLocations.DataCloudflareZeroTrustDnsLocationsResultEndpoints\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDnsLocations.IDataCloudflareZeroTrustDnsLocationsResultEndpoints? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDnsLocations.IDataCloudflareZeroTrustDnsLocationsResultEndpoints?>();
            set => SetInstanceProperty(value);
        }
    }
}
