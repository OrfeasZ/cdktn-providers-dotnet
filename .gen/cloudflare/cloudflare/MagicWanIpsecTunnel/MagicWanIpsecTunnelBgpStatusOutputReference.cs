using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicWanIpsecTunnel
{
    [JsiiClass(nativeType: typeof(cloudflare.MagicWanIpsecTunnel.MagicWanIpsecTunnelBgpStatusOutputReference), fullyQualifiedName: "cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelBgpStatusOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MagicWanIpsecTunnelBgpStatusOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MagicWanIpsecTunnelBgpStatusOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MagicWanIpsecTunnelBgpStatusOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MagicWanIpsecTunnelBgpStatusOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bgpState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cfSpeakerIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CfSpeakerIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cfSpeakerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CfSpeakerPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "customerSpeakerIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerSpeakerIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerSpeakerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CustomerSpeakerPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tcpEstablished", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable TcpEstablished
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.magicWanIpsecTunnel.MagicWanIpsecTunnelBgpStatus\"}", isOptional: true)]
        public virtual cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelBgpStatus? InternalValue
        {
            get => GetInstanceProperty<cloudflare.MagicWanIpsecTunnel.IMagicWanIpsecTunnelBgpStatus?>();
            set => SetInstanceProperty(value);
        }
    }
}
