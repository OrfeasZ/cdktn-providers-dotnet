using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargePaymentMethodDetailsAcssDebitOutputReference), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetailsAcssDebitOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargePaymentMethodDetailsAcssDebitOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargePaymentMethodDetailsAcssDebitOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargePaymentMethodDetailsAcssDebitOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargePaymentMethodDetailsAcssDebitOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bankName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BankName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expectedDebitDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpectedDebitDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "institutionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstitutionNumber
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

        [JsiiProperty(name: "transitNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransitNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsAcssDebit\"}", isOptional: true)]
        public virtual stripe.Charge.IChargePaymentMethodDetailsAcssDebit? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargePaymentMethodDetailsAcssDebit?>();
            set => SetInstanceProperty(value);
        }
    }
}
