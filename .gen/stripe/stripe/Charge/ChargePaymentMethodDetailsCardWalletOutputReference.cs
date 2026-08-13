using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargePaymentMethodDetailsCardWalletOutputReference), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetailsCardWalletOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargePaymentMethodDetailsCardWalletOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargePaymentMethodDetailsCardWalletOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargePaymentMethodDetailsCardWalletOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargePaymentMethodDetailsCardWalletOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dynamicLast4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DynamicLast4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterpass", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardWalletMasterpassOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardWalletMasterpassOutputReference Masterpass
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardWalletMasterpassOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "visaCheckout", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardWalletVisaCheckoutOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardWalletVisaCheckoutOutputReference VisaCheckout
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardWalletVisaCheckoutOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardWallet\"}", isOptional: true)]
        public virtual stripe.Charge.IChargePaymentMethodDetailsCardWallet? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargePaymentMethodDetailsCardWallet?>();
            set => SetInstanceProperty(value);
        }
    }
}
