using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiClass(nativeType: typeof(stripe.PaymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaOutputReference), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountHolderAddress", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaAccountHolderAddressOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaAccountHolderAddressOutputReference AccountHolderAddress
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaAccountHolderAddressOutputReference>()!;
        }

        [JsiiProperty(name: "accountHolderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountHolderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bankAddress", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaBankAddressOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaBankAddressOutputReference BankAddress
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAbaBankAddressOutputReference>()!;
        }

        [JsiiProperty(name: "bankName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BankName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routingNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAba\"}", isOptional: true)]
        public virtual stripe.PaymentIntent.IPaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAba? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressesAba?>();
            set => SetInstanceProperty(value);
        }
    }
}
