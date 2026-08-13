using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiClass(nativeType: typeof(stripe.PaymentMethod.PaymentMethodCardWalletMasterpassOutputReference), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodCardWalletMasterpassOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentMethodCardWalletMasterpassOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentMethodCardWalletMasterpassOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentMethodCardWalletMasterpassOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodCardWalletMasterpassOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "billingAddress", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardWalletMasterpassBillingAddressOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardWalletMasterpassBillingAddressOutputReference BillingAddress
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardWalletMasterpassBillingAddressOutputReference>()!;
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

        [JsiiProperty(name: "shippingAddress", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardWalletMasterpassShippingAddressOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardWalletMasterpassShippingAddressOutputReference ShippingAddress
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardWalletMasterpassShippingAddressOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardWalletMasterpass\"}", isOptional: true)]
        public virtual stripe.PaymentMethod.IPaymentMethodCardWalletMasterpass? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodCardWalletMasterpass?>();
            set => SetInstanceProperty(value);
        }
    }
}
