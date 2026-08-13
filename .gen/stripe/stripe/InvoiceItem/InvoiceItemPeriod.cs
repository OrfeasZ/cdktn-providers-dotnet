using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.InvoiceItem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.invoiceItem.InvoiceItemPeriod")]
    public class InvoiceItemPeriod : stripe.InvoiceItem.IInvoiceItemPeriod
    {
        /// <summary>The end of the period, which must be greater than or equal to the start. This value is inclusive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#end InvoiceItem#end}
        /// </remarks>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}")]
        public double End
        {
            get;
            set;
        }

        /// <summary>The start of the period. This value is inclusive.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#start InvoiceItem#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        public double Start
        {
            get;
            set;
        }
    }
}
