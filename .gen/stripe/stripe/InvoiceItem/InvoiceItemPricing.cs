using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.InvoiceItem
{
    [JsiiByValue(fqn: "stripe.invoiceItem.InvoiceItemPricing")]
    public class InvoiceItemPricing : stripe.InvoiceItem.IInvoiceItemPricing
    {
        /// <summary>The ID of the price object.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#price_details InvoiceItem#price_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priceDetails", typeJson: "{\"fqn\":\"stripe.invoiceItem.InvoiceItemPricingPriceDetails\"}", isOptional: true)]
        public stripe.InvoiceItem.IInvoiceItemPricingPriceDetails? PriceDetails
        {
            get;
            set;
        }

        /// <summary>The type of the pricing details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#type InvoiceItem#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>The unit amount (in the `currency` specified) of the item which contains a decimal value with at most 12 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#unit_amount_decimal InvoiceItem#unit_amount_decimal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnitAmountDecimal
        {
            get;
            set;
        }
    }
}
