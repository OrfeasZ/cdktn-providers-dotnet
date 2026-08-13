using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.price.PriceCurrencyOptions")]
    public class PriceCurrencyOptions : stripe.Price.IPriceCurrencyOptions
    {
        /// <summary>Key for this entry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#key Price#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        private object? _customUnitAmount;

        /// <summary>custom_unit_amount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#custom_unit_amount Price#custom_unit_amount}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Price.IPriceCurrencyOptionsCustomUnitAmount" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customUnitAmount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.price.PriceCurrencyOptionsCustomUnitAmount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomUnitAmount
        {
            get => _customUnitAmount;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Price.IPriceCurrencyOptionsCustomUnitAmount[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Price.IPriceCurrencyOptionsCustomUnitAmount).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customUnitAmount = value;
            }
        }

        /// <summary>Only required if a [default tax behavior](https://docs.stripe.com/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)) was not provided in the Stripe Tax settings. Specifies whether the price is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`. Once specified as either `inclusive` or `exclusive`, it cannot be changed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#tax_behavior Price#tax_behavior}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaxBehavior
        {
            get;
            set;
        }

        private object? _tiers;

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
            get => _tiers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Price.IPriceCurrencyOptionsTiers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Price.IPriceCurrencyOptionsTiers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tiers = value;
            }
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
            get;
            set;
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
            get;
            set;
        }
    }
}
