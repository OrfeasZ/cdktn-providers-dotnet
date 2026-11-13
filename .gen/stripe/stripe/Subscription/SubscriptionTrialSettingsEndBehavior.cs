using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionTrialSettingsEndBehavior")]
    public class SubscriptionTrialSettingsEndBehavior : stripe.Subscription.ISubscriptionTrialSettingsEndBehavior
    {
        /// <summary>Indicates how the subscription's billing cycle anchor is reset when a trial ends.</summary>
        /// <remarks>
        /// If not set, the default is <c>now</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#billing_cycle_anchor Subscription#billing_cycle_anchor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingCycleAnchor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BillingCycleAnchor
        {
            get;
            set;
        }

        /// <summary>Indicates how the subscription should change when the trial ends if the user did not provide a payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#missing_payment_method Subscription#missing_payment_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "missingPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MissingPaymentMethod
        {
            get;
            set;
        }
    }
}
