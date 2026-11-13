using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillie")]
    public class InvoicePaymentSettingsPaymentMethodOptionsBillie : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillie
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#company_details Invoice#company_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "companyDetails", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails\"}", isOptional: true)]
        public stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetails? CompanyDetails
        {
            get;
            set;
        }

        /// <summary>An identifier or reference that this payment corresponds to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/invoice#reference Invoice#reference}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Reference
        {
            get;
            set;
        }
    }
}
