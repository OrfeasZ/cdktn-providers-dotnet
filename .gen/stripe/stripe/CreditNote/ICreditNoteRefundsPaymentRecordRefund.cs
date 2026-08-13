using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.CreditNote
{
    [JsiiInterface(nativeType: typeof(ICreditNoteRefundsPaymentRecordRefund), fullyQualifiedName: "stripe.creditNote.CreditNoteRefundsPaymentRecordRefund")]
    public interface ICreditNoteRefundsPaymentRecordRefund
    {
        /// <summary>ID of the payment record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#payment_record CreditNote#payment_record}
        /// </remarks>
        [JsiiProperty(name: "paymentRecord", typeJson: "{\"primitive\":\"string\"}")]
        string PaymentRecord
        {
            get;
        }

        /// <summary>ID of the refund group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#refund_group CreditNote#refund_group}
        /// </remarks>
        [JsiiProperty(name: "refundGroup", typeJson: "{\"primitive\":\"string\"}")]
        string RefundGroup
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICreditNoteRefundsPaymentRecordRefund), fullyQualifiedName: "stripe.creditNote.CreditNoteRefundsPaymentRecordRefund")]
        internal sealed class _Proxy : DeputyBase, stripe.CreditNote.ICreditNoteRefundsPaymentRecordRefund
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the payment record.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#payment_record CreditNote#payment_record}
            /// </remarks>
            [JsiiProperty(name: "paymentRecord", typeJson: "{\"primitive\":\"string\"}")]
            public string PaymentRecord
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the refund group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#refund_group CreditNote#refund_group}
            /// </remarks>
            [JsiiProperty(name: "refundGroup", typeJson: "{\"primitive\":\"string\"}")]
            public string RefundGroup
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
