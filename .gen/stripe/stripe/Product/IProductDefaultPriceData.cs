using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    [JsiiInterface(nativeType: typeof(IProductDefaultPriceData), fullyQualifiedName: "stripe.product.ProductDefaultPriceData")]
    public interface IProductDefaultPriceData
    {
        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#currency Product#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>currency_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#currency_options Product#currency_options}
        /// </remarks>
        [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.product.ProductDefaultPriceDataCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CurrencyOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_unit_amount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#custom_unit_amount Product#custom_unit_amount}
        /// </remarks>
        [JsiiProperty(name: "customUnitAmount", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceDataCustomUnitAmount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Product.IProductDefaultPriceDataCustomUnitAmount? CustomUnitAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#metadata Product#metadata}
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

        /// <summary>recurring block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#recurring Product#recurring}
        /// </remarks>
        [JsiiProperty(name: "recurring", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceDataRecurring\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Product.IProductDefaultPriceDataRecurring? Recurring
        {
            get
            {
                return null;
            }
        }

        /// <summary>Only required if a [default tax behavior](https://stripe.com/docs/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)) was not provided in the Stripe Tax settings. Specifies whether the price is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`. Once specified as either `inclusive` or `exclusive`, it cannot be changed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#tax_behavior Product#tax_behavior}
        /// </remarks>
        [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaxBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>A positive integer in cents (or local equivalent) (or 0 for a free price) representing how much to charge.</summary>
        /// <remarks>
        /// One of <c>unit_amount</c>, <c>unit_amount_decimal</c>, or <c>custom_unit_amount</c> is required.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#unit_amount Product#unit_amount}
        /// </remarks>
        [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UnitAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Same as `unit_amount`, but accepts a decimal value in cents (or local equivalent) with at most 12 decimal places.</summary>
        /// <remarks>
        /// Only one of <c>unit_amount</c> and <c>unit_amount_decimal</c> can be set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#unit_amount_decimal Product#unit_amount_decimal}
        /// </remarks>
        [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UnitAmountDecimal
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IProductDefaultPriceData), fullyQualifiedName: "stripe.product.ProductDefaultPriceData")]
        internal sealed class _Proxy : DeputyBase, stripe.Product.IProductDefaultPriceData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#currency Product#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>currency_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#currency_options Product#currency_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.product.ProductDefaultPriceDataCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CurrencyOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_unit_amount block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#custom_unit_amount Product#custom_unit_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customUnitAmount", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceDataCustomUnitAmount\"}", isOptional: true)]
            public stripe.Product.IProductDefaultPriceDataCustomUnitAmount? CustomUnitAmount
            {
                get => GetInstanceProperty<stripe.Product.IProductDefaultPriceDataCustomUnitAmount?>();
            }

            /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#metadata Product#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>recurring block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#recurring Product#recurring}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recurring", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceDataRecurring\"}", isOptional: true)]
            public stripe.Product.IProductDefaultPriceDataRecurring? Recurring
            {
                get => GetInstanceProperty<stripe.Product.IProductDefaultPriceDataRecurring?>();
            }

            /// <summary>Only required if a [default tax behavior](https://stripe.com/docs/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)) was not provided in the Stripe Tax settings. Specifies whether the price is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`. Once specified as either `inclusive` or `exclusive`, it cannot be changed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#tax_behavior Product#tax_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A positive integer in cents (or local equivalent) (or 0 for a free price) representing how much to charge.</summary>
            /// <remarks>
            /// One of <c>unit_amount</c>, <c>unit_amount_decimal</c>, or <c>custom_unit_amount</c> is required.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#unit_amount Product#unit_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnitAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Same as `unit_amount`, but accepts a decimal value in cents (or local equivalent) with at most 12 decimal places.</summary>
            /// <remarks>
            /// Only one of <c>unit_amount</c> and <c>unit_amount_decimal</c> can be set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#unit_amount_decimal Product#unit_amount_decimal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnitAmountDecimal
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
