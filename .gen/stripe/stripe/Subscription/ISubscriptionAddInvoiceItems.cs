using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionAddInvoiceItems), fullyQualifiedName: "stripe.subscription.SubscriptionAddInvoiceItems")]
    public interface ISubscriptionAddInvoiceItems
    {
        /// <summary>Controls whether discounts apply to this invoice item. Defaults to true if no value is provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#discountable Subscription#discountable}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "discountable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Discountable
        {
            get
            {
                return null;
            }
        }

        /// <summary>The coupons to redeem into discounts for the item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#discounts Subscription#discounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionAddInvoiceItemsDiscounts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Discounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#metadata Subscription#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>The period associated with this invoice item. If not set, `period.start.type` defaults to `max_item_period_start` and `period.end.type` defaults to `min_item_period_end`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#period Subscription#period}
        /// </remarks>
        [JsiiProperty(name: "period", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionAddInvoiceItemsPeriod? Period
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the price object. One of `price` or `price_data` is required.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#price Subscription#price}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#price_data Subscription#price_data}
        /// </remarks>
        [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPriceData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionAddInvoiceItemsPriceData? PriceData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Quantity for this item. Defaults to 1.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#quantity Subscription#quantity}
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

        /// <summary>The tax rates which apply to the item. When set, the `default_tax_rates` do not apply to this item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#tax_rates Subscription#tax_rates}
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

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionAddInvoiceItems), fullyQualifiedName: "stripe.subscription.SubscriptionAddInvoiceItems")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionAddInvoiceItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether discounts apply to this invoice item. Defaults to true if no value is provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#discountable Subscription#discountable}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discountable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Discountable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The coupons to redeem into discounts for the item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#discounts Subscription#discounts}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionAddInvoiceItemsDiscounts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Discounts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#metadata Subscription#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>The period associated with this invoice item. If not set, `period.start.type` defaults to `max_item_period_start` and `period.end.type` defaults to `min_item_period_end`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#period Subscription#period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "period", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriod\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionAddInvoiceItemsPeriod? Period
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionAddInvoiceItemsPeriod?>();
            }

            /// <summary>The ID of the price object. One of `price` or `price_data` is required.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#price Subscription#price}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Price
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Data used to generate a new [Price](https://docs.stripe.com/api/prices) object inline. One of `price` or `price_data` is required.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#price_data Subscription#price_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPriceData\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionAddInvoiceItemsPriceData? PriceData
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionAddInvoiceItemsPriceData?>();
            }

            /// <summary>Quantity for this item. Defaults to 1.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#quantity Subscription#quantity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Quantity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The tax rates which apply to the item. When set, the `default_tax_rates` do not apply to this item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#tax_rates Subscription#tax_rates}
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
