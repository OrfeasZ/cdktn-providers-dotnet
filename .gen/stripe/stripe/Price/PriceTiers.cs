using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.price.PriceTiers")]
    public class PriceTiers : stripe.Price.IPriceTiers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#up_to Price#up_to}.</summary>
        [JsiiProperty(name: "upTo", typeJson: "{\"primitive\":\"string\"}")]
        public string UpTo
        {
            get;
            set;
        }

        /// <summary>The flat billing amount for an entire tier, regardless of the number of units in the tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#flat_amount Price#flat_amount}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#flat_amount_decimal Price#flat_amount_decimal}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#unit_amount Price#unit_amount}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#unit_amount_decimal Price#unit_amount_decimal}
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
