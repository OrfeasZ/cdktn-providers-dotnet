using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargePaymentMethodDetailsCardThreeDSecureOutputReference), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetailsCardThreeDSecureOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargePaymentMethodDetailsCardThreeDSecureOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargePaymentMethodDetailsCardThreeDSecureOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargePaymentMethodDetailsCardThreeDSecureOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargePaymentMethodDetailsCardThreeDSecureOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authenticationFlow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationFlow
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "electronicCommerceIndicator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElectronicCommerceIndicator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exemptionIndicator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExemptionIndicator
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exemptionIndicatorApplied", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ExemptionIndicatorApplied
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "result", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Result
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resultReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResultReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransactionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardThreeDSecure\"}", isOptional: true)]
        public virtual stripe.Charge.IChargePaymentMethodDetailsCardThreeDSecure? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargePaymentMethodDetailsCardThreeDSecure?>();
            set => SetInstanceProperty(value);
        }
    }
}
