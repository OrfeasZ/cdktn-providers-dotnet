using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestAccessOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestAccessOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestAccessOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestAccessOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestAccessOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestAccessOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "audTag", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AudTag
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "required", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Required
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "teamName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TeamName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestAccess\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.IDataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestAccess? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.IDataCloudflareZeroTrustTunnelCloudflaredConfigConfigOriginRequestAccess?>();
            set => SetInstanceProperty(value);
        }
    }
}
