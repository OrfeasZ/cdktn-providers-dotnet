using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicTransitSiteLans
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareMagicTransitSiteLansResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareMagicTransitSiteLansResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicTransitSiteLansResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicTransitSiteLansResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bondId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BondId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "haLink", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HaLink
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isBreakout", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBreakout
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPrioritized", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPrioritized
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultNatOutputReference\"}")]
        public virtual cloudflare.DataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultNatOutputReference Nat
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultNatOutputReference>()!;
        }

        [JsiiProperty(name: "physport", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Physport
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "routedSubnets", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultRoutedSubnetsList\"}")]
        public virtual cloudflare.DataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultRoutedSubnetsList RoutedSubnets
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultRoutedSubnetsList>()!;
        }

        [JsiiProperty(name: "siteId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SiteId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "staticAddressing", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultStaticAddressingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultStaticAddressingOutputReference StaticAddressing
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResultStaticAddressingOutputReference>()!;
        }

        [JsiiProperty(name: "vlanTag", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VlanTag
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitSiteLans.DataCloudflareMagicTransitSiteLansResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareMagicTransitSiteLans.IDataCloudflareMagicTransitSiteLansResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitSiteLans.IDataCloudflareMagicTransitSiteLansResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
