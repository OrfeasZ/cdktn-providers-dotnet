using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiClass(nativeType: typeof(stripe.Source.SourceKlarnaOutputReference), fullyQualifiedName: "stripe.source.SourceKlarnaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SourceKlarnaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SourceKlarnaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SourceKlarnaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SourceKlarnaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backgroundImageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackgroundImageUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locale
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pageTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PageTitle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payLaterAssetUrlsDescriptive", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayLaterAssetUrlsDescriptive
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payLaterAssetUrlsStandard", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayLaterAssetUrlsStandard
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payLaterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayLaterName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payLaterRedirectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayLaterRedirectUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentMethodCategories", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethodCategories
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payNowAssetUrlsDescriptive", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayNowAssetUrlsDescriptive
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payNowAssetUrlsStandard", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayNowAssetUrlsStandard
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payNowName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayNowName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payNowRedirectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayNowRedirectUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payOverTimeAssetUrlsDescriptive", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayOverTimeAssetUrlsDescriptive
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payOverTimeAssetUrlsStandard", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayOverTimeAssetUrlsStandard
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payOverTimeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayOverTimeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payOverTimeRedirectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayOverTimeRedirectUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "purchaseCountry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PurchaseCountry
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "purchaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PurchaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shippingDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ShippingDelay
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shippingFirstName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShippingFirstName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shippingLastName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShippingLastName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.source.SourceKlarna\"}", isOptional: true)]
        public virtual stripe.Source.ISourceKlarna? InternalValue
        {
            get => GetInstanceProperty<stripe.Source.ISourceKlarna?>();
            set => SetInstanceProperty(value);
        }
    }
}
