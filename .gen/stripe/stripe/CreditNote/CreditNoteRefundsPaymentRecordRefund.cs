using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.CreditNote
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.creditNote.CreditNoteRefundsPaymentRecordRefund")]
    public class CreditNoteRefundsPaymentRecordRefund : stripe.CreditNote.ICreditNoteRefundsPaymentRecordRefund
    {
        /// <summary>ID of the payment record.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#payment_record CreditNote#payment_record}
        /// </remarks>
        [JsiiProperty(name: "paymentRecord", typeJson: "{\"primitive\":\"string\"}")]
        public string PaymentRecord
        {
            get;
            set;
        }

        /// <summary>ID of the refund group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#refund_group CreditNote#refund_group}
        /// </remarks>
        [JsiiProperty(name: "refundGroup", typeJson: "{\"primitive\":\"string\"}")]
        public string RefundGroup
        {
            get;
            set;
        }
    }
}
