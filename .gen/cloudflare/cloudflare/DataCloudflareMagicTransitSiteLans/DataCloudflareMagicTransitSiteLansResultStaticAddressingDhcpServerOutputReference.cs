using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicTransitSiteLans
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultStaticAddressingDhcpServerOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultStaticAddressingDhcpServerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareMagicTransitSiteLansResultStaticAddressingDhcpServerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareMagicTransitSiteLansResultStaticAddressingDhcpServerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareMagicTransitSiteLansResultStaticAddressingDhcpServerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicTransitSiteLansResultStaticAddressingDhcpServerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dhcpPoolEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DhcpPoolEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dhcpPoolStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DhcpPoolStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsServer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "reservations", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Reservations
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultStaticAddressingDhcpServer\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareMagicTransitSiteLans.IDataCloudflareMagicTransitSiteLansResultStaticAddressingDhcpServer? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitSiteLans.IDataCloudflareMagicTransitSiteLansResultStaticAddressingDhcpServer?>();
            set => SetInstanceProperty(value);
        }
    }
}
