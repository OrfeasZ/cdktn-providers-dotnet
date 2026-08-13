using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargePaymentMethodDetailsCardPresentReceiptOutputReference), fullyQualifiedName: "stripe.charge.ChargePaymentMethodDetailsCardPresentReceiptOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargePaymentMethodDetailsCardPresentReceiptOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargePaymentMethodDetailsCardPresentReceiptOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargePaymentMethodDetailsCardPresentReceiptOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargePaymentMethodDetailsCardPresentReceiptOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationCryptogram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationCryptogram
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationPreferredName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationPreferredName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authorizationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authorizationResponseCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationResponseCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cardholderVerificationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CardholderVerificationMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dedicatedFileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DedicatedFileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "terminalVerificationResults", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TerminalVerificationResults
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transactionStatusInformation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransactionStatusInformation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargePaymentMethodDetailsCardPresentReceipt\"}", isOptional: true)]
        public virtual stripe.Charge.IChargePaymentMethodDetailsCardPresentReceipt? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargePaymentMethodDetailsCardPresentReceipt?>();
            set => SetInstanceProperty(value);
        }
    }
}
