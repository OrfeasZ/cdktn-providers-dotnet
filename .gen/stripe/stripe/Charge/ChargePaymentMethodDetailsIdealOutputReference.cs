using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargePaymentMethodDetailsIdealOutputReference), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetailsIdealOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargePaymentMethodDetailsIdealOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargePaymentMethodDetailsIdealOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargePaymentMethodDetailsIdealOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargePaymentMethodDetailsIdealOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bank
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bic
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "generatedSepaDebit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeneratedSepaDebit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "generatedSepaDebitMandate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeneratedSepaDebitMandate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ibanLast4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IbanLast4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransactionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "verifiedName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerifiedName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsIdeal\"}", isOptional: true)]
        public virtual stripe.Charge.IChargePaymentMethodDetailsIdeal? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargePaymentMethodDetailsIdeal?>();
            set => SetInstanceProperty(value);
        }
    }
}
