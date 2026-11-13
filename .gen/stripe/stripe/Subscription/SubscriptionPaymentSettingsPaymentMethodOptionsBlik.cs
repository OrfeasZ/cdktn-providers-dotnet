using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBlik")]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsBlik : stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBlik
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#mandate_options Subscription#mandate_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions? MandateOptions
        {
            get;
            set;
        }
    }
}
