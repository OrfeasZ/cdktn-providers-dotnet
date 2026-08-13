using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.CreditNote
{
    [JsiiInterface(nativeType: typeof(ICreditNoteRefunds), fullyQualifiedName: "stripe.creditNote.CreditNoteRefunds")]
    public interface ICreditNoteRefunds
    {
        /// <summary>Amount of the refund that applies to this credit note, in cents (or local equivalent).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#amount_refunded CreditNote#amount_refunded}
        /// </remarks>
        [JsiiProperty(name: "amountRefunded", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AmountRefunded
        {
            get
            {
                return null;
            }
        }

        /// <summary>The PaymentRecord refund details associated with this credit note refund.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#payment_record_refund CreditNote#payment_record_refund}
        /// </remarks>
        [JsiiProperty(name: "paymentRecordRefund", typeJson: "{\"fqn\":\"stripe.creditNote.CreditNoteRefundsPaymentRecordRefund\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.CreditNote.ICreditNoteRefundsPaymentRecordRefund? PaymentRecordRefund
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the refund.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#refund CreditNote#refund}
        /// </remarks>
        [JsiiProperty(name: "refund", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Refund
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of the refund, one of `refund` or `payment_record_refund`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#type CreditNote#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICreditNoteRefunds), fullyQualifiedName: "stripe.creditNote.CreditNoteRefunds")]
        internal sealed class _Proxy : DeputyBase, stripe.CreditNote.ICreditNoteRefunds
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Amount of the refund that applies to this credit note, in cents (or local equivalent).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#amount_refunded CreditNote#amount_refunded}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountRefunded", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AmountRefunded
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The PaymentRecord refund details associated with this credit note refund.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#payment_record_refund CreditNote#payment_record_refund}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentRecordRefund", typeJson: "{\"fqn\":\"stripe.creditNote.CreditNoteRefundsPaymentRecordRefund\"}", isOptional: true)]
            public stripe.CreditNote.ICreditNoteRefundsPaymentRecordRefund? PaymentRecordRefund
            {
                get => GetInstanceProperty<stripe.CreditNote.ICreditNoteRefundsPaymentRecordRefund?>();
            }

            /// <summary>ID of the refund.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#refund CreditNote#refund}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "refund", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Refund
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Type of the refund, one of `refund` or `payment_record_refund`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#type CreditNote#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
