using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.invoice.InvoiceFromInvoice")]
    public class InvoiceFromInvoice : stripe.Invoice.IInvoiceFromInvoice
    {
        /// <summary>The relation between this invoice and the cloned invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#action Invoice#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>The invoice that was cloned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#invoice Invoice#invoice}
        /// </remarks>
        [JsiiProperty(name: "invoice", typeJson: "{\"primitive\":\"string\"}")]
        public string Invoice
        {
            get;
            set;
        }
    }
}
