using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.price.PriceTiers")]
    public class PriceTiers : stripe.Price.IPriceTiers
    {
        /// <summary>Up to and including to this quantity will be contained in the tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#up_to Price#up_to}
        /// </remarks>
        [JsiiProperty(name: "upTo", typeJson: "{\"primitive\":\"string\"}")]
        public string UpTo
        {
            get;
            set;
        }

        /// <summary>Price for the entire tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#flat_amount Price#flat_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flatAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FlatAmount
        {
            get;
            set;
        }

        /// <summary>Same as `flat_amount`, but contains a decimal value with at most 12 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#flat_amount_decimal Price#flat_amount_decimal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flatAmountDecimal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FlatAmountDecimal
        {
            get;
            set;
        }

        /// <summary>Per unit price for units relevant to the tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#unit_amount Price#unit_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnitAmount
        {
            get;
            set;
        }

        /// <summary>Same as `unit_amount`, but contains a decimal value with at most 12 decimal places.</summary>
        /// <remarks>
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
