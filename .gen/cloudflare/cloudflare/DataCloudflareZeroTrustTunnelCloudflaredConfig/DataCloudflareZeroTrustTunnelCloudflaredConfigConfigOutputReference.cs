using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ingress", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressList Ingress
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressList>()!;
        }

        [JsiiProperty(name: "originRequest", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestOutputReference OriginRequest
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.IDataCloudflareZeroTrustTunnelCloudflaredConfigConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.IDataCloudflareZeroTrustTunnelCloudflaredConfigConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
