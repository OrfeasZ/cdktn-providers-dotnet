using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMagicTransitCf1Sites
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareMagicTransitCf1Sites.DataCloudflareMagicTransitCf1SitesResultLocationOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareMagicTransitCf1Sites.DataCloudflareMagicTransitCf1SitesResultLocationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareMagicTransitCf1SitesResultLocationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareMagicTransitCf1SitesResultLocationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareMagicTransitCf1SitesResultLocationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareMagicTransitCf1SitesResultLocationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "lat", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Lat
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "long", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Long
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareMagicTransitCf1Sites.DataCloudflareMagicTransitCf1SitesResultLocation\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareMagicTransitCf1Sites.IDataCloudflareMagicTransitCf1SitesResultLocation? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareMagicTransitCf1Sites.IDataCloudflareMagicTransitCf1SitesResultLocation?>();
            set => SetInstanceProperty(value);
        }
    }
}
