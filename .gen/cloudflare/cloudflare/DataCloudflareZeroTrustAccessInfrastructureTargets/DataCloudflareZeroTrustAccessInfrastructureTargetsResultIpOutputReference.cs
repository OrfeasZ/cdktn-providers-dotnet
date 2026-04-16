using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv4OutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv4OutputReference Ipv4
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv4OutputReference>()!;
        }

        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6OutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6OutputReference Ipv6
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIpIpv6OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessInfrastructureTargets.DataCloudflareZeroTrustAccessInfrastructureTargetsResultIp\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets.IDataCloudflareZeroTrustAccessInfrastructureTargetsResultIp? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessInfrastructureTargets.IDataCloudflareZeroTrustAccessInfrastructureTargetsResultIp?>();
            set => SetInstanceProperty(value);
        }
    }
}
