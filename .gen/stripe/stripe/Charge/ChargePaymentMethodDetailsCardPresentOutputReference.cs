using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargePaymentMethodDetailsCardPresentOutputReference), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetailsCardPresentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargePaymentMethodDetailsCardPresentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargePaymentMethodDetailsCardPresentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargePaymentMethodDetailsCardPresentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargePaymentMethodDetailsCardPresentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "amountAuthorized", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountAuthorized
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "captureBefore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CaptureBefore
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "emvAuthData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmvAuthData
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

        [JsiiProperty(name: "generatedCard", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeneratedCard
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "iin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Iin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "incrementalAuthorizationSupported", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IncrementalAuthorizationSupported
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Network
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkTransactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkTransactionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "offline", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardPresentOfflineOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardPresentOfflineOutputReference Offline
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardPresentOfflineOutputReference>()!;
        }

        [JsiiProperty(name: "overcaptureSupported", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable OvercaptureSupported
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "preferredLocales", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PreferredLocales
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "reader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reader
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReadMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "receipt", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardPresentReceiptOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardPresentReceiptOutputReference Receipt
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardPresentReceiptOutputReference>()!;
        }

        [JsiiProperty(name: "wallet", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardPresentWalletOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardPresentWalletOutputReference Wallet
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardPresentWalletOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardPresent\"}", isOptional: true)]
        public virtual stripe.Charge.IChargePaymentMethodDetailsCardPresent? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargePaymentMethodDetailsCardPresent?>();
            set => SetInstanceProperty(value);
        }
    }
}
