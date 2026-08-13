using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargePaymentMethodDetailsPaypalOutputReference), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetailsPaypalOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargePaymentMethodDetailsPaypalOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargePaymentMethodDetailsPaypalOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargePaymentMethodDetailsPaypalOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargePaymentMethodDetailsPaypalOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payerEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayerEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "payerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sellerProtection", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsPaypalSellerProtectionOutputReference\"}")]
        public virtual stripe.Charge.ChargePaymentMethodDetailsPaypalSellerProtectionOutputReference SellerProtection
        {
            get => GetInstanceProperty<stripe.Charge.ChargePaymentMethodDetailsPaypalSellerProtectionOutputReference>()!;
        }

        [JsiiProperty(name: "transactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransactionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsPaypal\"}", isOptional: true)]
        public virtual stripe.Charge.IChargePaymentMethodDetailsPaypal? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargePaymentMethodDetailsPaypal?>();
            set => SetInstanceProperty(value);
        }
    }
}
