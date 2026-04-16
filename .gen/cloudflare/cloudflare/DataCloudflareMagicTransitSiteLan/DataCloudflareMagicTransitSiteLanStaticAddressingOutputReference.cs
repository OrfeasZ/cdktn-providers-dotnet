using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicTransitSiteLan
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareMagicTransitSiteLan.DataCloudflareMagicTransitSiteLanStaticAddressingOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareMagicTransitSiteLan.DataCloudflareMagicTransitSiteLanStaticAddressingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareMagicTransitSiteLanStaticAddressingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareMagicTransitSiteLanStaticAddressingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareMagicTransitSiteLanStaticAddressingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicTransitSiteLanStaticAddressingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dhcpRelay", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteLan.DataCloudflareMagicTransitSiteLanStaticAddressingDhcpRelayOutputReference\"}")]
        public virtual cloudflare.DataCloudflareMagicTransitSiteLan.DataCloudflareMagicTransitSiteLanStaticAddressingDhcpRelayOutputReference DhcpRelay
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitSiteLan.DataCloudflareMagicTransitSiteLanStaticAddressingDhcpRelayOutputReference>()!;
        }

        [JsiiProperty(name: "dhcpServer", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteLan.DataCloudflareMagicTransitSiteLanStaticAddressingDhcpServerOutputReference\"}")]
        public virtual cloudflare.DataCloudflareMagicTransitSiteLan.DataCloudflareMagicTransitSiteLanStaticAddressingDhcpServerOutputReference DhcpServer
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitSiteLan.DataCloudflareMagicTransitSiteLanStaticAddressingDhcpServerOutputReference>()!;
        }

        [JsiiProperty(name: "secondaryAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteLan.DataCloudflareMagicTransitSiteLanStaticAddressing\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareMagicTransitSiteLan.IDataCloudflareMagicTransitSiteLanStaticAddressing? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitSiteLan.IDataCloudflareMagicTransitSiteLanStaticAddressing?>();
            set => SetInstanceProperty(value);
        }
    }
}
