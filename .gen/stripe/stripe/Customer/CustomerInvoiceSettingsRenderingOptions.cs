using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiByValue(fqn: "stripe.customer.CustomerInvoiceSettingsRenderingOptions")]
    public class CustomerInvoiceSettingsRenderingOptions : stripe.Customer.ICustomerInvoiceSettingsRenderingOptions
    {
        /// <summary>How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.</summary>
        /// <remarks>
        /// One of <c>exclude_tax</c> or <c>include_inclusive_tax</c>. <c>include_inclusive_tax</c> will include inclusive tax (and exclude exclusive tax) in invoice PDF amounts. <c>exclude_tax</c> will exclude all tax (inclusive and exclusive alike) from invoice PDF amounts.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#amount_tax_display Customer#amount_tax_display}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountTaxDisplay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmountTaxDisplay
        {
            get;
            set;
        }

        /// <summary>ID of the invoice rendering template to use for future invoices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#template Customer#template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Template
        {
            get;
            set;
        }
    }
}
