using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6OutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6OutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6OutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ipAddr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets.IDataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets.IDataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6?>();
            set => SetInstanceProperty(value);
        }
    }
}
