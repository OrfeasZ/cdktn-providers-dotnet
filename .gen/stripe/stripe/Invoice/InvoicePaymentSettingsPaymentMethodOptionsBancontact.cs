using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoicePaymentSettingsPaymentMethodOptionsBancontact")]
    public class InvoicePaymentSettingsPaymentMethodOptionsBancontact : stripe.Invoice.IInvoicePaymentSettingsPaymentMethodOptionsBancontact
    {
        /// <summary>Preferred language of the Bancontact authorization page that the customer is redirected to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#preferred_language Invoice#preferred_language}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferredLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredLanguage
        {
            get;
            set;
        }
    }
}
