using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargePaymentMethodDetailsCardOutputReference), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetailsCardOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargePaymentMethodDetailsCardOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargePaymentMethodDetailsCardOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargePaymentMethodDetailsCardOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargePaymentMethodDetailsCardOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "amountAuthorized", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountAuthorized
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "authorizationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "brand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Brand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "captureBefore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CaptureBefore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "checks", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardChecksOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardChecksOutputReference Checks
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardChecksOutputReference>()!;
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

        [JsiiProperty(name: "extendedAuthorization", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardExtendedAuthorizationOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardExtendedAuthorizationOutputReference ExtendedAuthorization
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardExtendedAuthorizationOutputReference>()!;
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

        [JsiiProperty(name: "incrementalAuthorization", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardIncrementalAuthorizationOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardIncrementalAuthorizationOutputReference IncrementalAuthorization
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardIncrementalAuthorizationOutputReference>()!;
        }

        [JsiiProperty(name: "installments", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardInstallmentsOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardInstallmentsOutputReference Installments
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardInstallmentsOutputReference>()!;
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

        [JsiiProperty(name: "mandate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mandate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "moto", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Moto
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "multicapture", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardMulticaptureOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardMulticaptureOutputReference Multicapture
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardMulticaptureOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Network
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkToken", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardNetworkTokenOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardNetworkTokenOutputReference NetworkToken
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardNetworkTokenOutputReference>()!;
        }

        [JsiiProperty(name: "networkTransactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkTransactionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overcapture", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardOvercaptureOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardOvercaptureOutputReference Overcapture
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardOvercaptureOutputReference>()!;
        }

        [JsiiProperty(name: "regulatedStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegulatedStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "threeDSecure", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardThreeDSecureOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardThreeDSecureOutputReference ThreeDSecure
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardThreeDSecureOutputReference>()!;
        }

        [JsiiProperty(name: "wallet", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardWalletOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardWalletOutputReference Wallet
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardWalletOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCard\"}", isOptional: true)]
        public virtual stripe.Charge.IChargePaymentMethodDetailsCard? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargePaymentMethodDetailsCard?>();
            set => SetInstanceProperty(value);
        }
    }
}
