using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    [JsiiInterface(nativeType: typeof(IPriceConfig), fullyQualifiedName: "stripe.price.PriceConfig")]
    public interface IPriceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#currency Price#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>Whether the price can be used for new purchases. Defaults to `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#active Price#active}
        /// </remarks>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Active
        {
            get
            {
                return null;
            }
        }

        /// <summary>Describes how to compute the price per period.</summary>
        /// <remarks>
        /// Either <c>per_unit</c> or <c>tiered</c>. <c>per_unit</c> indicates that the fixed amount (specified in <c>unit_amount</c> or <c>unit_amount_decimal</c>) will be charged per unit in <c>quantity</c> (for prices with <c>usage_type=licensed</c>), or per unit of total usage (for prices with <c>usage_type=metered</c>). <c>tiered</c> indicates that the unit pricing will be computed using a tiering strategy as defined using the <c>tiers</c> and <c>tiers_mode</c> attributes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#billing_scheme Price#billing_scheme}
        /// </remarks>
        [JsiiProperty(name: "billingScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BillingScheme
        {
            get
            {
                return null;
            }
        }

        /// <summary>currency_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#currency_options Price#currency_options}
        /// </remarks>
        [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.price.PriceCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#custom_unit_amount Price#custom_unit_amount}
        /// </remarks>
        [JsiiProperty(name: "customUnitAmount", typeJson: "{\"fqn\":\"stripe.price.PriceCustomUnitAmount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Price.IPriceCustomUnitAmount? CustomUnitAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>A lookup key used to retrieve prices dynamically from a static string. This may be up to 200 characters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#lookup_key Price#lookup_key}
        /// </remarks>
        [JsiiProperty(name: "lookupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LookupKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#metadata Price#metadata}
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

        /// <summary>A brief description of the price, hidden from customers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#nickname Price#nickname}
        /// </remarks>
        [JsiiProperty(name: "nickname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Nickname
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the [Product](https://docs.stripe.com/api/products) that this [Price](https://docs.stripe.com/api/prices) will belong to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#product Price#product}
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

        /// <summary>product_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#product_data Price#product_data}
        /// </remarks>
        [JsiiProperty(name: "productData", typeJson: "{\"fqn\":\"stripe.price.PriceProductData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Price.IPriceProductData? ProductData
        {
            get
            {
                return null;
            }
        }

        /// <summary>recurring block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#recurring Price#recurring}
        /// </remarks>
        [JsiiProperty(name: "recurring", typeJson: "{\"fqn\":\"stripe.price.PriceRecurring\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Price.IPriceRecurring? Recurring
        {
            get
            {
                return null;
            }
        }

        /// <summary>Only required if a [default tax behavior](https://stripe.com/docs/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)) was not provided in the Stripe Tax settings. Specifies whether the price is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`. Once specified as either `inclusive` or `exclusive`, it cannot be changed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#tax_behavior Price#tax_behavior}
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

        /// <summary>tiers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#tiers Price#tiers}
        /// </remarks>
        [JsiiProperty(name: "tiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.price.PriceTiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tiers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines if the tiering price should be `graduated` or `volume` based.</summary>
        /// <remarks>
        /// In <c>volume</c>-based tiering, the maximum quantity within a period determines the per unit price, in <c>graduated</c> tiering pricing can successively change as the quantity grows.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#tiers_mode Price#tiers_mode}
        /// </remarks>
        [JsiiProperty(name: "tiersMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TiersMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>A positive integer in cents (or local equivalent) (or 0 for a free price) representing how much to charge.</summary>
        /// <remarks>
        /// One of <c>unit_amount</c>, <c>unit_amount_decimal</c>, or <c>custom_unit_amount</c> is required, unless <c>billing_scheme=tiered</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#unit_amount Price#unit_amount}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#unit_amount_decimal Price#unit_amount_decimal}
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

        [JsiiTypeProxy(nativeType: typeof(IPriceConfig), fullyQualifiedName: "stripe.price.PriceConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.Price.IPriceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#currency Price#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether the price can be used for new purchases. Defaults to `true`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#active Price#active}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Describes how to compute the price per period.</summary>
            /// <remarks>
            /// Either <c>per_unit</c> or <c>tiered</c>. <c>per_unit</c> indicates that the fixed amount (specified in <c>unit_amount</c> or <c>unit_amount_decimal</c>) will be charged per unit in <c>quantity</c> (for prices with <c>usage_type=licensed</c>), or per unit of total usage (for prices with <c>usage_type=metered</c>). <c>tiered</c> indicates that the unit pricing will be computed using a tiering strategy as defined using the <c>tiers</c> and <c>tiers_mode</c> attributes.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#billing_scheme Price#billing_scheme}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BillingScheme
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>currency_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#currency_options Price#currency_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.price.PriceCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CurrencyOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_unit_amount block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#custom_unit_amount Price#custom_unit_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customUnitAmount", typeJson: "{\"fqn\":\"stripe.price.PriceCustomUnitAmount\"}", isOptional: true)]
            public stripe.Price.IPriceCustomUnitAmount? CustomUnitAmount
            {
                get => GetInstanceProperty<stripe.Price.IPriceCustomUnitAmount?>();
            }

            /// <summary>A lookup key used to retrieve prices dynamically from a static string. This may be up to 200 characters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#lookup_key Price#lookup_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lookupKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LookupKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#metadata Price#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A brief description of the price, hidden from customers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#nickname Price#nickname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nickname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Nickname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the [Product](https://docs.stripe.com/api/products) that this [Price](https://docs.stripe.com/api/prices) will belong to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#product Price#product}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Product
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>product_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#product_data Price#product_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "productData", typeJson: "{\"fqn\":\"stripe.price.PriceProductData\"}", isOptional: true)]
            public stripe.Price.IPriceProductData? ProductData
            {
                get => GetInstanceProperty<stripe.Price.IPriceProductData?>();
            }

            /// <summary>recurring block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#recurring Price#recurring}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recurring", typeJson: "{\"fqn\":\"stripe.price.PriceRecurring\"}", isOptional: true)]
            public stripe.Price.IPriceRecurring? Recurring
            {
                get => GetInstanceProperty<stripe.Price.IPriceRecurring?>();
            }

            /// <summary>Only required if a [default tax behavior](https://stripe.com/docs/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)) was not provided in the Stripe Tax settings. Specifies whether the price is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`. Once specified as either `inclusive` or `exclusive`, it cannot be changed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#tax_behavior Price#tax_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tiers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#tiers Price#tiers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.price.PriceTiers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tiers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines if the tiering price should be `graduated` or `volume` based.</summary>
            /// <remarks>
            /// In <c>volume</c>-based tiering, the maximum quantity within a period determines the per unit price, in <c>graduated</c> tiering pricing can successively change as the quantity grows.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#tiers_mode Price#tiers_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tiersMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TiersMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A positive integer in cents (or local equivalent) (or 0 for a free price) representing how much to charge.</summary>
            /// <remarks>
            /// One of <c>unit_amount</c>, <c>unit_amount_decimal</c>, or <c>custom_unit_amount</c> is required, unless <c>billing_scheme=tiered</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#unit_amount Price#unit_amount}
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#unit_amount_decimal Price#unit_amount_decimal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnitAmountDecimal
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
