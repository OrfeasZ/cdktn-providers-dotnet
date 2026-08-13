using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.product.ProductDefaultPriceDataCurrencyOptionsTiers")]
    public class ProductDefaultPriceDataCurrencyOptionsTiers : stripe.Product.IProductDefaultPriceDataCurrencyOptionsTiers
    {
        /// <summary>Specifies the upper bound of this tier.</summary>
        /// <remarks>
        /// The lower bound of a tier is the upper bound of the previous tier adding one. Use <c>inf</c> to define a fallback tier.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#up_to Product#up_to}
        /// </remarks>
        [JsiiProperty(name: "upTo", typeJson: "{\"primitive\":\"number\"}")]
        public double UpTo
        {
            get;
            set;
        }

        /// <summary>The flat billing amount for an entire tier, regardless of the number of units in the tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#flat_amount Product#flat_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flatAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FlatAmount
        {
            get;
            set;
        }

        /// <summary>Same as `flat_amount`, but accepts a decimal value representing an integer in the minor units of the currency.</summary>
        /// <remarks>
        /// Only one of <c>flat_amount</c> and <c>flat_amount_decimal</c> can be set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#flat_amount_decimal Product#flat_amount_decimal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flatAmountDecimal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FlatAmountDecimal
        {
            get;
            set;
        }

        /// <summary>The per unit billing amount for each individual unit for which this tier applies.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#unit_amount Product#unit_amount}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#unit_amount_decimal Product#unit_amount_decimal}
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
