using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoiceRendering")]
    public class InvoiceRendering : stripe.Invoice.IInvoiceRendering
    {
        /// <summary>How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#amount_tax_display Invoice#amount_tax_display}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountTaxDisplay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmountTaxDisplay
        {
            get;
            set;
        }

        /// <summary>Invoice pdf rendering options.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#pdf Invoice#pdf}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pdf", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceRenderingPdf\"}", isOptional: true)]
        public stripe.Invoice.IInvoiceRenderingPdf? Pdf
        {
            get;
            set;
        }

        /// <summary>ID of the rendering template that the invoice is formatted by.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#template Invoice#template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Template
        {
            get;
            set;
        }

        /// <summary>Version of the rendering template that the invoice is using.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#template_version Invoice#template_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "templateVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TemplateVersion
        {
            get;
            set;
        }
    }
}
