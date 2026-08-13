using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions")]
    public class InvoicePaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsAcssDebitMandateOptions
    {
        /// <summary>Transaction type of the mandate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#transaction_type Invoice#transaction_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transactionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransactionType
        {
            get;
            set;
        }
    }
}
