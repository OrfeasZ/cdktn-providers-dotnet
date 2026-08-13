using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionItem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscriptionItem.SubscriptionItemBillingThresholds")]
    public class SubscriptionItemBillingThresholds : stripe.SubscriptionItem.ISubscriptionItemBillingThresholds
    {
        /// <summary>Usage threshold that triggers the subscription to create an invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#usage_gte SubscriptionItem#usage_gte}
        /// </remarks>
        [JsiiProperty(name: "usageGte", typeJson: "{\"primitive\":\"number\"}")]
        public double UsageGte
        {
            get;
            set;
        }
    }
}
