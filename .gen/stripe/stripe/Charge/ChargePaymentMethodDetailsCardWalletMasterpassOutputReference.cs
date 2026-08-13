using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargePaymentMethodDetailsCardWalletMasterpassOutputReference), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetailsCardWalletMasterpassOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargePaymentMethodDetailsCardWalletMasterpassOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargePaymentMethodDetailsCardWalletMasterpassOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargePaymentMethodDetailsCardWalletMasterpassOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargePaymentMethodDetailsCardWalletMasterpassOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "billingAddress", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardWalletMasterpassBillingAddressOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardWalletMasterpassBillingAddressOutputReference BillingAddress
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardWalletMasterpassBillingAddressOutputReference>()!;
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

        [JsiiProperty(name: "shippingAddress", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardWalletMasterpassShippingAddressOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsCardWalletMasterpassShippingAddressOutputReference ShippingAddress
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsCardWalletMasterpassShippingAddressOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardWalletMasterpass\"}", isOptional: true)]
        public virtual stripe.Charge.IChargePaymentMethodDetailsCardWalletMasterpass? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargePaymentMethodDetailsCardWalletMasterpass?>();
            set => SetInstanceProperty(value);
        }
    }
}
