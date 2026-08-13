using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethod.PaymentMethodCardPresentOutputReference), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardPresentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodCardPresentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodCardPresentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodCardPresentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodCardPresentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "brand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Brand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "brandProduct", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrandProduct
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cardholderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CardholderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpMonth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpYear
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "funding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Funding
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "iin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Iin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "last4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Last4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networks", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardPresentNetworksOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardPresentNetworksOutputReference Networks
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardPresentNetworksOutputReference>()!;
        }

        [JsiiProperty(name: "offline", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardPresentOfflineOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardPresentOfflineOutputReference Offline
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardPresentOfflineOutputReference>()!;
        }

        [JsiiProperty(name: "preferredLocales", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PreferredLocales
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "readMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReadMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "wallet", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardPresentWalletOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardPresentWalletOutputReference Wallet
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardPresentWalletOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardPresent\"}", isOptional: true)]
        public virtual stripe.PaymentMethod.IPaymentMethodCardPresent? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodCardPresent?>();
            set => SetInstanceProperty(value);
        }
    }
}
