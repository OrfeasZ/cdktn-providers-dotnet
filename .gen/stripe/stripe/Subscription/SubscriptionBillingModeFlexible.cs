using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionBillingModeFlexible")]
    public class SubscriptionBillingModeFlexible : stripe.Subscription.ISubscriptionBillingModeFlexible
    {
        /// <summary>Controls how invoices and invoice items display proration amounts and discount amounts.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#proration_discounts Subscription#proration_discounts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prorationDiscounts", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProrationDiscounts
        {
            get;
            set;
        }
    }
}
