using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethod.PaymentMethodCardWalletVisaCheckoutOutputReference), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardWalletVisaCheckoutOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodCardWalletVisaCheckoutOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodCardWalletVisaCheckoutOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodCardWalletVisaCheckoutOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodCardWalletVisaCheckoutOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "billingAddress", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardWalletVisaCheckoutBillingAddressOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardWalletVisaCheckoutBillingAddressOutputReference BillingAddress
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardWalletVisaCheckoutBillingAddressOutputReference>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shippingAddress", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardWalletVisaCheckoutShippingAddressOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardWalletVisaCheckoutShippingAddressOutputReference ShippingAddress
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardWalletVisaCheckoutShippingAddressOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardWalletVisaCheckout\"}", isOptional: true)]
        public virtual stripe.PaymentMethod.IPaymentMethodCardWalletVisaCheckout? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodCardWalletVisaCheckout?>();
            set => SetInstanceProperty(value);
        }
    }
}
