using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    [JsiiInterface(nativeType: typeof(IPriceCurrencyOptions), fullyQualifiedName: "stripe.price.PriceCurrencyOptions")]
    public interface IPriceCurrencyOptions
    {
        /// <summary>Key for this entry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#key Price#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>custom_unit_amount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#custom_unit_amount Price#custom_unit_amount}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Price.IPriceCurrencyOptionsCustomUnitAmount" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customUnitAmount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.price.PriceCurrencyOptionsCustomUnitAmount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomUnitAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Only required if a [default tax behavior](https://docs.stripe.com/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)) was not provided in the Stripe Tax settings. Specifies whether the price is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`. Once specified as either `inclusive` or `exclusive`, it cannot be changed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#tax_behavior Price#tax_behavior}
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

        /// <summary>Each element represents a pricing tier.</summary>
        /// <remarks>
        /// This parameter requires <c>billing_scheme</c> to be set to <c>tiered</c>. See also the documentation for <c>billing_scheme</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#tiers Price#tiers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Price.IPriceCurrencyOptionsTiers" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.price.PriceCurrencyOptionsTiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tiers
        {
            get
            {
                return null;
            }
        }

        /// <summary>The unit amount in cents (or local equivalent) to be charged, represented as a whole integer if possible.</summary>
        /// <remarks>
        /// Only set if <c>billing_scheme=per_unit</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#unit_amount Price#unit_amount}
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

        /// <summary>The unit amount in cents (or local equivalent) to be charged, represented as a decimal string with at most 12 decimal places.</summary>
        /// <remarks>
        /// Only set if <c>billing_scheme=per_unit</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#unit_amount_decimal Price#unit_amount_decimal}
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

        [JsiiTypeProxy(nativeType: typeof(IPriceCurrencyOptions), fullyQualifiedName: "stripe.price.PriceCurrencyOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.Price.IPriceCurrencyOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Key for this entry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#key Price#key}
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>custom_unit_amount block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#custom_unit_amount Price#custom_unit_amount}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Price.IPriceCurrencyOptionsCustomUnitAmount" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customUnitAmount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.price.PriceCurrencyOptionsCustomUnitAmount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomUnitAmount
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Only required if a [default tax behavior](https://docs.stripe.com/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)) was not provided in the Stripe Tax settings. Specifies whether the price is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`. Once specified as either `inclusive` or `exclusive`, it cannot be changed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#tax_behavior Price#tax_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Each element represents a pricing tier.</summary>
            /// <remarks>
            /// This parameter requires <c>billing_scheme</c> to be set to <c>tiered</c>. See also the documentation for <c>billing_scheme</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#tiers Price#tiers}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Price.IPriceCurrencyOptionsTiers" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.price.PriceCurrencyOptionsTiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tiers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The unit amount in cents (or local equivalent) to be charged, represented as a whole integer if possible.</summary>
            /// <remarks>
            /// Only set if <c>billing_scheme=per_unit</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#unit_amount Price#unit_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnitAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The unit amount in cents (or local equivalent) to be charged, represented as a decimal string with at most 12 decimal places.</summary>
            /// <remarks>
            /// Only set if <c>billing_scheme=per_unit</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#unit_amount_decimal Price#unit_amount_decimal}
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
