using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethod.PaymentMethodCardWalletOutputReference), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardWalletOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodCardWalletOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodCardWalletOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodCardWalletOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodCardWalletOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dynamicLast4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DynamicLast4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterpass", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardWalletMasterpassOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardWalletMasterpassOutputReference Masterpass
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardWalletMasterpassOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "visaCheckout", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardWalletVisaCheckoutOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardWalletVisaCheckoutOutputReference VisaCheckout
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardWalletVisaCheckoutOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardWallet\"}", isOptional: true)]
        public virtual stripe.PaymentMethod.IPaymentMethodCardWallet? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodCardWallet?>();
            set => SetInstanceProperty(value);
        }
    }
}
