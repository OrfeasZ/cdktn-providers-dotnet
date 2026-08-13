using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscription.SubscriptionTrialSettingsEndBehavior")]
    public class SubscriptionTrialSettingsEndBehavior : stripe.Subscription.ISubscriptionTrialSettingsEndBehavior
    {
        /// <summary>Indicates how the subscription should change when the trial ends if the user did not provide a payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#missing_payment_method Subscription#missing_payment_method}
        /// </remarks>
        [JsiiProperty(name: "missingPaymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string MissingPaymentMethod
        {
            get;
            set;
        }
    }
}
