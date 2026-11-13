using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscription.SubscriptionItemsCurrentTrial")]
    public class SubscriptionItemsCurrentTrial : stripe.Subscription.ISubscriptionItemsCurrentTrial
    {
        /// <summary>The ID of the trial offer to apply to the subscription item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#trial_offer Subscription#trial_offer}
        /// </remarks>
        [JsiiProperty(name: "trialOffer", typeJson: "{\"primitive\":\"string\"}")]
        public string TrialOffer
        {
            get;
            set;
        }
    }
}
