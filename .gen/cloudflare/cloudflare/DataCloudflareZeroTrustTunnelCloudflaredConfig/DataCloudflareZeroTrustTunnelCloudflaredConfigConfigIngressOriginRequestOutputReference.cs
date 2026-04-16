using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccessOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccessOutputReference Access
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequestAccessOutputReference>()!;
        }

        [JsiiProperty(name: "caPool", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaPool
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "disableChunkedEncoding", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DisableChunkedEncoding
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "http2Origin", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Http2Origin
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "httpHostHeader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpHostHeader
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keepAliveConnections", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeepAliveConnections
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "keepAliveTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeepAliveTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "matchSnItoHost", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable MatchSnItoHost
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "noHappyEyeballs", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable NoHappyEyeballs
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "noTlsVerify", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable NoTlsVerify
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "originServerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginServerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProxyType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tcpKeepAlive", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TcpKeepAlive
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tlsTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TlsTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelCloudflaredConfig.DataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequest\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.IDataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequest? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelCloudflaredConfig.IDataCloudflareZeroTrustTunnelCloudflaredConfigConfigIngressOriginRequest?>();
            set => SetInstanceProperty(value);
        }
    }
}
