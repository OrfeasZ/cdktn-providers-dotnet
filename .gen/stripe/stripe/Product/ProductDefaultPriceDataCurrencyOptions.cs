using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.product.ProductDefaultPriceDataCurrencyOptions")]
    public class ProductDefaultPriceDataCurrencyOptions : stripe.Product.IProductDefaultPriceDataCurrencyOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#key Product#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>custom_unit_amount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#custom_unit_amount Product#custom_unit_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customUnitAmount", typeJson: "{\"fqn\":\"stripe.product.ProductDefaultPriceDataCurrencyOptionsCustomUnitAmount\"}", isOptional: true)]
        public stripe.Product.IProductDefaultPriceDataCurrencyOptionsCustomUnitAmount? CustomUnitAmount
        {
            get;
            set;
        }

        /// <summary>Only required if a [default tax behavior](https://stripe.com/docs/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)) was not provided in the Stripe Tax settings. Specifies whether the price is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`. Once specified as either `inclusive` or `exclusive`, it cannot be changed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#tax_behavior Product#tax_behavior}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#tiers Product#tiers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tiers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case string[][] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, string[][]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tiers = value;
            }
        }

        /// <summary>A positive integer in cents (or local equivalent) (or 0 for a free price) representing how much to charge.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#unit_amount Product#unit_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnitAmount
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
