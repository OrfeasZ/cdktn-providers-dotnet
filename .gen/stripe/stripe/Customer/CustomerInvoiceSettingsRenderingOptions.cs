using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiByValue(fqn: "stripe.customer.CustomerInvoiceSettingsRenderingOptions")]
    public class CustomerInvoiceSettingsRenderingOptions : stripe.Customer.ICustomerInvoiceSettingsRenderingOptions
    {
        /// <summary>How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#amount_tax_display Customer#amount_tax_display}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountTaxDisplay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmountTaxDisplay
        {
            get;
            set;
        }

        /// <summary>ID of the invoice rendering template to be used for this customer's invoices.</summary>
        /// <remarks>
        /// If set, the template will be used on all invoices for this customer unless a template is set directly on the invoice.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#template Customer#template}
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
