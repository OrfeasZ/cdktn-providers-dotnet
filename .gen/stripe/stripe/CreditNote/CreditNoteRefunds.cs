using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.CreditNote
{
    [JsiiByValue(fqn: "stripe.creditNote.CreditNoteRefunds")]
    public class CreditNoteRefunds : stripe.CreditNote.ICreditNoteRefunds
    {
        /// <summary>Amount of the refund that applies to this credit note, in cents (or local equivalent).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#amount_refunded CreditNote#amount_refunded}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountRefunded", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AmountRefunded
        {
            get;
            set;
        }

        /// <summary>The PaymentRecord refund details associated with this credit note refund.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#payment_record_refund CreditNote#payment_record_refund}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentRecordRefund", typeJson: "{\"fqn\":\"stripe.creditNote.CreditNoteRefundsPaymentRecordRefund\"}", isOptional: true)]
        public stripe.CreditNote.ICreditNoteRefundsPaymentRecordRefund? PaymentRecordRefund
        {
            get;
            set;
        }

        /// <summary>ID of the refund.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#refund CreditNote#refund}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "refund", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Refund
        {
            get;
            set;
        }

        /// <summary>Type of the refund, one of `refund` or `payment_record_refund`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#type CreditNote#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
