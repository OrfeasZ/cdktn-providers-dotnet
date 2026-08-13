using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.InvoiceItem
{
    [JsiiByValue(fqn: "stripe.invoiceItem.InvoiceItemDiscounts")]
    public class InvoiceItemDiscounts : stripe.InvoiceItem.IInvoiceItemDiscounts
    {
        /// <summary>ID of the coupon to create a new discount for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#coupon InvoiceItem#coupon}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coupon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Coupon
        {
            get;
            set;
        }

        /// <summary>ID of an existing discount on the object (or one of its ancestors) to reuse.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#discount InvoiceItem#discount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "discount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Discount
        {
            get;
            set;
        }

        /// <summary>ID of the promotion code to create a new discount for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#promotion_code InvoiceItem#promotion_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "promotionCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PromotionCode
        {
            get;
            set;
        }
    }
}
