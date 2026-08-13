using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.invoice.InvoiceTransferData")]
    public class InvoiceTransferData : stripe.Invoice.IInvoiceTransferData
    {
        /// <summary>ID of an existing, connected Stripe account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#destination Invoice#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }

        /// <summary>The amount that will be transferred automatically when the invoice is paid.</summary>
        /// <remarks>
        /// If no amount is set, the full amount is transferred.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#amount Invoice#amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Amount
        {
            get;
            set;
        }
    }
}
