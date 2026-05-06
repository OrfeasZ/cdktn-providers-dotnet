using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicWanGreTunnel
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareMagicWanGreTunnel.DataCloudflareMagicWanGreTunnelGreTunnelBgpOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareMagicWanGreTunnel.DataCloudflareMagicWanGreTunnelGreTunnelBgpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareMagicWanGreTunnelGreTunnelBgpOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareMagicWanGreTunnelGreTunnelBgpOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareMagicWanGreTunnelGreTunnelBgpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicWanGreTunnelGreTunnelBgpOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "customerAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CustomerAsn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "extraPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExtraPrefixes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "md5Key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Md5Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicWanGreTunnel.DataCloudflareMagicWanGreTunnelGreTunnelBgp\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareMagicWanGreTunnel.IDataCloudflareMagicWanGreTunnelGreTunnelBgp? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicWanGreTunnel.IDataCloudflareMagicWanGreTunnelGreTunnelBgp?>();
            set => SetInstanceProperty(value);
        }
    }
}
