using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPix")]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsPix : stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPix
    {
        /// <summary>The number of seconds after PaymentIntent confirmation when the Pix expires (between 60 and 1209600, inclusive).</summary>
        /// <remarks>
        /// If unspecified, defaults to 14400 seconds (4 hours).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#expires_after_seconds Subscription#expires_after_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiresAfterSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpiresAfterSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/subscription#mandate_options Subscription#mandate_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mandateOptions", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptions\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptions? MandateOptions
        {
            get;
            set;
        }
    }
}
