using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.InvoiceItem
{
    [JsiiInterface(nativeType: typeof(IInvoiceItemPricingPriceDetails), fullyQualifiedName: "stripe.invoiceItem.InvoiceItemPricingPriceDetails")]
    public interface IInvoiceItemPricingPriceDetails
    {
        /// <summary>The ID of the price this item is associated with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#price InvoiceItem#price}
        /// </remarks>
        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Price
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the product this item is associated with.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#product InvoiceItem#product}
        /// </remarks>
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Product
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceItemPricingPriceDetails), fullyQualifiedName: "stripe.invoiceItem.InvoiceItemPricingPriceDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.InvoiceItem.IInvoiceItemPricingPriceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the price this item is associated with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#price InvoiceItem#price}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Price
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the product this item is associated with.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#product InvoiceItem#product}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Product
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
