using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Plan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.plan.PlanTiers")]
    public class PlanTiers : stripe.Plan.IPlanTiers
    {
        /// <summary>Up to and including to this quantity will be contained in the tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#up_to Plan#up_to}
        /// </remarks>
        [JsiiProperty(name: "upTo", typeJson: "{\"primitive\":\"number\"}")]
        public double UpTo
        {
            get;
            set;
        }

        /// <summary>Price for the entire tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#flat_amount Plan#flat_amount}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#flat_amount_decimal Plan#flat_amount_decimal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flatAmountDecimal", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FlatAmountDecimal
        {
            get;
            set;
        }

        /// <summary>Per unit price for units relevant to the tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#unit_amount Plan#unit_amount}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#unit_amount_decimal Plan#unit_amount_decimal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnitAmountDecimal
        {
            get;
            set;
        }
    }
}
