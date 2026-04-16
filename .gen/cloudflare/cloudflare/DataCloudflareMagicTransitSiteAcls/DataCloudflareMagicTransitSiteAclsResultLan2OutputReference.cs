using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicTransitSiteAcls
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareMagicTransitSiteAcls.DataCloudflareMagicTransitSiteAclsResultLan2OutputReference), fullyQualifiedName: "cloudflare.dataCloudflareMagicTransitSiteAcls.DataCloudflareMagicTransitSiteAclsResultLan2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareMagicTransitSiteAclsResultLan2OutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareMagicTransitSiteAclsResultLan2OutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareMagicTransitSiteAclsResultLan2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicTransitSiteAclsResultLan2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "lanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lanName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LanName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PortRanges
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] Ports
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Subnets
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteAcls.DataCloudflareMagicTransitSiteAclsResultLan2\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareMagicTransitSiteAcls.IDataCloudflareMagicTransitSiteAclsResultLan2? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitSiteAcls.IDataCloudflareMagicTransitSiteAclsResultLan2?>();
            set => SetInstanceProperty(value);
        }
    }
}
