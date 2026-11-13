using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionItem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscriptionItem.SubscriptionItemCurrentTrial")]
    public class SubscriptionItemCurrentTrial : stripe.SubscriptionItem.ISubscriptionItemCurrentTrial
    {
        /// <summary>The Trial Offer ID applied to the subscription item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription_item#trial_offer SubscriptionItem#trial_offer}
        /// </remarks>
        [JsiiProperty(name: "trialOffer", typeJson: "{\"primitive\":\"string\"}")]
        public string TrialOffer
        {
            get;
            set;
        }
    }
}
