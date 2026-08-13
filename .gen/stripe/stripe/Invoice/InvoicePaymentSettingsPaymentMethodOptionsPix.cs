using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsPix")]
    public class InvoicePaymentSettingsPaymentMethodOptionsPix : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsPix
    {
        /// <summary>Determines if the amount includes the IOF tax.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#amount_includes_iof Invoice#amount_includes_iof}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountIncludesIof", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmountIncludesIof
        {
            get;
            set;
        }

        /// <summary>The number of seconds (between 10 and 1209600) after which Pix payment will expire. Defaults to 86400 seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#expires_after_seconds Invoice#expires_after_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiresAfterSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpiresAfterSeconds
        {
            get;
            set;
        }
    }
}
