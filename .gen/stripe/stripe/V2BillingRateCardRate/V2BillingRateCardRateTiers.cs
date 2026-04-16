using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingRateCardRate
{
    [JsiiByValue(fqn: "stripe.v2BillingRateCardRate.V2BillingRateCardRateTiers")]
    public class V2BillingRateCardRateTiers : stripe.V2BillingRateCardRate.IV2BillingRateCardRateTiers
    {
        /// <summary>Price for the entire tier, represented as a decimal string in minor currency units with at most 12 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#flat_amount V2BillingRateCardRate#flat_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flatAmount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FlatAmount
        {
            get;
            set;
        }

        /// <summary>Per-unit price for units included in this tier, represented as a decimal string in minor currency units with at most 12 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#unit_amount V2BillingRateCardRate#unit_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UnitAmount
        {
            get;
            set;
        }

        /// <summary>Up to and including this quantity will be contained in the tier.</summary>
        /// <remarks>
        /// Only one of <c>up_to_decimal</c> and <c>up_to_inf</c> may be set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#up_to_decimal V2BillingRateCardRate#up_to_decimal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upToDecimal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpToDecimal
        {
            get;
            set;
        }

        /// <summary>No upper bound to this tier. Only one of `up_to_decimal` and `up_to_inf` may be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_rate_card_rate#up_to_inf V2BillingRateCardRate#up_to_inf}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upToInf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpToInf
        {
            get;
            set;
        }
    }
}
