using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicTransitSiteWans
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareMagicTransitSiteWans.DataCloudflareMagicTransitSiteWansResultStaticAddressingOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareMagicTransitSiteWans.DataCloudflareMagicTransitSiteWansResultStaticAddressingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareMagicTransitSiteWansResultStaticAddressingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareMagicTransitSiteWansResultStaticAddressingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareMagicTransitSiteWansResultStaticAddressingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicTransitSiteWansResultStaticAddressingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteWans.DataCloudflareMagicTransitSiteWansResultStaticAddressing\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareMagicTransitSiteWans.IDataCloudflareMagicTransitSiteWansResultStaticAddressing? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitSiteWans.IDataCloudflareMagicTransitSiteWansResultStaticAddressing?>();
            set => SetInstanceProperty(value);
        }
    }
}
