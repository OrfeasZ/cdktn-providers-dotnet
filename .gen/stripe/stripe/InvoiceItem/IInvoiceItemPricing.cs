using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.InvoiceItem
{
    [JsiiInterface(nativeType: typeof(IInvoiceItemPricing), fullyQualifiedName: "stripe.invoiceItem.InvoiceItemPricing")]
    public interface IInvoiceItemPricing
    {
        /// <summary>The ID of the price object.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#price_details InvoiceItem#price_details}.</summary>
        [JsiiProperty(name: "priceDetails", typeJson: "{\"fqn\":\"stripe.invoiceItem.InvoiceItemPricingPriceDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.InvoiceItem.IInvoiceItemPricingPriceDetails? PriceDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of the pricing details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#type InvoiceItem#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>The unit amount (in the `currency` specified) of the item which contains a decimal value with at most 12 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#unit_amount_decimal InvoiceItem#unit_amount_decimal}
        /// </remarks>
        [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UnitAmountDecimal
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceItemPricing), fullyQualifiedName: "stripe.invoiceItem.InvoiceItemPricing")]
        internal sealed class _Proxy : DeputyBase, stripe.InvoiceItem.IInvoiceItemPricing
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the price object.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#price InvoiceItem#price}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Price
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#price_details InvoiceItem#price_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priceDetails", typeJson: "{\"fqn\":\"stripe.invoiceItem.InvoiceItemPricingPriceDetails\"}", isOptional: true)]
            public stripe.InvoiceItem.IInvoiceItemPricingPriceDetails? PriceDetails
            {
                get => GetInstanceProperty<stripe.InvoiceItem.IInvoiceItemPricingPriceDetails?>();
            }

            /// <summary>The type of the pricing details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#type InvoiceItem#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The unit amount (in the `currency` specified) of the item which contains a decimal value with at most 12 decimal places.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice_item#unit_amount_decimal InvoiceItem#unit_amount_decimal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnitAmountDecimal
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
