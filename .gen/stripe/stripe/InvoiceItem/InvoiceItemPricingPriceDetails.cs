using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.InvoiceItem
{
    [JsiiByValue(fqn: "stripe.invoiceItem.InvoiceItemPricingPriceDetails")]
    public class InvoiceItemPricingPriceDetails : stripe.InvoiceItem.IInvoiceItemPricingPriceDetails
    {
        /// <summary>The ID of the price this item is associated with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#price InvoiceItem#price}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Price
        {
            get;
            set;
        }

        /// <summary>The ID of the product this item is associated with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#product InvoiceItem#product}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Product
        {
            get;
            set;
        }
    }
}
