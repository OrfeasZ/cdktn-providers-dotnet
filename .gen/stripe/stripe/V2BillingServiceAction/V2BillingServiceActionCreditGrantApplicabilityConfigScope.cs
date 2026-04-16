using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    [JsiiByValue(fqn: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigScope")]
    public class V2BillingServiceActionCreditGrantApplicabilityConfigScope : stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfigScope
    {
        /// <summary>The billable items to apply the credit grant to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#billable_items V2BillingServiceAction#billable_items}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billableItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BillableItems
        {
            get;
            set;
        }

        /// <summary>The price type that credit grants can apply to.</summary>
        /// <remarks>
        /// We currently only support the <c>metered</c> price type. This will apply to metered prices and rate cards. Cannot be used in combination with <c>billable_items</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#price_type V2BillingServiceAction#price_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PriceType
        {
            get;
            set;
        }
    }
}
