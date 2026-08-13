using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscription.SubscriptionItemsBillingThresholds")]
    public class SubscriptionItemsBillingThresholds : stripe.Subscription.ISubscriptionItemsBillingThresholds
    {
        /// <summary>Number of units that meets the billing threshold to advance the subscription to a new billing period (e.g., it takes 10 $5 units to meet a $50 [monetary threshold](https://docs.stripe.com/api/subscriptions/update#update_subscription-billing_thresholds-amount_gte)).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#usage_gte Subscription#usage_gte}
        /// </remarks>
        [JsiiProperty(name: "usageGte", typeJson: "{\"primitive\":\"number\"}")]
        public double UsageGte
        {
            get;
            set;
        }
    }
}
