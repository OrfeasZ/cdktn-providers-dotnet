using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiInterface(nativeType: typeof(IQuoteLineItems), fullyQualifiedName: "stripe.quote.QuoteLineItems")]
    public interface IQuoteLineItems
    {
        /// <summary>The discounts applied to this line item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#discounts Quote#discounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Quote.IQuoteLineItemsDiscounts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.quote.QuoteLineItemsDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Discounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the price object. One of `price` or `price_data` is required.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#price Quote#price}
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

        /// <summary>Data used to generate a new [Price](https://docs.stripe.com/api/prices) object inline. One of `price` or `price_data` is required.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#price_data Quote#price_data}
        /// </remarks>
        [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.quote.QuoteLineItemsPriceData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Quote.IQuoteLineItemsPriceData? PriceData
        {
            get
            {
                return null;
            }
        }

        /// <summary>The quantity of the line item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#quantity Quote#quantity}
        /// </remarks>
        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Quantity
        {
            get
            {
                return null;
            }
        }

        /// <summary>The tax rates which apply to the line item.</summary>
        /// <remarks>
        /// When set, the <c>default_tax_rates</c> on the quote do not apply to this line item.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#tax_rates Quote#tax_rates}
        /// </remarks>
        [JsiiProperty(name: "taxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TaxRates
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuoteLineItems), fullyQualifiedName: "stripe.quote.QuoteLineItems")]
        internal sealed class _Proxy : DeputyBase, stripe.Quote.IQuoteLineItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The discounts applied to this line item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#discounts Quote#discounts}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Quote.IQuoteLineItemsDiscounts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.quote.QuoteLineItemsDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Discounts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The ID of the price object. One of `price` or `price_data` is required.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#price Quote#price}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Price
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Data used to generate a new [Price](https://docs.stripe.com/api/prices) object inline. One of `price` or `price_data` is required.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#price_data Quote#price_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.quote.QuoteLineItemsPriceData\"}", isOptional: true)]
            public stripe.Quote.IQuoteLineItemsPriceData? PriceData
            {
                get => GetInstanceProperty<stripe.Quote.IQuoteLineItemsPriceData?>();
            }

            /// <summary>The quantity of the line item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#quantity Quote#quantity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Quantity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The tax rates which apply to the line item.</summary>
            /// <remarks>
            /// When set, the <c>default_tax_rates</c> on the quote do not apply to this line item.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/quote#tax_rates Quote#tax_rates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TaxRates
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
