using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscription.SubscriptionTrialSettings")]
    public class SubscriptionTrialSettings : stripe.Subscription.ISubscriptionTrialSettings
    {
        /// <summary>Defines how a subscription behaves when a trial ends.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#end_behavior Subscription#end_behavior}
        /// </remarks>
        [JsiiProperty(name: "endBehavior", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionTrialSettingsEndBehavior\"}")]
        public stripe.Subscription.ISubscriptionTrialSettingsEndBehavior EndBehavior
        {
            get;
            set;
        }
    }
}
